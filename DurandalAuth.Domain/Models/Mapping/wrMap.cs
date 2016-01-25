using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class wrMap : EntityTypeConfiguration<wr>
    {
        public wrMap()
        {
            // Primary Key
            this.HasKey(t => t.wr_id);

            // Properties
            this.Property(t => t.ac_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.activity_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.cause_type)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.cf_notes)
                .HasMaxLength(2000);

            this.Property(t => t.completed_by)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.desc_other_costs)
                .HasMaxLength(2000);

            this.Property(t => t.description)
                .HasMaxLength(5000);

            this.Property(t => t.dispatcher)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.doc1)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.doc2)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.doc3)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.doc4)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.eq_id)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.location)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.manager)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.msg_delivery_status)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.phone)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.pmp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.prob_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.repair_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.requestor)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.satisfaction_notes)
                .HasMaxLength(500);

            this.Property(t => t.serv_window_days)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.step_status)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.supervisor)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.tr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.vn_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.work_team_id)
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("wr", "afm");
            this.Property(t => t.ac_id).HasColumnName("ac_id");
            this.Property(t => t.act_labor_hours).HasColumnName("act_labor_hours");
            this.Property(t => t.activity_log_id).HasColumnName("activity_log_id");
            this.Property(t => t.activity_type).HasColumnName("activity_type");
            this.Property(t => t.allow_work_on_holidays).HasColumnName("allow_work_on_holidays");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.cause_type).HasColumnName("cause_type");
            this.Property(t => t.cf_notes).HasColumnName("cf_notes");
            this.Property(t => t.completed_by).HasColumnName("completed_by");
            this.Property(t => t.cost_est_labor).HasColumnName("cost_est_labor");
            this.Property(t => t.cost_est_other).HasColumnName("cost_est_other");
            this.Property(t => t.cost_est_parts).HasColumnName("cost_est_parts");
            this.Property(t => t.cost_est_tools).HasColumnName("cost_est_tools");
            this.Property(t => t.cost_est_total).HasColumnName("cost_est_total");
            this.Property(t => t.cost_labor).HasColumnName("cost_labor");
            this.Property(t => t.cost_other).HasColumnName("cost_other");
            this.Property(t => t.cost_parts).HasColumnName("cost_parts");
            this.Property(t => t.cost_tools).HasColumnName("cost_tools");
            this.Property(t => t.cost_total).HasColumnName("cost_total");
            this.Property(t => t.curr_meter_val).HasColumnName("curr_meter_val");
            this.Property(t => t.date_assigned).HasColumnName("date_assigned");
            this.Property(t => t.date_closed).HasColumnName("date_closed");
            this.Property(t => t.date_completed).HasColumnName("date_completed");
            this.Property(t => t.date_escalation_completion).HasColumnName("date_escalation_completion");
            this.Property(t => t.date_escalation_response).HasColumnName("date_escalation_response");
            this.Property(t => t.date_est_completion).HasColumnName("date_est_completion");
            this.Property(t => t.date_requested).HasColumnName("date_requested");
            this.Property(t => t.date_stat_chg).HasColumnName("date_stat_chg");
            this.Property(t => t.desc_other_costs).HasColumnName("desc_other_costs");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.dispatcher).HasColumnName("dispatcher");
            this.Property(t => t.doc1).HasColumnName("doc1");
            this.Property(t => t.doc2).HasColumnName("doc2");
            this.Property(t => t.doc3).HasColumnName("doc3");
            this.Property(t => t.doc4).HasColumnName("doc4");
            this.Property(t => t.down_time).HasColumnName("down_time");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.eq_id).HasColumnName("eq_id");
            this.Property(t => t.escalated_completion).HasColumnName("escalated_completion");
            this.Property(t => t.escalated_response).HasColumnName("escalated_response");
            this.Property(t => t.est_labor_hours).HasColumnName("est_labor_hours");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.geo_objectid).HasColumnName("geo_objectid");
            this.Property(t => t.lat).HasColumnName("lat");
            this.Property(t => t.location).HasColumnName("location");
            this.Property(t => t.lon).HasColumnName("lon");
            this.Property(t => t.manager).HasColumnName("manager");
            this.Property(t => t.msg_delivery_status).HasColumnName("msg_delivery_status");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.pmp_id).HasColumnName("pmp_id");
            this.Property(t => t.pms_id).HasColumnName("pms_id");
            this.Property(t => t.priority).HasColumnName("priority");
            this.Property(t => t.prob_type).HasColumnName("prob_type");
            this.Property(t => t.repair_type).HasColumnName("repair_type");
            this.Property(t => t.requestor).HasColumnName("requestor");
            this.Property(t => t.res_id).HasColumnName("res_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.rmres_id).HasColumnName("rmres_id");
            this.Property(t => t.rsres_id).HasColumnName("rsres_id");
            this.Property(t => t.satisfaction).HasColumnName("satisfaction");
            this.Property(t => t.satisfaction_notes).HasColumnName("satisfaction_notes");
            this.Property(t => t.serv_window_days).HasColumnName("serv_window_days");
            this.Property(t => t.serv_window_end).HasColumnName("serv_window_end");
            this.Property(t => t.serv_window_start).HasColumnName("serv_window_start");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.step_status).HasColumnName("step_status");
            this.Property(t => t.supervisor).HasColumnName("supervisor");
            this.Property(t => t.time_assigned).HasColumnName("time_assigned");
            this.Property(t => t.time_completed).HasColumnName("time_completed");
            this.Property(t => t.time_escalation_completion).HasColumnName("time_escalation_completion");
            this.Property(t => t.time_escalation_response).HasColumnName("time_escalation_response");
            this.Property(t => t.time_requested).HasColumnName("time_requested");
            this.Property(t => t.time_stat_chg).HasColumnName("time_stat_chg");
            this.Property(t => t.tr_id).HasColumnName("tr_id");
            this.Property(t => t.vn_id).HasColumnName("vn_id");
            this.Property(t => t.wo_id).HasColumnName("wo_id");
            this.Property(t => t.work_team_id).HasColumnName("work_team_id");
            this.Property(t => t.wr_id).HasColumnName("wr_id");

            // Relationships
            this.HasOptional(t => t.ac)
                .WithMany(t => t.wrs)
                .HasForeignKey(d => d.ac_id);
            this.HasOptional(t => t.activity_log)
                .WithMany(t => t.wrs)
                .HasForeignKey(d => d.activity_log_id);
            this.HasRequired(t => t.activitytype)
                .WithMany(t => t.wrs)
                .HasForeignKey(d => d.activity_type);
            this.HasOptional(t => t.bl)
                .WithMany(t => t.wrs)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.causetyp)
                .WithMany(t => t.wrs)
                .HasForeignKey(d => d.cause_type);
            this.HasOptional(t => t.dp)
                .WithMany(t => t.wrs)
                .HasForeignKey(d => new { d.dv_id, d.dp_id });
            this.HasOptional(t => t.dv)
                .WithMany(t => t.wrs)
                .HasForeignKey(d => d.dv_id);
            this.HasOptional(t => t.em)
                .WithMany(t => t.wrs)
                .HasForeignKey(d => d.completed_by);
            this.HasOptional(t => t.em1)
                .WithMany(t => t.wrs1)
                .HasForeignKey(d => d.dispatcher);
            this.HasOptional(t => t.em2)
                .WithMany(t => t.wrs2)
                .HasForeignKey(d => d.manager);
            this.HasOptional(t => t.em3)
                .WithMany(t => t.wrs3)
                .HasForeignKey(d => d.requestor);
            this.HasOptional(t => t.em4)
                .WithMany(t => t.wrs4)
                .HasForeignKey(d => d.supervisor);
            this.HasOptional(t => t.eq)
                .WithMany(t => t.wrs)
                .HasForeignKey(d => d.eq_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.Wrs)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.pmp)
                .WithMany(t => t.wrs)
                .HasForeignKey(d => d.pmp_id);
            this.HasOptional(t => t.pm)
                .WithMany(t => t.Wrs)
                .HasForeignKey(d => d.pms_id);
            this.HasOptional(t => t.probtype)
                .WithMany(t => t.wrs)
                .HasForeignKey(d => d.prob_type);
            this.HasOptional(t => t.repairty)
                .WithMany(t => t.wrs)
                .HasForeignKey(d => d.repair_type);
            this.HasOptional(t => t.rm)
                .WithMany(t => t.wrs)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });
            this.HasOptional(t => t.site)
                .WithMany(t => t.wrs)
                .HasForeignKey(d => d.site_id);
            this.HasOptional(t => t.tr)
                .WithMany(t => t.wrs)
                .HasForeignKey(d => d.tr_id);
            this.HasOptional(t => t.vn)
                .WithMany(t => t.wrs)
                .HasForeignKey(d => d.vn_id);
            this.HasOptional(t => t.wo)
                .WithMany(t => t.wrs)
                .HasForeignKey(d => d.wo_id);
            this.HasOptional(t => t.work_team)
                .WithMany(t => t.wrs)
                .HasForeignKey(d => d.work_team_id);

        }
    }
}
