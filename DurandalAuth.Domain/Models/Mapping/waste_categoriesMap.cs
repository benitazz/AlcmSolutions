using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class waste_categoriesMap : EntityTypeConfiguration<waste_categories>
    {
        public waste_categoriesMap()
        {
            // Primary Key
            this.HasKey(t => t.waste_category);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(1000);

            this.Property(t => t.waste_category)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("waste_categories", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.waste_category).HasColumnName("waste_category");
        }
    }
}
