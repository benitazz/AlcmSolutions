using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_bim_categoriesMap : EntityTypeConfiguration<afm_bim_categories>
    {
        public afm_bim_categoriesMap()
        {
            // Primary Key
            this.HasKey(t => t.category_id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(50);

            this.Property(t => t.category_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("afm_bim_categories", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.revit_id).HasColumnName("revit_id");
            this.Property(t => t.category_id).HasColumnName("category_id");
        }
    }
}
