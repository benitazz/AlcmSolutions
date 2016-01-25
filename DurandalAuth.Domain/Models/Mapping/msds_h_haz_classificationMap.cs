using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class msds_h_haz_classificationMap : EntityTypeConfiguration<msds_h_haz_classification>
    {
        public msds_h_haz_classificationMap()
        {
            // Primary Key
            this.HasKey(t => new { t.msds_id, t.hazard_system_id, t.hazard_class_id, t.hazard_category_id, t.date_archived, t.time_archived });

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
            this.ToTable("msds_h_haz_classification", "afm");
            this.Property(t => t.msds_id).HasColumnName("msds_id");
            this.Property(t => t.hazard_system_id).HasColumnName("hazard_system_id");
            this.Property(t => t.hazard_class_id).HasColumnName("hazard_class_id");
            this.Property(t => t.hazard_category_id).HasColumnName("hazard_category_id");
            this.Property(t => t.date_archived).HasColumnName("date_archived");
            this.Property(t => t.time_archived).HasColumnName("time_archived");
        }
    }
}
