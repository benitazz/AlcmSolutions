using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class lang_glossaryMap : EntityTypeConfiguration<lang_glossary>
    {
        public lang_glossaryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.language, t.string_english });

            // Properties
            this.Property(t => t.string_trans)
                .HasMaxLength(2000);

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
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("lang_glossary", "afm");
            this.Property(t => t.string_trans).HasColumnName("string_trans");
            this.Property(t => t.string_type).HasColumnName("string_type");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.language).HasColumnName("language");
            this.Property(t => t.string_english).HasColumnName("string_english");

            // Relationships
            this.HasRequired(t => t.lang_lang)
                .WithMany(t => t.lang_glossary)
                .HasForeignKey(d => d.language);

        }
    }
}
