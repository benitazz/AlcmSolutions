using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class energy_bl_svc_periodMap : EntityTypeConfiguration<energy_bl_svc_period>
    {
        public energy_bl_svc_periodMap()
        {
            // Primary Key
            this.HasKey(t => new { t.bl_id, t.bill_type_id, t.time_period });

            // Properties
            this.Property(t => t.vn_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.bill_type_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.time_period)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(7);

            // Table & Column Mappings
            this.ToTable("energy_bl_svc_period", "afm");
            this.Property(t => t.consumption).HasColumnName("consumption");
            this.Property(t => t.cost).HasColumnName("cost");
            this.Property(t => t.date_end).HasColumnName("date_end");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.demand).HasColumnName("demand");
            this.Property(t => t.norm_cdd).HasColumnName("norm_cdd");
            this.Property(t => t.norm_hdd).HasColumnName("norm_hdd");
            this.Property(t => t.num_days).HasColumnName("num_days");
            this.Property(t => t.outlier_consumption).HasColumnName("outlier_consumption");
            this.Property(t => t.outlier_demand).HasColumnName("outlier_demand");
            this.Property(t => t.period_cdd).HasColumnName("period_cdd");
            this.Property(t => t.period_hdd).HasColumnName("period_hdd");
            this.Property(t => t.period_index).HasColumnName("period_index");
            this.Property(t => t.period_oat).HasColumnName("period_oat");
            this.Property(t => t.vn_id).HasColumnName("vn_id");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.bill_type_id).HasColumnName("bill_type_id");
            this.Property(t => t.time_period).HasColumnName("time_period");

            // Relationships
            this.HasRequired(t => t.bill_type)
                .WithMany(t => t.energy_bl_svc_period)
                .HasForeignKey(d => d.bill_type_id);
            this.HasRequired(t => t.bl)
                .WithMany(t => t.energy_bl_svc_period)
                .HasForeignKey(d => d.bl_id);
            this.HasRequired(t => t.energy_time_period)
                .WithMany(t => t.energy_bl_svc_period)
                .HasForeignKey(d => d.time_period);
            this.HasOptional(t => t.vn)
                .WithMany(t => t.energy_bl_svc_period)
                .HasForeignKey(d => d.vn_id);

        }
    }
}
