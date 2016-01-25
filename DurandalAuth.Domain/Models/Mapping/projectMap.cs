using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class projectMap : EntityTypeConfiguration<project>
    {
        public projectMap()
        {
            // Primary Key
            this.HasKey(t => t.project_id);

            // Properties
            this.Property(t => t.ac_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.apprv_mgr1)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.apprv_mgr1_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.apprv_mgr2)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.apprv_mgr2_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.apprv_mgr3)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.apprv_mgr3_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.benefit)
                .HasMaxLength(500);

            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.comments)
                .HasMaxLength(1000);

            this.Property(t => t.contact_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.dept_contact)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.doc)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.doc_acts_xfer)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.doc_charter)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.doc_image)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.doc_impl_plan)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.doc_risk_mgmt)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.hierarchy_ids)
                .HasMaxLength(500);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.phone_dept_contact)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.phone_req)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.prob_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.program_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.proj_mgr)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.project_name)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.project_num)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.project_quest)
                .HasMaxLength(2000);

            this.Property(t => t.project_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.requestor)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.scope)
                .HasMaxLength(1000);

            this.Property(t => t.site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.summary)
                .HasMaxLength(500);

            this.Property(t => t.project_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("project", "afm");
            this.Property(t => t.ac_id).HasColumnName("ac_id");
            this.Property(t => t.actions_locked).HasColumnName("actions_locked");
            this.Property(t => t.age_existing).HasColumnName("age_existing");
            this.Property(t => t.apprv_mgr1).HasColumnName("apprv_mgr1");
            this.Property(t => t.apprv_mgr1_status).HasColumnName("apprv_mgr1_status");
            this.Property(t => t.apprv_mgr2).HasColumnName("apprv_mgr2");
            this.Property(t => t.apprv_mgr2_status).HasColumnName("apprv_mgr2_status");
            this.Property(t => t.apprv_mgr3).HasColumnName("apprv_mgr3");
            this.Property(t => t.apprv_mgr3_status).HasColumnName("apprv_mgr3_status");
            this.Property(t => t.area_affected).HasColumnName("area_affected");
            this.Property(t => t.benefit).HasColumnName("benefit");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.contact_id).HasColumnName("contact_id");
            this.Property(t => t.cost_bestcase).HasColumnName("cost_bestcase");
            this.Property(t => t.cost_budget).HasColumnName("cost_budget");
            this.Property(t => t.cost_committed).HasColumnName("cost_committed");
            this.Property(t => t.cost_est_baseline).HasColumnName("cost_est_baseline");
            this.Property(t => t.cost_est_design).HasColumnName("cost_est_design");
            this.Property(t => t.cost_likely).HasColumnName("cost_likely");
            this.Property(t => t.cost_mgmt_res).HasColumnName("cost_mgmt_res");
            this.Property(t => t.cost_neg_chgs).HasColumnName("cost_neg_chgs");
            this.Property(t => t.cost_negotiated).HasColumnName("cost_negotiated");
            this.Property(t => t.cost_paid).HasColumnName("cost_paid");
            this.Property(t => t.cost_target_cur).HasColumnName("cost_target_cur");
            this.Property(t => t.cost_target_orig).HasColumnName("cost_target_orig");
            this.Property(t => t.cost_worstcase).HasColumnName("cost_worstcase");
            this.Property(t => t.date_accepted).HasColumnName("date_accepted");
            this.Property(t => t.date_app_mgr1).HasColumnName("date_app_mgr1");
            this.Property(t => t.date_app_mgr2).HasColumnName("date_app_mgr2");
            this.Property(t => t.date_app_mgr3).HasColumnName("date_app_mgr3");
            this.Property(t => t.date_approved).HasColumnName("date_approved");
            this.Property(t => t.date_baseline).HasColumnName("date_baseline");
            this.Property(t => t.date_bids_award).HasColumnName("date_bids_award");
            this.Property(t => t.date_closed).HasColumnName("date_closed");
            this.Property(t => t.date_commence_work).HasColumnName("date_commence_work");
            this.Property(t => t.date_completed).HasColumnName("date_completed");
            this.Property(t => t.date_cont_end).HasColumnName("date_cont_end");
            this.Property(t => t.date_created).HasColumnName("date_created");
            this.Property(t => t.date_design_com).HasColumnName("date_design_com");
            this.Property(t => t.date_end).HasColumnName("date_end");
            this.Property(t => t.date_issued).HasColumnName("date_issued");
            this.Property(t => t.date_requested).HasColumnName("date_requested");
            this.Property(t => t.date_settlement).HasColumnName("date_settlement");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.date_target_end).HasColumnName("date_target_end");
            this.Property(t => t.days_per_week).HasColumnName("days_per_week");
            this.Property(t => t.dept_contact).HasColumnName("dept_contact");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.doc).HasColumnName("doc");
            this.Property(t => t.doc_acts_xfer).HasColumnName("doc_acts_xfer");
            this.Property(t => t.doc_charter).HasColumnName("doc_charter");
            this.Property(t => t.doc_image).HasColumnName("doc_image");
            this.Property(t => t.doc_impl_plan).HasColumnName("doc_impl_plan");
            this.Property(t => t.doc_risk_mgmt).HasColumnName("doc_risk_mgmt");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.duration).HasColumnName("duration");
            this.Property(t => t.duration_est).HasColumnName("duration_est");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.emp_affected).HasColumnName("emp_affected");
            this.Property(t => t.funding_probability).HasColumnName("funding_probability");
            this.Property(t => t.hierarchy_ids).HasColumnName("hierarchy_ids");
            this.Property(t => t.hours_actual).HasColumnName("hours_actual");
            this.Property(t => t.hours_est).HasColumnName("hours_est");
            this.Property(t => t.is_template).HasColumnName("is_template");
            this.Property(t => t.life_expectancy).HasColumnName("life_expectancy");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.pct_const_comp).HasColumnName("pct_const_comp");
            this.Property(t => t.pct_design_comp).HasColumnName("pct_design_comp");
            this.Property(t => t.pct_total_comp).HasColumnName("pct_total_comp");
            this.Property(t => t.phone_dept_contact).HasColumnName("phone_dept_contact");
            this.Property(t => t.phone_req).HasColumnName("phone_req");
            this.Property(t => t.priority).HasColumnName("priority");
            this.Property(t => t.prob_type).HasColumnName("prob_type");
            this.Property(t => t.program_id).HasColumnName("program_id");
            this.Property(t => t.proj_mgr).HasColumnName("proj_mgr");
            this.Property(t => t.project_name).HasColumnName("project_name");
            this.Property(t => t.project_num).HasColumnName("project_num");
            this.Property(t => t.project_quest).HasColumnName("project_quest");
            this.Property(t => t.project_type).HasColumnName("project_type");
            this.Property(t => t.requestor).HasColumnName("requestor");
            this.Property(t => t.scope).HasColumnName("scope");
            this.Property(t => t.sequence).HasColumnName("sequence");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.summary).HasColumnName("summary");
            this.Property(t => t.project_id).HasColumnName("project_id");

            // Relationships
            this.HasOptional(t => t.ac)
                .WithMany(t => t.projects)
                .HasForeignKey(d => d.ac_id);
            this.HasOptional(t => t.bl)
                .WithMany(t => t.projects)
                .HasForeignKey(d => d.bl_id);
            this.HasRequired(t => t.contact)
                .WithMany(t => t.Projects)
                .HasForeignKey(d => d.contact_id);
            this.HasOptional(t => t.dp)
                .WithMany(t => t.projects)
                .HasForeignKey(d => new { d.dv_id, d.dp_id });
            this.HasOptional(t => t.dv)
                .WithMany(t => t.projects)
                .HasForeignKey(d => d.dv_id);
            this.HasOptional(t => t.em)
                .WithMany(t => t.projects)
                .HasForeignKey(d => d.apprv_mgr1);
            this.HasOptional(t => t.em1)
                .WithMany(t => t.projects1)
                .HasForeignKey(d => d.apprv_mgr2);
            this.HasOptional(t => t.em2)
                .WithMany(t => t.projects2)
                .HasForeignKey(d => d.apprv_mgr3);
            this.HasOptional(t => t.em3)
                .WithMany(t => t.projects3)
                .HasForeignKey(d => d.dept_contact);
            this.HasOptional(t => t.em4)
                .WithMany(t => t.projects4)
                .HasForeignKey(d => d.proj_mgr);
            this.HasOptional(t => t.em5)
                .WithMany(t => t.projects5)
                .HasForeignKey(d => d.requestor);
            this.HasOptional(t => t.probtype)
                .WithMany(t => t.projects)
                .HasForeignKey(d => d.prob_type);
            this.HasOptional(t => t.program)
                .WithMany(t => t.projects)
                .HasForeignKey(d => d.program_id);
            this.HasRequired(t => t.projecttype)
                .WithMany(t => t.projects)
                .HasForeignKey(d => d.project_type);
            this.HasOptional(t => t.site)
                .WithMany(t => t.projects)
                .HasForeignKey(d => d.site_id);

        }
    }
}
