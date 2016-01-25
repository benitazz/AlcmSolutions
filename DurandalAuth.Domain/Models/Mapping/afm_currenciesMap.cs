using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_currenciesMap : EntityTypeConfiguration<afm_currencies>
    {
        public afm_currenciesMap()
        {
            // Primary Key
            this.HasKey(t => t.currency_id);

            // Properties
            this.Property(t => t.currency_symbol)
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.description_01)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.description_02)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.description_03)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.description_ch)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.description_de)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.description_es)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.description_fr)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.description_it)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.description_jp)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.description_ko)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.description_nl)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.description_no)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.description_zh)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.comments)
                .HasMaxLength(512);

            this.Property(t => t.currency_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("afm_currencies", "afm");
            this.Property(t => t.currency_symbol).HasColumnName("currency_symbol");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.description_01).HasColumnName("description_01");
            this.Property(t => t.description_02).HasColumnName("description_02");
            this.Property(t => t.description_03).HasColumnName("description_03");
            this.Property(t => t.description_ch).HasColumnName("description_ch");
            this.Property(t => t.description_de).HasColumnName("description_de");
            this.Property(t => t.description_es).HasColumnName("description_es");
            this.Property(t => t.description_fr).HasColumnName("description_fr");
            this.Property(t => t.description_it).HasColumnName("description_it");
            this.Property(t => t.description_jp).HasColumnName("description_jp");
            this.Property(t => t.description_ko).HasColumnName("description_ko");
            this.Property(t => t.description_nl).HasColumnName("description_nl");
            this.Property(t => t.description_no).HasColumnName("description_no");
            this.Property(t => t.description_zh).HasColumnName("description_zh");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.currency_id).HasColumnName("currency_id");
        }
    }
}
