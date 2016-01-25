using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class wr_syncMap : EntityTypeConfiguration<wr_sync>
    {
        public wr_syncMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
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
                .HasMaxLength(4000);

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

            this.Property(t => t.fwd_supervisor)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.fwd_work_team_id)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.location)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.manager)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.mob_locked_by)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.mob_pending_action)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.mob_step_action)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.mob_step_comments)
                .HasMaxLength(2000);

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

            this.Property(t => t.site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.step)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.step_em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.step_role_name)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.step_status)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.step_type)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.step_user_name)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.supervisor)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.tr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.work_team_id)
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("wr_sync", "afm");
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
            this.Property(t => t.date_assigned).HasColumnName("date_assigned");
            this.Property(t => t.date_closed).HasColumnName("date_closed");
            this.Property(t => t.date_completed).HasColumnName("date_completed");
            this.Property(t => t.date_escalation_completion).HasColumnName("date_escalation_completion");
            this.Property(t => t.date_escalation_response).HasColumnName("date_escalation_response");
            this.Property(t => t.date_est_completion).HasColumnName("date_est_completion");
            this.Property(t => t.date_requested).HasColumnName("date_requested");
            this.Property(t => t.desc_other_costs).HasColumnName("desc_other_costs");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.doc1).HasColumnName("doc1");
            this.Property(t => t.doc2).HasColumnName("doc2");
            this.Property(t => t.doc3).HasColumnName("doc3");
            this.Property(t => t.doc4).HasColumnName("doc4");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.eq_id).HasColumnName("eq_id");
            this.Property(t => t.escalated_completion).HasColumnName("escalated_completion");
            this.Property(t => t.escalated_response).HasColumnName("escalated_response");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.fwd_supervisor).HasColumnName("fwd_supervisor");
            this.Property(t => t.fwd_work_team_id).HasColumnName("fwd_work_team_id");
            this.Property(t => t.is_req_craftsperson).HasColumnName("is_req_craftsperson");
            this.Property(t => t.is_req_supervisor).HasColumnName("is_req_supervisor");
            this.Property(t => t.is_wt_self_assign).HasColumnName("is_wt_self_assign");
            this.Property(t => t.location).HasColumnName("location");
            this.Property(t => t.manager).HasColumnName("manager");
            this.Property(t => t.mob_is_changed).HasColumnName("mob_is_changed");
            this.Property(t => t.mob_locked_by).HasColumnName("mob_locked_by");
            this.Property(t => t.mob_pending_action).HasColumnName("mob_pending_action");
            this.Property(t => t.mob_stat_step_chg).HasColumnName("mob_stat_step_chg");
            this.Property(t => t.mob_step_action).HasColumnName("mob_step_action");
            this.Property(t => t.mob_step_comments).HasColumnName("mob_step_comments");
            this.Property(t => t.mob_wr_id).HasColumnName("mob_wr_id");
            this.Property(t => t.pmp_id).HasColumnName("pmp_id");
            this.Property(t => t.priority).HasColumnName("priority");
            this.Property(t => t.prob_type).HasColumnName("prob_type");
            this.Property(t => t.repair_type).HasColumnName("repair_type");
            this.Property(t => t.request_type).HasColumnName("request_type");
            this.Property(t => t.requestor).HasColumnName("requestor");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.step).HasColumnName("step");
            this.Property(t => t.step_em_id).HasColumnName("step_em_id");
            this.Property(t => t.step_log_id).HasColumnName("step_log_id");
            this.Property(t => t.step_role_name).HasColumnName("step_role_name");
            this.Property(t => t.step_status).HasColumnName("step_status");
            this.Property(t => t.step_type).HasColumnName("step_type");
            this.Property(t => t.step_user_name).HasColumnName("step_user_name");
            this.Property(t => t.supervisor).HasColumnName("supervisor");
            this.Property(t => t.time_assigned).HasColumnName("time_assigned");
            this.Property(t => t.time_completed).HasColumnName("time_completed");
            this.Property(t => t.time_requested).HasColumnName("time_requested");
            this.Property(t => t.tr_id).HasColumnName("tr_id");
            this.Property(t => t.work_team_id).HasColumnName("work_team_id");
            this.Property(t => t.wr_id).HasColumnName("wr_id");
            this.Property(t => t.auto_number).HasColumnName("auto_number");
        }
    }
}
