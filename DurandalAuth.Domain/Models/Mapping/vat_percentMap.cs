using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class vat_percentMap : EntityTypeConfiguration<vat_percent>
    {
        public vat_percentMap()
        {
            // Primary Key
            this.HasKey(t => new { t.cost_cat_id, t.ctry_id });

            // Properties
            this.Property(t => t.cost_cat_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.ctry_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("vat_percent", "afm");
            this.Property(t => t.is_exception).HasColumnName("is_exception");
            this.Property(t => t.vat_percent_value).HasColumnName("vat_percent_value");
            this.Property(t => t.cost_cat_id).HasColumnName("cost_cat_id");
            this.Property(t => t.ctry_id).HasColumnName("ctry_id");

            // Relationships
            this.HasRequired(t => t.cost_cat)
                .WithMany(t => t.vat_percent)
                .HasForeignKey(d => d.cost_cat_id);
            this.HasRequired(t => t.ctry)
                .WithMany(t => t.vat_percent)
                .HasForeignKey(d => d.ctry_id);

        }
    }
}
