using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class bill_unitMap : EntityTypeConfiguration<bill_unit>
    {
        public bill_unitMap()
        {
            // Primary Key
            this.HasKey(t => new { t.bill_type_id, t.bill_unit_id });

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(128);

            this.Property(t => t.rollup_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.bill_type_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.bill_unit_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("bill_unit", "afm");
            this.Property(t => t.conversion_factor).HasColumnName("conversion_factor");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.is_dflt).HasColumnName("is_dflt");
            this.Property(t => t.rollup_type).HasColumnName("rollup_type");
            this.Property(t => t.bill_type_id).HasColumnName("bill_type_id");
            this.Property(t => t.bill_unit_id).HasColumnName("bill_unit_id");

            // Relationships
            this.HasRequired(t => t.bill_type)
                .WithMany(t => t.bill_unit)
                .HasForeignKey(d => d.bill_type_id);

        }
    }
}
