using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_flds_langMap : EntityTypeConfiguration<afm_flds_lang>
    {
        public afm_flds_langMap()
        {
            // Primary Key
            this.HasKey(t => new { t.table_name, t.field_name });

            // Properties
            this.Property(t => t.enum_list_01)
                .HasMaxLength(1000);

            this.Property(t => t.enum_list_02)
                .HasMaxLength(1000);

            this.Property(t => t.enum_list_03)
                .HasMaxLength(1000);

            this.Property(t => t.enum_list_ch)
                .HasMaxLength(1000);

            this.Property(t => t.enum_list_de)
                .HasMaxLength(1000);

            this.Property(t => t.enum_list_es)
                .HasMaxLength(1000);

            this.Property(t => t.enum_list_fr)
                .HasMaxLength(1000);

            this.Property(t => t.enum_list_it)
                .HasMaxLength(1000);

            this.Property(t => t.enum_list_jp)
                .HasMaxLength(1000);

            this.Property(t => t.enum_list_ko)
                .HasMaxLength(1000);

            this.Property(t => t.enum_list_nl)
                .HasMaxLength(1000);

            this.Property(t => t.enum_list_no)
                .HasMaxLength(1000);

            this.Property(t => t.enum_list_zh)
                .HasMaxLength(1000);

            this.Property(t => t.ml_heading_01)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.ml_heading_02)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.ml_heading_03)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.ml_heading_ch)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.ml_heading_de)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.ml_heading_es)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.ml_heading_fr)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.ml_heading_it)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.ml_heading_jp)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.ml_heading_ko)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.ml_heading_nl)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.ml_heading_no)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.ml_heading_zh)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.table_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.field_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.sl_heading_01)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.sl_heading_02)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.sl_heading_03)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.sl_heading_ch)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.sl_heading_de)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.sl_heading_es)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.sl_heading_fr)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.sl_heading_it)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.sl_heading_jp)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.sl_heading_ko)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.sl_heading_nl)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.sl_heading_no)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.sl_heading_zh)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("afm_flds_lang", "afm");
            this.Property(t => t.enum_list_01).HasColumnName("enum_list_01");
            this.Property(t => t.enum_list_02).HasColumnName("enum_list_02");
            this.Property(t => t.enum_list_03).HasColumnName("enum_list_03");
            this.Property(t => t.enum_list_ch).HasColumnName("enum_list_ch");
            this.Property(t => t.enum_list_de).HasColumnName("enum_list_de");
            this.Property(t => t.enum_list_es).HasColumnName("enum_list_es");
            this.Property(t => t.enum_list_fr).HasColumnName("enum_list_fr");
            this.Property(t => t.enum_list_it).HasColumnName("enum_list_it");
            this.Property(t => t.enum_list_jp).HasColumnName("enum_list_jp");
            this.Property(t => t.enum_list_ko).HasColumnName("enum_list_ko");
            this.Property(t => t.enum_list_nl).HasColumnName("enum_list_nl");
            this.Property(t => t.enum_list_no).HasColumnName("enum_list_no");
            this.Property(t => t.enum_list_zh).HasColumnName("enum_list_zh");
            this.Property(t => t.ml_heading_01).HasColumnName("ml_heading_01");
            this.Property(t => t.ml_heading_02).HasColumnName("ml_heading_02");
            this.Property(t => t.ml_heading_03).HasColumnName("ml_heading_03");
            this.Property(t => t.ml_heading_ch).HasColumnName("ml_heading_ch");
            this.Property(t => t.ml_heading_de).HasColumnName("ml_heading_de");
            this.Property(t => t.ml_heading_es).HasColumnName("ml_heading_es");
            this.Property(t => t.ml_heading_fr).HasColumnName("ml_heading_fr");
            this.Property(t => t.ml_heading_it).HasColumnName("ml_heading_it");
            this.Property(t => t.ml_heading_jp).HasColumnName("ml_heading_jp");
            this.Property(t => t.ml_heading_ko).HasColumnName("ml_heading_ko");
            this.Property(t => t.ml_heading_nl).HasColumnName("ml_heading_nl");
            this.Property(t => t.ml_heading_no).HasColumnName("ml_heading_no");
            this.Property(t => t.ml_heading_zh).HasColumnName("ml_heading_zh");
            this.Property(t => t.table_name).HasColumnName("table_name");
            this.Property(t => t.field_name).HasColumnName("field_name");
            this.Property(t => t.sl_heading_01).HasColumnName("sl_heading_01");
            this.Property(t => t.sl_heading_02).HasColumnName("sl_heading_02");
            this.Property(t => t.sl_heading_03).HasColumnName("sl_heading_03");
            this.Property(t => t.sl_heading_ch).HasColumnName("sl_heading_ch");
            this.Property(t => t.sl_heading_de).HasColumnName("sl_heading_de");
            this.Property(t => t.sl_heading_es).HasColumnName("sl_heading_es");
            this.Property(t => t.sl_heading_fr).HasColumnName("sl_heading_fr");
            this.Property(t => t.sl_heading_it).HasColumnName("sl_heading_it");
            this.Property(t => t.sl_heading_jp).HasColumnName("sl_heading_jp");
            this.Property(t => t.sl_heading_ko).HasColumnName("sl_heading_ko");
            this.Property(t => t.sl_heading_nl).HasColumnName("sl_heading_nl");
            this.Property(t => t.sl_heading_no).HasColumnName("sl_heading_no");
            this.Property(t => t.sl_heading_zh).HasColumnName("sl_heading_zh");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");

            // Relationships
            this.HasRequired(t => t.afm_flds)
                .WithOptional(t => t.afm_flds_lang);
            this.HasRequired(t => t.afm_tbls)
                .WithMany(t => t.afm_flds_lang)
                .HasForeignKey(d => d.table_name);

        }
    }
}
