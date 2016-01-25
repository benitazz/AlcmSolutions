using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class gb_cert_logMap : EntityTypeConfiguration<gb_cert_log>
    {
        public gb_cert_logMap()
        {
            // Primary Key
            this.HasKey(t => t.cert_log_id);

            // Properties
            this.Property(t => t.cert_std)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.project_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.subject)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.submitted_by)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("gb_cert_log", "afm");
            this.Property(t => t.cert_std).HasColumnName("cert_std");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.log_date).HasColumnName("log_date");
            this.Property(t => t.project_name).HasColumnName("project_name");
            this.Property(t => t.subject).HasColumnName("subject");
            this.Property(t => t.submitted_by).HasColumnName("submitted_by");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.cert_log_id).HasColumnName("cert_log_id");

            // Relationships
            this.HasRequired(t => t.bl)
                .WithMany(t => t.gb_cert_log)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.em)
                .WithMany(t => t.GbCertLog)
                .HasForeignKey(d => d.submitted_by);
            this.HasRequired(t => t.gb_cert_std)
                .WithMany(t => t.gb_cert_log)
                .HasForeignKey(d => d.cert_std);
            this.HasRequired(t => t.gb_cert_proj)
                .WithMany(t => t.gb_cert_log)
                .HasForeignKey(d => new { d.bl_id, d.cert_std, d.project_name });

        }
    }
}
