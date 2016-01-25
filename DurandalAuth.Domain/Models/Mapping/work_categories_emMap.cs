using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class work_categories_emMap : EntityTypeConfiguration<work_categories_em>
    {
        public work_categories_emMap()
        {
            // Primary Key
            this.HasKey(t => new { t.em_id, t.work_category_id, t.date_start });

            // Properties
            this.Property(t => t.em_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.work_category_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("work_categories_em", "afm");
            this.Property(t => t.date_end).HasColumnName("date_end");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.work_category_id).HasColumnName("work_category_id");
            this.Property(t => t.date_start).HasColumnName("date_start");

            // Relationships
            this.HasRequired(t => t.em)
                .WithMany(t => t.work_categories_em)
                .HasForeignKey(d => d.em_id);
            this.HasRequired(t => t.work_categories)
                .WithMany(t => t.work_categories_em)
                .HasForeignKey(d => d.work_category_id);

        }
    }
}
