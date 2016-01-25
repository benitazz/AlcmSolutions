using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class msds_haz_classificationMap : EntityTypeConfiguration<msds_haz_classification>
    {
        public msds_haz_classificationMap()
        {
            // Primary Key
            this.HasKey(t => new { t.msds_id, t.hazard_system_id, t.hazard_class_id, t.hazard_category_id });

            // Properties
            this.Property(t => t.msds_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.hazard_system_id)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.hazard_class_id)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.hazard_category_id)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("msds_haz_classification", "afm");
            this.Property(t => t.msds_id).HasColumnName("msds_id");
            this.Property(t => t.hazard_system_id).HasColumnName("hazard_system_id");
            this.Property(t => t.hazard_class_id).HasColumnName("hazard_class_id");
            this.Property(t => t.hazard_category_id).HasColumnName("hazard_category_id");

            // Relationships
            this.HasRequired(t => t.msds_data)
                .WithMany(t => t.msds_haz_classification)
                .HasForeignKey(d => d.msds_id);
            this.HasRequired(t => t.msds_hazard_category)
                .WithMany(t => t.msds_haz_classification)
                .HasForeignKey(d => new { d.hazard_system_id, d.hazard_class_id, d.hazard_category_id });
            this.HasRequired(t => t.msds_hazard_class)
                .WithMany(t => t.msds_haz_classification)
                .HasForeignKey(d => new { d.hazard_system_id, d.hazard_class_id });
            this.HasRequired(t => t.msds_hazard_system)
                .WithMany(t => t.msds_haz_classification)
                .HasForeignKey(d => d.hazard_system_id);

        }
    }
}
