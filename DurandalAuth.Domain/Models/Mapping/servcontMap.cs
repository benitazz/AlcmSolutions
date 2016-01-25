using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class servcontMap : EntityTypeConfiguration<servcont>
    {
        public servcontMap()
        {
            // Primary Key
            this.HasKey(t => t.servcont_id);

            // Properties
            this.Property(t => t.contact_info)
                .HasMaxLength(200);

            this.Property(t => t.description)
                .HasMaxLength(5000);

            this.Property(t => t.doc)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.image_serv_contract)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.servcont_vendor)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.servcont_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("servcont", "afm");
            this.Property(t => t.contact_info).HasColumnName("contact_info");
            this.Property(t => t.date_expiration).HasColumnName("date_expiration");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.doc).HasColumnName("doc");
            this.Property(t => t.image_serv_contract).HasColumnName("image_serv_contract");
            this.Property(t => t.servcont_vendor).HasColumnName("servcont_vendor");
            this.Property(t => t.servcont_id).HasColumnName("servcont_id");
        }
    }
}
