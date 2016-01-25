using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class lang_enumMap : EntityTypeConfiguration<lang_enum>
    {
        public lang_enumMap()
        {
            // Primary Key
            this.HasKey(t => new { t.language, t.enum_english });

            // Properties
            this.Property(t => t.enum_trans)
                .HasMaxLength(1000);

            this.Property(t => t.reference_info)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.language)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.enum_english)
                .IsRequired()
                .HasMaxLength(850);

            // Table & Column Mappings
            this.ToTable("lang_enum", "afm");
            this.Property(t => t.date_last_updated).HasColumnName("date_last_updated");
            this.Property(t => t.enum_trans).HasColumnName("enum_trans");
            this.Property(t => t.reference_info).HasColumnName("reference_info");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.language).HasColumnName("language");
            this.Property(t => t.enum_english).HasColumnName("enum_english");

            // Relationships
            this.HasRequired(t => t.lang_lang)
                .WithMany(t => t.lang_enum)
                .HasForeignKey(d => d.language);

        }
    }
}
