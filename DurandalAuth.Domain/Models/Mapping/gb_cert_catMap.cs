using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class gb_cert_catMap : EntityTypeConfiguration<gb_cert_cat>
    {
        public gb_cert_catMap()
        {
            // Primary Key
            this.HasKey(t => new { t.cert_std, t.cert_cat });

            // Properties
            this.Property(t => t.cat_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.cert_std)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.cert_cat)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("gb_cert_cat", "afm");
            this.Property(t => t.cat_name).HasColumnName("cat_name");
            this.Property(t => t.cat_order).HasColumnName("cat_order");
            this.Property(t => t.weight_factor).HasColumnName("weight_factor");
            this.Property(t => t.cert_std).HasColumnName("cert_std");
            this.Property(t => t.cert_cat).HasColumnName("cert_cat");

            // Relationships
            this.HasRequired(t => t.gb_cert_std)
                .WithMany(t => t.gb_cert_cat)
                .HasForeignKey(d => d.cert_std);

        }
    }
}
