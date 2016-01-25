using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class cost_catMap : EntityTypeConfiguration<cost_cat>
    {
        public cost_catMap()
        {
            // Primary Key
            this.HasKey(t => t.cost_cat_id);

            // Properties
            this.Property(t => t.cost_class_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.cost_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.rollup_prorate)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.cost_cat_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("cost_cat", "afm");
            this.Property(t => t.cost_class_id).HasColumnName("cost_class_id");
            this.Property(t => t.cost_type).HasColumnName("cost_type");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.rollup_prorate).HasColumnName("rollup_prorate");
            this.Property(t => t.cost_cat_id).HasColumnName("cost_cat_id");

            // Relationships
            this.HasOptional(t => t.cost_class)
                .WithMany(t => t.cost_cat)
                .HasForeignKey(d => d.cost_class_id);

        }
    }
}
