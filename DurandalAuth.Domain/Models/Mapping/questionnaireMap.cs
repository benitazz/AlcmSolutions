using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class questionnaireMap : EntityTypeConfiguration<questionnaire>
    {
        public questionnaireMap()
        {
            // Primary Key
            this.HasKey(t => t.questionnaire_id);

            // Properties
            this.Property(t => t.table_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.title)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.title_01)
                .IsFixedLength()
                .HasMaxLength(144);

            this.Property(t => t.title_02)
                .IsFixedLength()
                .HasMaxLength(144);

            this.Property(t => t.title_03)
                .IsFixedLength()
                .HasMaxLength(144);

            this.Property(t => t.title_ch)
                .IsFixedLength()
                .HasMaxLength(144);

            this.Property(t => t.title_de)
                .IsFixedLength()
                .HasMaxLength(144);

            this.Property(t => t.title_es)
                .IsFixedLength()
                .HasMaxLength(144);

            this.Property(t => t.title_fr)
                .IsFixedLength()
                .HasMaxLength(144);

            this.Property(t => t.title_it)
                .IsFixedLength()
                .HasMaxLength(144);

            this.Property(t => t.title_jp)
                .IsFixedLength()
                .HasMaxLength(144);

            this.Property(t => t.title_ko)
                .IsFixedLength()
                .HasMaxLength(144);

            this.Property(t => t.title_nl)
                .IsFixedLength()
                .HasMaxLength(144);

            this.Property(t => t.title_no)
                .IsFixedLength()
                .HasMaxLength(144);

            this.Property(t => t.title_zh)
                .IsFixedLength()
                .HasMaxLength(144);

            this.Property(t => t.description)
                .HasMaxLength(512);

            this.Property(t => t.field_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.questionnaire_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("questionnaire", "afm");
            this.Property(t => t.table_name).HasColumnName("table_name");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.title_01).HasColumnName("title_01");
            this.Property(t => t.title_02).HasColumnName("title_02");
            this.Property(t => t.title_03).HasColumnName("title_03");
            this.Property(t => t.title_ch).HasColumnName("title_ch");
            this.Property(t => t.title_de).HasColumnName("title_de");
            this.Property(t => t.title_es).HasColumnName("title_es");
            this.Property(t => t.title_fr).HasColumnName("title_fr");
            this.Property(t => t.title_it).HasColumnName("title_it");
            this.Property(t => t.title_jp).HasColumnName("title_jp");
            this.Property(t => t.title_ko).HasColumnName("title_ko");
            this.Property(t => t.title_nl).HasColumnName("title_nl");
            this.Property(t => t.title_no).HasColumnName("title_no");
            this.Property(t => t.title_zh).HasColumnName("title_zh");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.field_name).HasColumnName("field_name");
            this.Property(t => t.questionnaire_id).HasColumnName("questionnaire_id");

            // Relationships
            this.HasRequired(t => t.afm_flds)
                .WithMany(t => t.questionnaires)
                .HasForeignKey(d => new { d.table_name, d.field_name });
            this.HasRequired(t => t.afm_tbls)
                .WithMany(t => t.questionnaires)
                .HasForeignKey(d => d.table_name);

        }
    }
}
