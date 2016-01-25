using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class msds_hazard_categoryMap : EntityTypeConfiguration<msds_hazard_category>
    {
        public msds_hazard_categoryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.hazard_system_id, t.hazard_class_id, t.hazard_category_id });

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(2000);

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
            this.ToTable("msds_hazard_category", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.hazard_system_id).HasColumnName("hazard_system_id");
            this.Property(t => t.hazard_class_id).HasColumnName("hazard_class_id");
            this.Property(t => t.hazard_category_id).HasColumnName("hazard_category_id");

            // Relationships
            this.HasRequired(t => t.msds_hazard_class)
                .WithMany(t => t.msds_hazard_category)
                .HasForeignKey(d => new { d.hazard_system_id, d.hazard_class_id });
            this.HasRequired(t => t.msds_hazard_system)
                .WithMany(t => t.msds_hazard_category)
                .HasForeignKey(d => d.hazard_system_id);

        }
    }
}
