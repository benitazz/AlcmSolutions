using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class activity_log_syncMap : EntityTypeConfiguration<activity_log_sync>
    {
        public activity_log_syncMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.completed_by)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.csi_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.description)
                .HasMaxLength(4000);

            this.Property(t => t.doc)
                .IsFixedLength()
                .HasMaxLength(64);

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

            this.Property(t => t.eq_id)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.location)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.mob_locked_by)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.phone_requestor)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.prob_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.project_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.questionnaire_id)
                .IsFixedLength()
                .HasMaxLength(64);

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
                .HasMaxLength(12);

            this.Property(t => t.verified_by)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.act_quest)
                .HasMaxLength(2000);

            this.Property(t => t.activity_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.assessed_by)
                .IsFixedLength()
                .HasMaxLength(35);

            // Table & Column Mappings
            this.ToTable("activity_log_sync", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.completed_by).HasColumnName("completed_by");
            this.Property(t => t.cond_priority).HasColumnName("cond_priority");
            this.Property(t => t.cond_value).HasColumnName("cond_value");
            this.Property(t => t.cost_act_cap).HasColumnName("cost_act_cap");
            this.Property(t => t.cost_est_cap).HasColumnName("cost_est_cap");
            this.Property(t => t.cost_estimated).HasColumnName("cost_estimated");
            this.Property(t => t.cost_to_replace).HasColumnName("cost_to_replace");
            this.Property(t => t.csi_id).HasColumnName("csi_id");
            this.Property(t => t.date_assessed).HasColumnName("date_assessed");
            this.Property(t => t.date_requested).HasColumnName("date_requested");
            this.Property(t => t.date_verified).HasColumnName("date_verified");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.doc).HasColumnName("doc");
            this.Property(t => t.doc1).HasColumnName("doc1");
            this.Property(t => t.doc2).HasColumnName("doc2");
            this.Property(t => t.doc3).HasColumnName("doc3");
            this.Property(t => t.doc4).HasColumnName("doc4");
            this.Property(t => t.eq_id).HasColumnName("eq_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.location).HasColumnName("location");
            this.Property(t => t.mob_is_changed).HasColumnName("mob_is_changed");
            this.Property(t => t.mob_locked_by).HasColumnName("mob_locked_by");
            this.Property(t => t.phone_requestor).HasColumnName("phone_requestor");
            this.Property(t => t.prob_type).HasColumnName("prob_type");
            this.Property(t => t.project_id).HasColumnName("project_id");
            this.Property(t => t.questionnaire_id).HasColumnName("questionnaire_id");
            this.Property(t => t.rec_action).HasColumnName("rec_action");
            this.Property(t => t.requestor).HasColumnName("requestor");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.sust_priority).HasColumnName("sust_priority");
            this.Property(t => t.verified_by).HasColumnName("verified_by");
            this.Property(t => t.act_quest).HasColumnName("act_quest");
            this.Property(t => t.activity_log_id).HasColumnName("activity_log_id");
            this.Property(t => t.activity_type).HasColumnName("activity_type");
            this.Property(t => t.assessed_by).HasColumnName("assessed_by");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasRequired(t => t.activitytype)
                .WithMany(t => t.activity_log_sync)
                .HasForeignKey(d => d.activity_type);
            this.HasOptional(t => t.probtype)
                .WithMany(t => t.activity_log_sync)
                .HasForeignKey(d => d.prob_type);
            this.HasOptional(t => t.em)
                .WithMany(t => t.ActivityLogSync)
                .HasForeignKey(d => d.requestor);

        }
    }
}
