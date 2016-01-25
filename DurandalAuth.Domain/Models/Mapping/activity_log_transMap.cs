using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class activity_log_transMap : EntityTypeConfiguration<activity_log_trans>
    {
        public activity_log_transMap()
        {
            // Primary Key
            this.HasKey(t => t.activity_log_trans_id);

            // Properties
            this.Property(t => t.assigned_to)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.comments)
                .HasMaxLength(1000);

            this.Property(t => t.predecessors)
                .HasMaxLength(256);

            this.Property(t => t.project_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.project_work_pkg_id)
                .IsFixedLength()
                .HasMaxLength(97);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.wbs_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.work_pkg_id)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.action_title)
                .IsFixedLength()
                .HasMaxLength(75);

            // Table & Column Mappings
            this.ToTable("activity_log_trans", "afm");
            this.Property(t => t.assigned_to).HasColumnName("assigned_to");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.date_scheduled).HasColumnName("date_scheduled");
            this.Property(t => t.duration).HasColumnName("duration");
            this.Property(t => t.pct_complete).HasColumnName("pct_complete");
            this.Property(t => t.predecessors).HasColumnName("predecessors");
            this.Property(t => t.project_id).HasColumnName("project_id");
            this.Property(t => t.project_work_pkg_id).HasColumnName("project_work_pkg_id");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.uid_ms_proj).HasColumnName("uid_ms_proj");
            this.Property(t => t.wbs_id).HasColumnName("wbs_id");
            this.Property(t => t.work_pkg_id).HasColumnName("work_pkg_id");
            this.Property(t => t.action_title).HasColumnName("action_title");
            this.Property(t => t.activity_log_id).HasColumnName("activity_log_id");
            this.Property(t => t.activity_log_trans_id).HasColumnName("activity_log_trans_id");

            // Relationships
            this.HasOptional(t => t.project)
                .WithMany(t => t.activity_log_trans)
                .HasForeignKey(d => d.project_id);
            this.HasOptional(t => t.work_pkgs)
                .WithMany(t => t.activity_log_trans)
                .HasForeignKey(d => new { d.project_id, d.work_pkg_id });

        }
    }
}
