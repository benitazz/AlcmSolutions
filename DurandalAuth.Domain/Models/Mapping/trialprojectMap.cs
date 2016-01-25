using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class trialprojectMap : EntityTypeConfiguration<trialproject>
    {
        public trialprojectMap()
        {
            // Primary Key
            this.HasKey(t => t.trial_project_id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.project_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.trial_project_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("trialproject", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.project_id).HasColumnName("project_id");
            this.Property(t => t.trial_project_id).HasColumnName("trial_project_id");

            // Relationships
            this.HasOptional(t => t.project)
                .WithMany(t => t.trialprojects)
                .HasForeignKey(d => d.project_id);

        }
    }
}
