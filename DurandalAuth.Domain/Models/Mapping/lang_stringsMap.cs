using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class lang_stringsMap : EntityTypeConfiguration<lang_strings>
    {
        public lang_stringsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.language, t.string_english, t.string_type });

            // Properties
            this.Property(t => t.reference_info)
                .IsFixedLength()
                .HasMaxLength(800);

            this.Property(t => t.string_trans)
                .HasMaxLength(1200);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.language)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.string_english)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(800);

            this.Property(t => t.string_type)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("lang_strings", "afm");
            this.Property(t => t.date_last_updated).HasColumnName("date_last_updated");
            this.Property(t => t.reference_info).HasColumnName("reference_info");
            this.Property(t => t.string_trans).HasColumnName("string_trans");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.language).HasColumnName("language");
            this.Property(t => t.string_english).HasColumnName("string_english");
            this.Property(t => t.string_type).HasColumnName("string_type");

            // Relationships
            this.HasRequired(t => t.lang_lang)
                .WithMany(t => t.lang_strings)
                .HasForeignKey(d => d.language);

        }
    }
}
