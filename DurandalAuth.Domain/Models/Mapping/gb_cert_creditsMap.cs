using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class gb_cert_creditsMap : EntityTypeConfiguration<gb_cert_credits>
    {
        public gb_cert_creditsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.cert_std, t.cert_cat, t.credit_num, t.subcredit_num, t.credit_type });

            // Properties
            this.Property(t => t.credit_name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.subcredit_name)
                .HasMaxLength(100);

            this.Property(t => t.cert_std)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.cert_cat)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.credit_num)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.subcredit_num)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.credit_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("gb_cert_credits", "afm");
            this.Property(t => t.credit_name).HasColumnName("credit_name");
            this.Property(t => t.max_points).HasColumnName("max_points");
            this.Property(t => t.min_points).HasColumnName("min_points");
            this.Property(t => t.subcredit_name).HasColumnName("subcredit_name");
            this.Property(t => t.cert_std).HasColumnName("cert_std");
            this.Property(t => t.cert_cat).HasColumnName("cert_cat");
            this.Property(t => t.credit_num).HasColumnName("credit_num");
            this.Property(t => t.subcredit_num).HasColumnName("subcredit_num");
            this.Property(t => t.credit_type).HasColumnName("credit_type");

            // Relationships
            this.HasRequired(t => t.gb_cert_cat)
                .WithMany(t => t.gb_cert_credits)
                .HasForeignKey(d => new { d.cert_std, d.cert_cat });
            this.HasRequired(t => t.gb_cert_std)
                .WithMany(t => t.gb_cert_credits)
                .HasForeignKey(d => d.cert_std);

        }
    }
}
