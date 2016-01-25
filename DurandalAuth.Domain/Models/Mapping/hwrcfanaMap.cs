using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class hwrcfanaMap : EntityTypeConfiguration<hwrcfana>
    {
        public hwrcfanaMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.cause_type)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.cf_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.prob_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.repair_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.reports_to)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.tr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.work_type)
                .IsFixedLength()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("hwrcfana", "afm");
            this.Property(t => t.avail_labor_hours).HasColumnName("avail_labor_hours");
            this.Property(t => t.avg_response_time).HasColumnName("avg_response_time");
            this.Property(t => t.cause_type).HasColumnName("cause_type");
            this.Property(t => t.cf_id).HasColumnName("cf_id");
            this.Property(t => t.est_labor_hours).HasColumnName("est_labor_hours");
            this.Property(t => t.is_pm).HasColumnName("is_pm");
            this.Property(t => t.month).HasColumnName("month");
            this.Property(t => t.prob_type).HasColumnName("prob_type");
            this.Property(t => t.repair_type).HasColumnName("repair_type");
            this.Property(t => t.reports_to).HasColumnName("reports_to");
            this.Property(t => t.tr_id).HasColumnName("tr_id");
            this.Property(t => t.work_type).HasColumnName("work_type");
            this.Property(t => t.year).HasColumnName("year");
            this.Property(t => t.act_labor_hours).HasColumnName("act_labor_hours");
            this.Property(t => t.auto_number).HasColumnName("auto_number");
        }
    }
}
