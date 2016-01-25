using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class work_pkgsMap : EntityTypeConfiguration<work_pkgs>
    {
        public work_pkgsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.project_id, t.work_pkg_id });

            // Properties
            this.Property(t => t.apprv_mgr1)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.apprv_mgr1_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.cx_docs_approved_by)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.cx_docs_provided_by)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.cx_docs_verified_by)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.doc)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.doc_acts_xfer)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.proj_phase)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.summary)
                .HasMaxLength(512);

            this.Property(t => t.wbs_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.project_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.work_pkg_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("work_pkgs", "afm");
            this.Property(t => t.actions_locked).HasColumnName("actions_locked");
            this.Property(t => t.apprv_mgr1).HasColumnName("apprv_mgr1");
            this.Property(t => t.apprv_mgr1_status).HasColumnName("apprv_mgr1_status");
            this.Property(t => t.cx_docs_approved_by).HasColumnName("cx_docs_approved_by");
            this.Property(t => t.cx_docs_provided_by).HasColumnName("cx_docs_provided_by");
            this.Property(t => t.cx_docs_verified_by).HasColumnName("cx_docs_verified_by");
            this.Property(t => t.date_act_end).HasColumnName("date_act_end");
            this.Property(t => t.date_act_start).HasColumnName("date_act_start");
            this.Property(t => t.date_app_mgr1).HasColumnName("date_app_mgr1");
            this.Property(t => t.date_cx_docs_approved).HasColumnName("date_cx_docs_approved");
            this.Property(t => t.date_cx_docs_provided).HasColumnName("date_cx_docs_provided");
            this.Property(t => t.date_cx_docs_verified).HasColumnName("date_cx_docs_verified");
            this.Property(t => t.date_est_end).HasColumnName("date_est_end");
            this.Property(t => t.date_est_start).HasColumnName("date_est_start");
            this.Property(t => t.days_per_week).HasColumnName("days_per_week");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.doc).HasColumnName("doc");
            this.Property(t => t.doc_acts_xfer).HasColumnName("doc_acts_xfer");
            this.Property(t => t.pct_complete).HasColumnName("pct_complete");
            this.Property(t => t.pct_complete_cx_docs).HasColumnName("pct_complete_cx_docs");
            this.Property(t => t.proj_phase).HasColumnName("proj_phase");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.summary).HasColumnName("summary");
            this.Property(t => t.wbs_id).HasColumnName("wbs_id");
            this.Property(t => t.project_id).HasColumnName("project_id");
            this.Property(t => t.work_pkg_id).HasColumnName("work_pkg_id");

            // Relationships
            this.HasOptional(t => t.em)
                .WithMany(t => t.work_pkgs)
                .HasForeignKey(d => d.apprv_mgr1);
            this.HasRequired(t => t.project)
                .WithMany(t => t.work_pkgs)
                .HasForeignKey(d => d.project_id);
            this.HasOptional(t => t.projphase)
                .WithMany(t => t.work_pkgs)
                .HasForeignKey(d => d.proj_phase);
            this.HasOptional(t => t.vn)
                .WithMany(t => t.work_pkgs)
                .HasForeignKey(d => d.cx_docs_provided_by);

        }
    }
}
