using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class helpdesk_sla_responseMap : EntityTypeConfiguration<helpdesk_sla_response>
    {
        public helpdesk_sla_responseMap()
        {
            // Primary Key
            this.HasKey(t => new { t.activity_type, t.ordering_seq, t.priority });

            // Properties
            this.Property(t => t.cf_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dispatcher)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.interval_to_complete)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.interval_to_respond)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.manager)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.priority_label)
                .IsFixedLength()
                .HasMaxLength(100);

            this.Property(t => t.priority_label_01)
                .IsFixedLength()
                .HasMaxLength(150);

            this.Property(t => t.priority_label_02)
                .IsFixedLength()
                .HasMaxLength(150);

            this.Property(t => t.priority_label_03)
                .IsFixedLength()
                .HasMaxLength(150);

            this.Property(t => t.priority_label_ch)
                .IsFixedLength()
                .HasMaxLength(150);

            this.Property(t => t.priority_label_de)
                .IsFixedLength()
                .HasMaxLength(150);

            this.Property(t => t.priority_label_es)
                .IsFixedLength()
                .HasMaxLength(150);

            this.Property(t => t.priority_label_fr)
                .IsFixedLength()
                .HasMaxLength(150);

            this.Property(t => t.priority_label_it)
                .IsFixedLength()
                .HasMaxLength(150);

            this.Property(t => t.priority_label_jp)
                .IsFixedLength()
                .HasMaxLength(150);

            this.Property(t => t.priority_label_ko)
                .IsFixedLength()
                .HasMaxLength(150);

            this.Property(t => t.priority_label_nl)
                .IsFixedLength()
                .HasMaxLength(150);

            this.Property(t => t.priority_label_no)
                .IsFixedLength()
                .HasMaxLength(150);

            this.Property(t => t.priority_label_zh)
                .IsFixedLength()
                .HasMaxLength(150);

            this.Property(t => t.serv_window_days)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.servcont_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.service_name)
                .HasMaxLength(128);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.supervisor)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.vn_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.work_team_id)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.workflow_name)
                .HasMaxLength(128);

            this.Property(t => t.activity_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.activity_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.ordering_seq)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.priority)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("helpdesk_sla_response", "afm");
            this.Property(t => t.allow_work_on_holidays).HasColumnName("allow_work_on_holidays");
            this.Property(t => t.autoaccept).HasColumnName("autoaccept");
            this.Property(t => t.autoapprove).HasColumnName("autoapprove");
            this.Property(t => t.autocreate_wo).HasColumnName("autocreate_wo");
            this.Property(t => t.autocreate_wr).HasColumnName("autocreate_wr");
            this.Property(t => t.autodispatch).HasColumnName("autodispatch");
            this.Property(t => t.autoissue).HasColumnName("autoissue");
            this.Property(t => t.autoschedule).HasColumnName("autoschedule");
            this.Property(t => t.cf_id).HasColumnName("cf_id");
            this.Property(t => t.default_duration).HasColumnName("default_duration");
            this.Property(t => t.dispatcher).HasColumnName("dispatcher");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.interval_to_complete).HasColumnName("interval_to_complete");
            this.Property(t => t.interval_to_respond).HasColumnName("interval_to_respond");
            this.Property(t => t.manager).HasColumnName("manager");
            this.Property(t => t.notify_craftsperson).HasColumnName("notify_craftsperson");
            this.Property(t => t.notify_requestor).HasColumnName("notify_requestor");
            this.Property(t => t.notify_service_provider).HasColumnName("notify_service_provider");
            this.Property(t => t.priority_label).HasColumnName("priority_label");
            this.Property(t => t.priority_label_01).HasColumnName("priority_label_01");
            this.Property(t => t.priority_label_02).HasColumnName("priority_label_02");
            this.Property(t => t.priority_label_03).HasColumnName("priority_label_03");
            this.Property(t => t.priority_label_ch).HasColumnName("priority_label_ch");
            this.Property(t => t.priority_label_de).HasColumnName("priority_label_de");
            this.Property(t => t.priority_label_es).HasColumnName("priority_label_es");
            this.Property(t => t.priority_label_fr).HasColumnName("priority_label_fr");
            this.Property(t => t.priority_label_it).HasColumnName("priority_label_it");
            this.Property(t => t.priority_label_jp).HasColumnName("priority_label_jp");
            this.Property(t => t.priority_label_ko).HasColumnName("priority_label_ko");
            this.Property(t => t.priority_label_nl).HasColumnName("priority_label_nl");
            this.Property(t => t.priority_label_no).HasColumnName("priority_label_no");
            this.Property(t => t.priority_label_zh).HasColumnName("priority_label_zh");
            this.Property(t => t.serv_window_days).HasColumnName("serv_window_days");
            this.Property(t => t.serv_window_end).HasColumnName("serv_window_end");
            this.Property(t => t.serv_window_start).HasColumnName("serv_window_start");
            this.Property(t => t.servcont_id).HasColumnName("servcont_id");
            this.Property(t => t.service_name).HasColumnName("service_name");
            this.Property(t => t.service_template).HasColumnName("service_template");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.supervisor).HasColumnName("supervisor");
            this.Property(t => t.time_to_complete).HasColumnName("time_to_complete");
            this.Property(t => t.time_to_respond).HasColumnName("time_to_respond");
            this.Property(t => t.vn_id).HasColumnName("vn_id");
            this.Property(t => t.work_team_id).HasColumnName("work_team_id");
            this.Property(t => t.workflow_name).HasColumnName("workflow_name");
            this.Property(t => t.workflow_template).HasColumnName("workflow_template");
            this.Property(t => t.activity_id).HasColumnName("activity_id");
            this.Property(t => t.activity_type).HasColumnName("activity_type");
            this.Property(t => t.ordering_seq).HasColumnName("ordering_seq");
            this.Property(t => t.priority).HasColumnName("priority");

            // Relationships
            this.HasRequired(t => t.activitytype)
                .WithMany(t => t.helpdesk_sla_response)
                .HasForeignKey(d => d.activity_type);
            this.HasOptional(t => t.cf)
                .WithMany(t => t.HelpdeskSlaResponse)
                .HasForeignKey(d => d.cf_id);
            this.HasOptional(t => t.em)
                .WithMany(t => t.HelpdeskSlaResponse)
                .HasForeignKey(d => d.dispatcher);
            this.HasOptional(t => t.em1)
                .WithMany(t => t.HelpdeskSlaResponse1)
                .HasForeignKey(d => d.em_id);
            this.HasOptional(t => t.em2)
                .WithMany(t => t.HelpdeskSlaResponse2)
                .HasForeignKey(d => d.manager);
            this.HasOptional(t => t.em3)
                .WithMany(t => t.HelpdeskSlaResponse3)
                .HasForeignKey(d => d.supervisor);
            this.HasRequired(t => t.helpdesk_sla_request)
                .WithMany(t => t.helpdesk_sla_response)
                .HasForeignKey(d => new { d.activity_type, d.ordering_seq });
            this.HasOptional(t => t.servcont)
                .WithMany(t => t.helpdesk_sla_response)
                .HasForeignKey(d => d.servcont_id);
            this.HasOptional(t => t.vn)
                .WithMany(t => t.helpdesk_sla_response)
                .HasForeignKey(d => d.vn_id);
            this.HasOptional(t => t.work_team)
                .WithMany(t => t.helpdesk_sla_response)
                .HasForeignKey(d => d.work_team_id);

        }
    }
}
