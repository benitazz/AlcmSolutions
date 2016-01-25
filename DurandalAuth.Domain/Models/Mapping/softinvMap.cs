using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class softinvMap : EntityTypeConfiguration<softinv>
    {
        public softinvMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.comments)
                .HasMaxLength(1000);

            this.Property(t => t.eq_id)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.licence_id)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.soft_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.soft_std)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.authorization_id)
                .IsFixedLength()
                .HasMaxLength(24);

            // Table & Column Mappings
            this.ToTable("softinv", "afm");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.date_installed).HasColumnName("date_installed");
            this.Property(t => t.date_purchased).HasColumnName("date_purchased");
            this.Property(t => t.eq_id).HasColumnName("eq_id");
            this.Property(t => t.licence_id).HasColumnName("licence_id");
            this.Property(t => t.num_licences).HasColumnName("num_licences");
            this.Property(t => t.soft_id).HasColumnName("soft_id");
            this.Property(t => t.soft_std).HasColumnName("soft_std");
            this.Property(t => t.authorization_id).HasColumnName("authorization_id");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasOptional(t => t.eq)
                .WithMany(t => t.softinvs)
                .HasForeignKey(d => d.eq_id);
            this.HasOptional(t => t.softstd)
                .WithMany(t => t.softinvs)
                .HasForeignKey(d => d.soft_std);

        }
    }
}
