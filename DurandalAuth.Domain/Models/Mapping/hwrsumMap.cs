using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class hwrsumMap : EntityTypeConfiguration<hwrsum>
    {
        public hwrsumMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.cause_type)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.eq_id)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.eq_std)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.prob_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.repair_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.tr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.ac_id)
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("hwrsum", "afm");
            this.Property(t => t.avg_response_time).HasColumnName("avg_response_time");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.cause_type).HasColumnName("cause_type");
            this.Property(t => t.cost_est_total).HasColumnName("cost_est_total");
            this.Property(t => t.cost_labor).HasColumnName("cost_labor");
            this.Property(t => t.cost_other).HasColumnName("cost_other");
            this.Property(t => t.cost_parts).HasColumnName("cost_parts");
            this.Property(t => t.cost_tools).HasColumnName("cost_tools");
            this.Property(t => t.cost_total).HasColumnName("cost_total");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.eq_id).HasColumnName("eq_id");
            this.Property(t => t.eq_std).HasColumnName("eq_std");
            this.Property(t => t.est_labor_hours).HasColumnName("est_labor_hours");
            this.Property(t => t.hwr_count).HasColumnName("hwr_count");
            this.Property(t => t.is_pm).HasColumnName("is_pm");
            this.Property(t => t.month).HasColumnName("month");
            this.Property(t => t.prob_type).HasColumnName("prob_type");
            this.Property(t => t.repair_type).HasColumnName("repair_type");
            this.Property(t => t.tr_id).HasColumnName("tr_id");
            this.Property(t => t.year).HasColumnName("year");
            this.Property(t => t.ac_id).HasColumnName("ac_id");
            this.Property(t => t.act_labor_hours).HasColumnName("act_labor_hours");
            this.Property(t => t.auto_number).HasColumnName("auto_number");
        }
    }
}
