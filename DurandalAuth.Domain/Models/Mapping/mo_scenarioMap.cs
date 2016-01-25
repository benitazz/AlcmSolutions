using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class mo_scenarioMap : EntityTypeConfiguration<mo_scenario>
    {
        public mo_scenarioMap()
        {
            // Primary Key
            this.HasKey(t => new { t.project_id, t.scenario_id });

            // Properties
            this.Property(t => t.comments)
                .HasMaxLength(5000);

            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.planner)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.project_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.scenario_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("mo_scenario", "afm");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.date_created).HasColumnName("date_created");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.planner).HasColumnName("planner");
            this.Property(t => t.project_id).HasColumnName("project_id");
            this.Property(t => t.scenario_id).HasColumnName("scenario_id");

            // Relationships
            this.HasOptional(t => t.em)
                .WithMany(t => t.mo_scenario)
                .HasForeignKey(d => d.planner);
            this.HasRequired(t => t.project)
                .WithMany(t => t.mo_scenario)
                .HasForeignKey(d => d.project_id);

        }
    }
}
