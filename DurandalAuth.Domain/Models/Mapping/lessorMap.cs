using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class lessorMap : EntityTypeConfiguration<lessor>
    {
        public lessorMap()
        {
            // Primary Key
            this.HasKey(t => t.lessor_id);

            // Properties
            this.Property(t => t.address1)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.address2)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.city)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.contact)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.country)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.description)
                .HasMaxLength(5000);

            this.Property(t => t.email)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.fax)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.name)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.phone)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.phone_ext)
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.postalcode)
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.region)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.lessor_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("lessor", "afm");
            this.Property(t => t.address1).HasColumnName("address1");
            this.Property(t => t.address2).HasColumnName("address2");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.contact).HasColumnName("contact");
            this.Property(t => t.country).HasColumnName("country");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.fax).HasColumnName("fax");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.phone_ext).HasColumnName("phone_ext");
            this.Property(t => t.postalcode).HasColumnName("postalcode");
            this.Property(t => t.region).HasColumnName("region");
            this.Property(t => t.lessor_id).HasColumnName("lessor_id");
        }
    }
}
