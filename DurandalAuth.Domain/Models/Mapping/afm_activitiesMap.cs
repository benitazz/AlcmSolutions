using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_activitiesMap : EntityTypeConfiguration<afm_activities>
    {
        public afm_activitiesMap()
        {
            // Primary Key
            this.HasKey(t => t.activity_id);

            // Properties
            this.Property(t => t.adn_link)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.adn_mfr)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.adn_phone)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.comments)
                .HasMaxLength(256);

            this.Property(t => t.help_link)
                .HasMaxLength(255);

            this.Property(t => t.help_system)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.icon_large)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.icon_small)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.subfolder)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.summary)
                .HasMaxLength(800);

            this.Property(t => t.summary_01)
                .HasMaxLength(1200);

            this.Property(t => t.summary_02)
                .HasMaxLength(1200);

            this.Property(t => t.summary_03)
                .HasMaxLength(1200);

            this.Property(t => t.summary_ch)
                .HasMaxLength(1200);

            this.Property(t => t.summary_de)
                .HasMaxLength(1200);

            this.Property(t => t.summary_es)
                .HasMaxLength(1200);

            this.Property(t => t.summary_fr)
                .HasMaxLength(1200);

            this.Property(t => t.summary_it)
                .HasMaxLength(1200);

            this.Property(t => t.summary_jp)
                .HasMaxLength(1200);

            this.Property(t => t.summary_ko)
                .HasMaxLength(1200);

            this.Property(t => t.summary_nl)
                .HasMaxLength(1200);

            this.Property(t => t.summary_no)
                .HasMaxLength(1200);

            this.Property(t => t.summary_zh)
                .HasMaxLength(1200);

            this.Property(t => t.title)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.title_01)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.title_02)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.title_03)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.title_ch)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.title_de)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.title_es)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.title_fr)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.title_it)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.title_jp)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.title_ko)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.title_nl)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.title_no)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.title_zh)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.workflow_assignee_field)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.workflow_status_field)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.workflow_statusmanager)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.workflow_step_status_field)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.workflow_stepmanager)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.workflow_table)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.activity_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("afm_activities", "afm");
            this.Property(t => t.adn_link).HasColumnName("adn_link");
            this.Property(t => t.adn_mfr).HasColumnName("adn_mfr");
            this.Property(t => t.adn_phone).HasColumnName("adn_phone");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.display_order).HasColumnName("display_order");
            this.Property(t => t.help_link).HasColumnName("help_link");
            this.Property(t => t.help_system).HasColumnName("help_system");
            this.Property(t => t.icon_large).HasColumnName("icon_large");
            this.Property(t => t.icon_small).HasColumnName("icon_small");
            this.Property(t => t.internal_use1).HasColumnName("internal_use1");
            this.Property(t => t.is_active).HasColumnName("is_active");
            this.Property(t => t.revision).HasColumnName("revision");
            this.Property(t => t.subfolder).HasColumnName("subfolder");
            this.Property(t => t.summary).HasColumnName("summary");
            this.Property(t => t.summary_01).HasColumnName("summary_01");
            this.Property(t => t.summary_02).HasColumnName("summary_02");
            this.Property(t => t.summary_03).HasColumnName("summary_03");
            this.Property(t => t.summary_ch).HasColumnName("summary_ch");
            this.Property(t => t.summary_de).HasColumnName("summary_de");
            this.Property(t => t.summary_es).HasColumnName("summary_es");
            this.Property(t => t.summary_fr).HasColumnName("summary_fr");
            this.Property(t => t.summary_it).HasColumnName("summary_it");
            this.Property(t => t.summary_jp).HasColumnName("summary_jp");
            this.Property(t => t.summary_ko).HasColumnName("summary_ko");
            this.Property(t => t.summary_nl).HasColumnName("summary_nl");
            this.Property(t => t.summary_no).HasColumnName("summary_no");
            this.Property(t => t.summary_zh).HasColumnName("summary_zh");
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
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.version).HasColumnName("version");
            this.Property(t => t.workflow_assignee_field).HasColumnName("workflow_assignee_field");
            this.Property(t => t.workflow_status_field).HasColumnName("workflow_status_field");
            this.Property(t => t.workflow_statusmanager).HasColumnName("workflow_statusmanager");
            this.Property(t => t.workflow_step_status_field).HasColumnName("workflow_step_status_field");
            this.Property(t => t.workflow_stepmanager).HasColumnName("workflow_stepmanager");
            this.Property(t => t.workflow_table).HasColumnName("workflow_table");
            this.Property(t => t.activity_id).HasColumnName("activity_id");

            // Relationships
            this.HasOptional(t => t.afm_flds)
                .WithMany(t => t.afm_activities)
                .HasForeignKey(d => new { d.workflow_table, d.workflow_assignee_field });
            this.HasOptional(t => t.afm_flds1)
                .WithMany(t => t.afm_activities1)
                .HasForeignKey(d => new { d.workflow_table, d.workflow_status_field });
            this.HasOptional(t => t.afm_flds2)
                .WithMany(t => t.afm_activities2)
                .HasForeignKey(d => new { d.workflow_table, d.workflow_step_status_field });
            this.HasOptional(t => t.afm_tbls)
                .WithMany(t => t.afm_activities)
                .HasForeignKey(d => d.workflow_table);

        }
    }
}
