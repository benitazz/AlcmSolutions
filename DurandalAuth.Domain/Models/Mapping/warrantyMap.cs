using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class warrantyMap : EntityTypeConfiguration<warranty>
    {
        public warrantyMap()
        {
            // Primary Key
            this.HasKey(t => t.warranty_id);

            // Properties
            this.Property(t => t.contact_info)
                .HasMaxLength(200);

            this.Property(t => t.description)
                .HasMaxLength(5000);

            this.Property(t => t.doc_warranty)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.image_warranty)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.meter_units)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.war_vendor)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.warranty_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("warranty", "afm");
            this.Property(t => t.contact_info).HasColumnName("contact_info");
            this.Property(t => t.date_expiration).HasColumnName("date_expiration");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.doc_warranty).HasColumnName("doc_warranty");
            this.Property(t => t.image_warranty).HasColumnName("image_warranty");
            this.Property(t => t.meter_units).HasColumnName("meter_units");
            this.Property(t => t.metered_exp).HasColumnName("metered_exp");
            this.Property(t => t.war_vendor).HasColumnName("war_vendor");
            this.Property(t => t.warranty_id).HasColumnName("warranty_id");
        }
    }
}
