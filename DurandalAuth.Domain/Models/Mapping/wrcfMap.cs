using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class wrcfMap : EntityTypeConfiguration<wrcf>
    {
        public wrcfMap()
        {
            // Primary Key
            this.HasKey(t => new { t.wr_id, t.cf_id, t.date_assigned, t.time_assigned });

            // Properties
            this.Property(t => t.msg_delivery_status)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.scheduled_from_tr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.status_from_remote_cf)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.comments)
                .HasMaxLength(5000);

            this.Property(t => t.work_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.wr_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cf_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("wrcf", "afm");
            this.Property(t => t.date_end).HasColumnName("date_end");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.hours_diff).HasColumnName("hours_diff");
            this.Property(t => t.hours_double).HasColumnName("hours_double");
            this.Property(t => t.hours_est).HasColumnName("hours_est");
            this.Property(t => t.hours_over).HasColumnName("hours_over");
            this.Property(t => t.hours_straight).HasColumnName("hours_straight");
            this.Property(t => t.hours_total).HasColumnName("hours_total");
            this.Property(t => t.msg_delivery_status).HasColumnName("msg_delivery_status");
            this.Property(t => t.scheduled_from_tr_id).HasColumnName("scheduled_from_tr_id");
            this.Property(t => t.status_from_remote_cf).HasColumnName("status_from_remote_cf");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.cost_double).HasColumnName("cost_double");
            this.Property(t => t.cost_estimated).HasColumnName("cost_estimated");
            this.Property(t => t.cost_over).HasColumnName("cost_over");
            this.Property(t => t.cost_straight).HasColumnName("cost_straight");
            this.Property(t => t.cost_total).HasColumnName("cost_total");
            this.Property(t => t.time_end).HasColumnName("time_end");
            this.Property(t => t.time_start).HasColumnName("time_start");
            this.Property(t => t.work_type).HasColumnName("work_type");
            this.Property(t => t.wr_id).HasColumnName("wr_id");
            this.Property(t => t.cf_id).HasColumnName("cf_id");
            this.Property(t => t.date_assigned).HasColumnName("date_assigned");
            this.Property(t => t.time_assigned).HasColumnName("time_assigned");

            // Relationships
            this.HasRequired(t => t.cf)
                .WithMany(t => t.Wrcfs)
                .HasForeignKey(d => d.cf_id);
            this.HasOptional(t => t.tr)
                .WithMany(t => t.wrcfs)
                .HasForeignKey(d => d.scheduled_from_tr_id);
            this.HasRequired(t => t.wr)
                .WithMany(t => t.wrcfs)
                .HasForeignKey(d => d.wr_id);

        }
    }
}
