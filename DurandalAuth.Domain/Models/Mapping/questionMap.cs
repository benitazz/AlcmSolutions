using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class questionMap : EntityTypeConfiguration<question>
    {
        public questionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.questionnaire_id, t.quest_name });

            // Properties
            this.Property(t => t.action_response)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.activity_type)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.enum_list)
                .HasMaxLength(256);

            this.Property(t => t.enum_list_01)
                .HasMaxLength(384);

            this.Property(t => t.enum_list_02)
                .HasMaxLength(384);

            this.Property(t => t.enum_list_03)
                .HasMaxLength(384);

            this.Property(t => t.enum_list_ch)
                .HasMaxLength(384);

            this.Property(t => t.enum_list_de)
                .HasMaxLength(384);

            this.Property(t => t.enum_list_es)
                .HasMaxLength(384);

            this.Property(t => t.enum_list_fr)
                .HasMaxLength(384);

            this.Property(t => t.enum_list_it)
                .HasMaxLength(384);

            this.Property(t => t.enum_list_jp)
                .HasMaxLength(384);

            this.Property(t => t.enum_list_ko)
                .HasMaxLength(384);

            this.Property(t => t.enum_list_nl)
                .HasMaxLength(384);

            this.Property(t => t.enum_list_no)
                .HasMaxLength(384);

            this.Property(t => t.enum_list_zh)
                .HasMaxLength(384);

            this.Property(t => t.format_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.lookup_field)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.lookup_table)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.quest_text)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.quest_text_01)
                .HasMaxLength(196);

            this.Property(t => t.quest_text_02)
                .HasMaxLength(196);

            this.Property(t => t.quest_text_03)
                .HasMaxLength(196);

            this.Property(t => t.quest_text_ch)
                .HasMaxLength(196);

            this.Property(t => t.quest_text_de)
                .HasMaxLength(196);

            this.Property(t => t.quest_text_es)
                .HasMaxLength(196);

            this.Property(t => t.quest_text_fr)
                .HasMaxLength(196);

            this.Property(t => t.quest_text_it)
                .HasMaxLength(196);

            this.Property(t => t.quest_text_jp)
                .HasMaxLength(196);

            this.Property(t => t.quest_text_ko)
                .HasMaxLength(196);

            this.Property(t => t.quest_text_nl)
                .HasMaxLength(196);

            this.Property(t => t.quest_text_no)
                .HasMaxLength(196);

            this.Property(t => t.quest_text_zh)
                .HasMaxLength(196);

            this.Property(t => t.questionnaire_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.quest_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("questions", "afm");
            this.Property(t => t.action_response).HasColumnName("action_response");
            this.Property(t => t.activity_type).HasColumnName("activity_type");
            this.Property(t => t.enum_list).HasColumnName("enum_list");
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
            this.Property(t => t.format_type).HasColumnName("format_type");
            this.Property(t => t.freeform_width).HasColumnName("freeform_width");
            this.Property(t => t.is_active).HasColumnName("is_active");
            this.Property(t => t.is_required).HasColumnName("is_required");
            this.Property(t => t.lookup_field).HasColumnName("lookup_field");
            this.Property(t => t.lookup_table).HasColumnName("lookup_table");
            this.Property(t => t.quest_text).HasColumnName("quest_text");
            this.Property(t => t.quest_text_01).HasColumnName("quest_text_01");
            this.Property(t => t.quest_text_02).HasColumnName("quest_text_02");
            this.Property(t => t.quest_text_03).HasColumnName("quest_text_03");
            this.Property(t => t.quest_text_ch).HasColumnName("quest_text_ch");
            this.Property(t => t.quest_text_de).HasColumnName("quest_text_de");
            this.Property(t => t.quest_text_es).HasColumnName("quest_text_es");
            this.Property(t => t.quest_text_fr).HasColumnName("quest_text_fr");
            this.Property(t => t.quest_text_it).HasColumnName("quest_text_it");
            this.Property(t => t.quest_text_jp).HasColumnName("quest_text_jp");
            this.Property(t => t.quest_text_ko).HasColumnName("quest_text_ko");
            this.Property(t => t.quest_text_nl).HasColumnName("quest_text_nl");
            this.Property(t => t.quest_text_no).HasColumnName("quest_text_no");
            this.Property(t => t.quest_text_zh).HasColumnName("quest_text_zh");
            this.Property(t => t.sort_order).HasColumnName("sort_order");
            this.Property(t => t.questionnaire_id).HasColumnName("questionnaire_id");
            this.Property(t => t.quest_name).HasColumnName("quest_name");

            // Relationships
            this.HasOptional(t => t.activitytype)
                .WithMany(t => t.questions)
                .HasForeignKey(d => d.activity_type);
            this.HasOptional(t => t.afm_flds)
                .WithMany(t => t.questions)
                .HasForeignKey(d => new { d.lookup_table, d.lookup_field });
            this.HasOptional(t => t.afm_tbls)
                .WithMany(t => t.questions)
                .HasForeignKey(d => d.lookup_table);
            this.HasRequired(t => t.questionnaire)
                .WithMany(t => t.questions)
                .HasForeignKey(d => d.questionnaire_id);

        }
    }
}
