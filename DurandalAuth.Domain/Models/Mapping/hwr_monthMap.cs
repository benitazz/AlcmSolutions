using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class hwr_monthMap : EntityTypeConfiguration<hwr_month>
    {
        public hwr_monthMap()
        {
            // Primary Key
            this.HasKey(t => new { t.wr_id, t.status, t.cost_est_total, t.cost_total, t.escalated_response, t.escalated_completion });

            // Properties
            this.Property(t => t.wr_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.requestor)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.ac_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.repair_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.cause_type)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.prob_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.tr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.eq_id)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.cost_est_total)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cost_total)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.work_team_id)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.escalated_response)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.escalated_completion)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.supervisor)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.month)
                .HasMaxLength(7);

            this.Property(t => t.week)
                .HasMaxLength(7);

            this.Property(t => t.eq_std)
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("hwr_month", "afm");
            this.Property(t => t.wr_id).HasColumnName("wr_id");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.requestor).HasColumnName("requestor");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.ac_id).HasColumnName("ac_id");
            this.Property(t => t.repair_type).HasColumnName("repair_type");
            this.Property(t => t.cause_type).HasColumnName("cause_type");
            this.Property(t => t.prob_type).HasColumnName("prob_type");
            this.Property(t => t.date_requested).HasColumnName("date_requested");
            this.Property(t => t.time_requested).HasColumnName("time_requested");
            this.Property(t => t.date_assigned).HasColumnName("date_assigned");
            this.Property(t => t.time_assigned).HasColumnName("time_assigned");
            this.Property(t => t.date_escalation_response).HasColumnName("date_escalation_response");
            this.Property(t => t.time_escalation_response).HasColumnName("time_escalation_response");
            this.Property(t => t.date_escalation_completion).HasColumnName("date_escalation_completion");
            this.Property(t => t.time_escalation_completion).HasColumnName("time_escalation_completion");
            this.Property(t => t.date_completed).HasColumnName("date_completed");
            this.Property(t => t.time_completed).HasColumnName("time_completed");
            this.Property(t => t.tr_id).HasColumnName("tr_id");
            this.Property(t => t.eq_id).HasColumnName("eq_id");
            this.Property(t => t.cost_est_total).HasColumnName("cost_est_total");
            this.Property(t => t.cost_total).HasColumnName("cost_total");
            this.Property(t => t.wo_id).HasColumnName("wo_id");
            this.Property(t => t.work_team_id).HasColumnName("work_team_id");
            this.Property(t => t.escalated_response).HasColumnName("escalated_response");
            this.Property(t => t.escalated_completion).HasColumnName("escalated_completion");
            this.Property(t => t.supervisor).HasColumnName("supervisor");
            this.Property(t => t.month).HasColumnName("month");
            this.Property(t => t.week).HasColumnName("week");
            this.Property(t => t.eq_std).HasColumnName("eq_std");
            this.Property(t => t.cost_var).HasColumnName("cost_var");
            this.Property(t => t.satisfaction).HasColumnName("satisfaction");
        }
    }
}
