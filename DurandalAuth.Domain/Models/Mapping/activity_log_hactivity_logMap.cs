using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class activity_log_hactivity_logMap : EntityTypeConfiguration<activity_log_hactivity_log>
    {
        public activity_log_hactivity_logMap()
        {
            // Primary Key
            this.HasKey(t => new { t.activity_log_id, t.activity_type, t.autocreate_wr, t.cond_priority, t.cond_value, t.cost_act_cap, t.cost_actual, t.cost_est_cap, t.cost_est_design_cap, t.cost_est_design_exp, t.cost_estimated, t.cost_to_replace, t.date_requested, t.duration, t.duration_act, t.duration_est_baseline, t.escalated_completion, t.escalated_response, t.hours_actual, t.hours_est_baseline, t.hours_est_design, t.owner_type, t.pct_complete, t.qty_life_expct, t.rec_action, t.requestor_type, t.satisfaction, t.start_offset, t.status, t.sust_priority });

            // Properties
            this.Property(t => t.ac_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.act_quest)
                .HasMaxLength(2000);

            this.Property(t => t.action_title)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.activity_log_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.activity_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.approved_by)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.assessed_by)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.assigned_to)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.autocreate_wr)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.capital_program)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.cf_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.comments)
                .HasMaxLength(1000);

            this.Property(t => t.completed_by)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.cond_priority)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cond_value)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cost_act_cap)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cost_actual)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cost_cat_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.cost_est_cap)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cost_est_design_cap)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cost_est_design_exp)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cost_estimated)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cost_to_replace)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.created_by)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.csi_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.description)
                .HasMaxLength(4000);

            this.Property(t => t.dispatcher)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.duration)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.duration_act)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.duration_est_baseline)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dwgname)
                .HasMaxLength(128);

            this.Property(t => t.ehandle)
                .HasMaxLength(64);

            this.Property(t => t.eq_id)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.escalated_completion)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.escalated_response)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.fund_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.hours_actual)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.hours_est_baseline)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.hours_est_design)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.location)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.ls_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.manager)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.op_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.owner_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.parcel_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.pct_complete)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.phone_requestor)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.pr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.predecessors)
                .HasMaxLength(256);

            this.Property(t => t.prob_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.proj_phase)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.project_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.qty_life_expct)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.rec_action)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.requestor)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.requestor_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.resp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.satisfaction)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.satisfaction_notes)
                .HasMaxLength(500);

            this.Property(t => t.site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.start_offset)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.step_status)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.supervisor)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.sust_priority)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.tr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.verified_by)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.vn_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.wbs_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.work_pkg_id)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.work_team_id)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.recurring_rule)
                .HasMaxLength(512);

            this.Property(t => t.pmp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("activity_log_hactivity_log", "afm");
            this.Property(t => t.ac_id).HasColumnName("ac_id");
            this.Property(t => t.act_quest).HasColumnName("act_quest");
            this.Property(t => t.action_title).HasColumnName("action_title");
            this.Property(t => t.activity_log_id).HasColumnName("activity_log_id");
            this.Property(t => t.activity_type).HasColumnName("activity_type");
            this.Property(t => t.approved_by).HasColumnName("approved_by");
            this.Property(t => t.assessed_by).HasColumnName("assessed_by");
            this.Property(t => t.assigned_to).HasColumnName("assigned_to");
            this.Property(t => t.autocreate_wr).HasColumnName("autocreate_wr");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.capital_program).HasColumnName("capital_program");
            this.Property(t => t.cf_id).HasColumnName("cf_id");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.completed_by).HasColumnName("completed_by");
            this.Property(t => t.cond_priority).HasColumnName("cond_priority");
            this.Property(t => t.cond_value).HasColumnName("cond_value");
            this.Property(t => t.copied_from).HasColumnName("copied_from");
            this.Property(t => t.cost_act_cap).HasColumnName("cost_act_cap");
            this.Property(t => t.cost_actual).HasColumnName("cost_actual");
            this.Property(t => t.cost_cat_id).HasColumnName("cost_cat_id");
            this.Property(t => t.cost_est_cap).HasColumnName("cost_est_cap");
            this.Property(t => t.cost_est_design_cap).HasColumnName("cost_est_design_cap");
            this.Property(t => t.cost_est_design_exp).HasColumnName("cost_est_design_exp");
            this.Property(t => t.cost_estimated).HasColumnName("cost_estimated");
            this.Property(t => t.cost_to_replace).HasColumnName("cost_to_replace");
            this.Property(t => t.created_by).HasColumnName("created_by");
            this.Property(t => t.csi_id).HasColumnName("csi_id");
            this.Property(t => t.date_approved).HasColumnName("date_approved");
            this.Property(t => t.date_assessed).HasColumnName("date_assessed");
            this.Property(t => t.date_closed).HasColumnName("date_closed");
            this.Property(t => t.date_completed).HasColumnName("date_completed");
            this.Property(t => t.date_escalation_completion).HasColumnName("date_escalation_completion");
            this.Property(t => t.date_escalation_response).HasColumnName("date_escalation_response");
            this.Property(t => t.date_installed).HasColumnName("date_installed");
            this.Property(t => t.date_issued).HasColumnName("date_issued");
            this.Property(t => t.date_planned_end).HasColumnName("date_planned_end");
            this.Property(t => t.date_planned_for).HasColumnName("date_planned_for");
            this.Property(t => t.date_requested).HasColumnName("date_requested");
            this.Property(t => t.date_required).HasColumnName("date_required");
            this.Property(t => t.date_review).HasColumnName("date_review");
            this.Property(t => t.date_scheduled).HasColumnName("date_scheduled");
            this.Property(t => t.date_scheduled_end).HasColumnName("date_scheduled_end");
            this.Property(t => t.date_started).HasColumnName("date_started");
            this.Property(t => t.date_verified).HasColumnName("date_verified");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.dispatcher).HasColumnName("dispatcher");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.duration).HasColumnName("duration");
            this.Property(t => t.duration_act).HasColumnName("duration_act");
            this.Property(t => t.duration_est_baseline).HasColumnName("duration_est_baseline");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.dwgname).HasColumnName("dwgname");
            this.Property(t => t.ehandle).HasColumnName("ehandle");
            this.Property(t => t.eq_id).HasColumnName("eq_id");
            this.Property(t => t.escalated_completion).HasColumnName("escalated_completion");
            this.Property(t => t.escalated_response).HasColumnName("escalated_response");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.fund_id).HasColumnName("fund_id");
            this.Property(t => t.hours_actual).HasColumnName("hours_actual");
            this.Property(t => t.hours_est_baseline).HasColumnName("hours_est_baseline");
            this.Property(t => t.hours_est_design).HasColumnName("hours_est_design");
            this.Property(t => t.location).HasColumnName("location");
            this.Property(t => t.ls_id).HasColumnName("ls_id");
            this.Property(t => t.manager).HasColumnName("manager");
            this.Property(t => t.mo_id).HasColumnName("mo_id");
            this.Property(t => t.op_id).HasColumnName("op_id");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.owner_type).HasColumnName("owner_type");
            this.Property(t => t.parcel_id).HasColumnName("parcel_id");
            this.Property(t => t.pct_complete).HasColumnName("pct_complete");
            this.Property(t => t.phone_requestor).HasColumnName("phone_requestor");
            this.Property(t => t.po_id).HasColumnName("po_id");
            this.Property(t => t.pr_id).HasColumnName("pr_id");
            this.Property(t => t.predecessors).HasColumnName("predecessors");
            this.Property(t => t.priority).HasColumnName("priority");
            this.Property(t => t.prob_type).HasColumnName("prob_type");
            this.Property(t => t.proj_phase).HasColumnName("proj_phase");
            this.Property(t => t.project_id).HasColumnName("project_id");
            this.Property(t => t.qty_life_expct).HasColumnName("qty_life_expct");
            this.Property(t => t.rec_action).HasColumnName("rec_action");
            this.Property(t => t.regcomp_id).HasColumnName("regcomp_id");
            this.Property(t => t.requestor).HasColumnName("requestor");
            this.Property(t => t.requestor_type).HasColumnName("requestor_type");
            this.Property(t => t.resp_id).HasColumnName("resp_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.satisfaction).HasColumnName("satisfaction");
            this.Property(t => t.satisfaction_notes).HasColumnName("satisfaction_notes");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.start_offset).HasColumnName("start_offset");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.step_status).HasColumnName("step_status");
            this.Property(t => t.supervisor).HasColumnName("supervisor");
            this.Property(t => t.sust_priority).HasColumnName("sust_priority");
            this.Property(t => t.time_escalation_completion).HasColumnName("time_escalation_completion");
            this.Property(t => t.time_escalation_response).HasColumnName("time_escalation_response");
            this.Property(t => t.time_requested).HasColumnName("time_requested");
            this.Property(t => t.time_required).HasColumnName("time_required");
            this.Property(t => t.tr_id).HasColumnName("tr_id");
            this.Property(t => t.verified_by).HasColumnName("verified_by");
            this.Property(t => t.vn_id).HasColumnName("vn_id");
            this.Property(t => t.wbs_id).HasColumnName("wbs_id");
            this.Property(t => t.wo_id).HasColumnName("wo_id");
            this.Property(t => t.work_pkg_id).HasColumnName("work_pkg_id");
            this.Property(t => t.work_team_id).HasColumnName("work_team_id");
            this.Property(t => t.wr_id).HasColumnName("wr_id");
            this.Property(t => t.recurring_rule).HasColumnName("recurring_rule");
            this.Property(t => t.assessment_id).HasColumnName("assessment_id");
            this.Property(t => t.pmp_id).HasColumnName("pmp_id");
            this.Property(t => t.lat).HasColumnName("lat");
            this.Property(t => t.lon).HasColumnName("lon");
            this.Property(t => t.geo_objectid).HasColumnName("geo_objectid");
        }
    }
}
