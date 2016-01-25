using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class lang_filesMap : EntityTypeConfiguration<lang_files>
    {
        public lang_filesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.string_english, t.transfer_status, t.language, t.filename, t.constant });

            // Properties
            this.Property(t => t.reference_info)
                .IsFixedLength()
                .HasMaxLength(120);

            this.Property(t => t.string_english)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.string_trans)
                .HasMaxLength(3000);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.language)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.filename)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(255);

            this.Property(t => t.constant)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2100);

            // Table & Column Mappings
            this.ToTable("lang_files", "afm");
            this.Property(t => t.date_last_updated).HasColumnName("date_last_updated");
            this.Property(t => t.reference_info).HasColumnName("reference_info");
            this.Property(t => t.string_english).HasColumnName("string_english");
            this.Property(t => t.string_trans).HasColumnName("string_trans");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.language).HasColumnName("language");
            this.Property(t => t.filename).HasColumnName("filename");
            this.Property(t => t.constant).HasColumnName("constant");

            // Relationships
            this.HasRequired(t => t.lang_lang)
                .WithMany(t => t.lang_files)
                .HasForeignKey(d => d.language);

        }
    }
}
