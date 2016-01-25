using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class moMap : EntityTypeConfiguration<mo>
    {
        public moMap()
        {
            // Primary Key
            this.HasKey(t => t.mo_id);

            // Properties
            this.Property(t => t.ac_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.apprv_mgr1)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.apprv_mgr1_status)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.apprv_mgr2)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.apprv_mgr2_status)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.apprv_mgr3)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.apprv_mgr3_status)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.comments)
                .HasMaxLength(2000);

            this.Property(t => t.dept_contact)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.description)
                .HasMaxLength(5000);

            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.em_new_fp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.em_new_jacks)
                .HasMaxLength(256);

            this.Property(t => t.from_bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.from_comp_type)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.from_dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.from_dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.from_fax)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.from_fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.from_jk_id_data)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.from_jk_id_voice)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.from_mailstop)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.from_phone)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.from_phone_type)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.from_rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.mo_class)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.mo_coord)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.mo_quest)
                .HasMaxLength(2000);

            this.Property(t => t.mo_type)
                .IsFixedLength()
                .HasMaxLength(9);

            this.Property(t => t.mp_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.phone)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.phone_dept_contact)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.project_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.requestor)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.to_bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.to_comp_type)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.to_dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.to_dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.to_fax)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.to_fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.to_jk_id_data)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.to_jk_id_voice)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.to_location)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.to_mailstop)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.to_phone)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.to_phone_type)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.to_rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("mo", "afm");
            this.Property(t => t.ac_id).HasColumnName("ac_id");
            this.Property(t => t.activity_log_id).HasColumnName("activity_log_id");
            this.Property(t => t.apprv_mgr1).HasColumnName("apprv_mgr1");
            this.Property(t => t.apprv_mgr1_status).HasColumnName("apprv_mgr1_status");
            this.Property(t => t.apprv_mgr2).HasColumnName("apprv_mgr2");
            this.Property(t => t.apprv_mgr2_status).HasColumnName("apprv_mgr2_status");
            this.Property(t => t.apprv_mgr3).HasColumnName("apprv_mgr3");
            this.Property(t => t.apprv_mgr3_status).HasColumnName("apprv_mgr3_status");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.cost_actual).HasColumnName("cost_actual");
            this.Property(t => t.cost_est).HasColumnName("cost_est");
            this.Property(t => t.cost_moving_eq).HasColumnName("cost_moving_eq");
            this.Property(t => t.cost_moving_fn).HasColumnName("cost_moving_fn");
            this.Property(t => t.cost_moving_other).HasColumnName("cost_moving_other");
            this.Property(t => t.cost_moving_ta).HasColumnName("cost_moving_ta");
            this.Property(t => t.cost_moving_total).HasColumnName("cost_moving_total");
            this.Property(t => t.date_app_mgr1).HasColumnName("date_app_mgr1");
            this.Property(t => t.date_app_mgr2).HasColumnName("date_app_mgr2");
            this.Property(t => t.date_app_mgr3).HasColumnName("date_app_mgr3");
            this.Property(t => t.date_approved).HasColumnName("date_approved");
            this.Property(t => t.date_closed).HasColumnName("date_closed");
            this.Property(t => t.date_completed).HasColumnName("date_completed");
            this.Property(t => t.date_created).HasColumnName("date_created");
            this.Property(t => t.date_end_req).HasColumnName("date_end_req");
            this.Property(t => t.date_issued).HasColumnName("date_issued");
            this.Property(t => t.date_requested).HasColumnName("date_requested");
            this.Property(t => t.date_start_req).HasColumnName("date_start_req");
            this.Property(t => t.date_to_perform).HasColumnName("date_to_perform");
            this.Property(t => t.dept_contact).HasColumnName("dept_contact");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.em_new_fp_id).HasColumnName("em_new_fp_id");
            this.Property(t => t.em_new_jacks).HasColumnName("em_new_jacks");
            this.Property(t => t.from_bl_id).HasColumnName("from_bl_id");
            this.Property(t => t.from_comp_type).HasColumnName("from_comp_type");
            this.Property(t => t.from_dp_id).HasColumnName("from_dp_id");
            this.Property(t => t.from_dv_id).HasColumnName("from_dv_id");
            this.Property(t => t.from_fax).HasColumnName("from_fax");
            this.Property(t => t.from_fl_id).HasColumnName("from_fl_id");
            this.Property(t => t.from_jk_id_data).HasColumnName("from_jk_id_data");
            this.Property(t => t.from_jk_id_voice).HasColumnName("from_jk_id_voice");
            this.Property(t => t.from_mailstop).HasColumnName("from_mailstop");
            this.Property(t => t.from_phone).HasColumnName("from_phone");
            this.Property(t => t.from_phone_type).HasColumnName("from_phone_type");
            this.Property(t => t.from_rm_id).HasColumnName("from_rm_id");
            this.Property(t => t.hours_actual).HasColumnName("hours_actual");
            this.Property(t => t.hours_est).HasColumnName("hours_est");
            this.Property(t => t.mo_class).HasColumnName("mo_class");
            this.Property(t => t.mo_coord).HasColumnName("mo_coord");
            this.Property(t => t.mo_quest).HasColumnName("mo_quest");
            this.Property(t => t.mo_type).HasColumnName("mo_type");
            this.Property(t => t.move_cancelled).HasColumnName("move_cancelled");
            this.Property(t => t.mp_id).HasColumnName("mp_id");
            this.Property(t => t.num_boxes).HasColumnName("num_boxes");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.phone_dept_contact).HasColumnName("phone_dept_contact");
            this.Property(t => t.priority).HasColumnName("priority");
            this.Property(t => t.project_id).HasColumnName("project_id");
            this.Property(t => t.requestor).HasColumnName("requestor");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.time_completed).HasColumnName("time_completed");
            this.Property(t => t.time_issued).HasColumnName("time_issued");
            this.Property(t => t.time_requested).HasColumnName("time_requested");
            this.Property(t => t.time_to_perform).HasColumnName("time_to_perform");
            this.Property(t => t.to_bl_id).HasColumnName("to_bl_id");
            this.Property(t => t.to_comp_type).HasColumnName("to_comp_type");
            this.Property(t => t.to_dp_id).HasColumnName("to_dp_id");
            this.Property(t => t.to_dv_id).HasColumnName("to_dv_id");
            this.Property(t => t.to_fax).HasColumnName("to_fax");
            this.Property(t => t.to_fl_id).HasColumnName("to_fl_id");
            this.Property(t => t.to_hotel).HasColumnName("to_hotel");
            this.Property(t => t.to_jk_id_data).HasColumnName("to_jk_id_data");
            this.Property(t => t.to_jk_id_voice).HasColumnName("to_jk_id_voice");
            this.Property(t => t.to_location).HasColumnName("to_location");
            this.Property(t => t.to_mailstop).HasColumnName("to_mailstop");
            this.Property(t => t.to_phone).HasColumnName("to_phone");
            this.Property(t => t.to_phone_type).HasColumnName("to_phone_type");
            this.Property(t => t.to_rm_id).HasColumnName("to_rm_id");
            this.Property(t => t.mo_id).HasColumnName("mo_id");

            // Relationships
            this.HasOptional(t => t.ac)
                .WithMany(t => t.moes)
                .HasForeignKey(d => d.ac_id);
            this.HasOptional(t => t.activity_log)
                .WithMany(t => t.moes)
                .HasForeignKey(d => d.activity_log_id);
            this.HasOptional(t => t.dp)
                .WithMany(t => t.moes)
                .HasForeignKey(d => new { d.dv_id, d.dp_id });
            this.HasOptional(t => t.dv)
                .WithMany(t => t.moes)
                .HasForeignKey(d => d.dv_id);
            this.HasOptional(t => t.em)
                .WithMany(t => t.moes)
                .HasForeignKey(d => d.apprv_mgr1);
            this.HasOptional(t => t.em1)
                .WithMany(t => t.moes1)
                .HasForeignKey(d => d.apprv_mgr2);
            this.HasOptional(t => t.em2)
                .WithMany(t => t.moes2)
                .HasForeignKey(d => d.apprv_mgr3);
            this.HasOptional(t => t.em3)
                .WithMany(t => t.moes3)
                .HasForeignKey(d => d.dept_contact);
            this.HasOptional(t => t.em4)
                .WithMany(t => t.moes4)
                .HasForeignKey(d => d.mo_coord);
            this.HasOptional(t => t.em5)
                .WithMany(t => t.moes5)
                .HasForeignKey(d => d.requestor);
            this.HasOptional(t => t.fp)
                .WithMany(t => t.moes)
                .HasForeignKey(d => d.em_new_fp_id);
            this.HasOptional(t => t.mp)
                .WithMany(t => t.moes)
                .HasForeignKey(d => d.mp_id);
            this.HasOptional(t => t.project)
                .WithMany(t => t.moes)
                .HasForeignKey(d => d.project_id);

        }
    }
}
