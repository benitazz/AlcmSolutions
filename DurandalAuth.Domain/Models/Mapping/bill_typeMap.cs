using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class bill_typeMap : EntityTypeConfiguration<bill_type>
    {
        public bill_typeMap()
        {
            // Primary Key
            this.HasKey(t => t.bill_type_id);

            // Properties
            this.Property(t => t.activity_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.cost_cat_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.description)
                .HasMaxLength(128);

            this.Property(t => t.bill_type_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("bill_type", "afm");
            this.Property(t => t.activity_id).HasColumnName("activity_id");
            this.Property(t => t.cost_cat_id).HasColumnName("cost_cat_id");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.bill_type_id).HasColumnName("bill_type_id");

            // Relationships
            this.HasOptional(t => t.cost_cat)
                .WithMany(t => t.bill_type)
                .HasForeignKey(d => d.cost_cat_id);

        }
    }
}
