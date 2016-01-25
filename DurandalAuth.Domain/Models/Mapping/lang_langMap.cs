using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class lang_langMap : EntityTypeConfiguration<lang_lang>
    {
        public lang_langMap()
        {
            // Primary Key
            this.HasKey(t => t.language);

            // Properties
            this.Property(t => t.lang_to_fld_mapping)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.locale)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.language)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("lang_lang", "afm");
            this.Property(t => t.is_default_language).HasColumnName("is_default_language");
            this.Property(t => t.lang_to_fld_mapping).HasColumnName("lang_to_fld_mapping");
            this.Property(t => t.locale).HasColumnName("locale");
            this.Property(t => t.language).HasColumnName("language");
        }
    }
}
