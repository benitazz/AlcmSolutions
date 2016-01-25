using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class work_categoriesMap : EntityTypeConfiguration<work_categories>
    {
        public work_categoriesMap()
        {
            // Primary Key
            this.HasKey(t => t.work_category_id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(500);

            this.Property(t => t.hierarchy_ids)
                .HasMaxLength(500);

            this.Property(t => t.work_category_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("work_categories", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.hierarchy_ids).HasColumnName("hierarchy_ids");
            this.Property(t => t.work_category_id).HasColumnName("work_category_id");
        }
    }
}
