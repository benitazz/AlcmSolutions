using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class projscnMap : EntityTypeConfiguration<projscn>
    {
        public projscnMap()
        {
            // Primary Key
            this.HasKey(t => new { t.proj_scenario_id, t.project_id, t.fiscal_year, t.fund_id });

            // Properties
            this.Property(t => t.proj_scenario_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.project_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.fiscal_year)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.fund_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("projscns", "afm");
            this.Property(t => t.costs_est_cap).HasColumnName("costs_est_cap");
            this.Property(t => t.costs_est_exp).HasColumnName("costs_est_exp");
            this.Property(t => t.proj_scenario_id).HasColumnName("proj_scenario_id");
            this.Property(t => t.project_id).HasColumnName("project_id");
            this.Property(t => t.fiscal_year).HasColumnName("fiscal_year");
            this.Property(t => t.fund_id).HasColumnName("fund_id");

            // Relationships
            this.HasRequired(t => t.funding)
                .WithMany(t => t.projscns)
                .HasForeignKey(d => d.fund_id);
            this.HasRequired(t => t.project)
                .WithMany(t => t.projscns)
                .HasForeignKey(d => d.project_id);
            this.HasRequired(t => t.scenario)
                .WithMany(t => t.projscns)
                .HasForeignKey(d => d.proj_scenario_id);

        }
    }
}
