using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class wrttMap : EntityTypeConfiguration<wrtt>
    {
        public wrttMap()
        {
            // Primary Key
            this.HasKey(t => new { t.wr_id, t.tool_type });

            // Properties
            this.Property(t => t.comments)
                .HasMaxLength(5000);

            this.Property(t => t.wr_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.tool_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("wrtt", "afm");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.cost_estimated).HasColumnName("cost_estimated");
            this.Property(t => t.cost_over).HasColumnName("cost_over");
            this.Property(t => t.cost_straight).HasColumnName("cost_straight");
            this.Property(t => t.cost_total).HasColumnName("cost_total");
            this.Property(t => t.date_assigned).HasColumnName("date_assigned");
            this.Property(t => t.date_end).HasColumnName("date_end");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.hours_diff).HasColumnName("hours_diff");
            this.Property(t => t.hours_est).HasColumnName("hours_est");
            this.Property(t => t.hours_over).HasColumnName("hours_over");
            this.Property(t => t.hours_sched).HasColumnName("hours_sched");
            this.Property(t => t.hours_straight).HasColumnName("hours_straight");
            this.Property(t => t.hours_total).HasColumnName("hours_total");
            this.Property(t => t.time_assigned).HasColumnName("time_assigned");
            this.Property(t => t.time_end).HasColumnName("time_end");
            this.Property(t => t.time_start).HasColumnName("time_start");
            this.Property(t => t.wr_id).HasColumnName("wr_id");
            this.Property(t => t.tool_type).HasColumnName("tool_type");

            // Relationships
            this.HasRequired(t => t.tt)
                .WithMany(t => t.wrtts)
                .HasForeignKey(d => d.tool_type);
            this.HasRequired(t => t.wr)
                .WithMany(t => t.wrtts)
                .HasForeignKey(d => d.wr_id);

        }
    }
}
