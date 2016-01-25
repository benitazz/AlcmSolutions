using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class gb_cert_projMap : EntityTypeConfiguration<gb_cert_proj>
    {
        public gb_cert_projMap()
        {
            // Primary Key
            this.HasKey(t => new { t.bl_id, t.cert_std, t.project_name });

            // Properties
            this.Property(t => t.certified_level)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.description)
                .HasMaxLength(300);

            this.Property(t => t.description_area)
                .HasMaxLength(500);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.goal_level)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.cert_num)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.cert_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.cert_std)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.project_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("gb_cert_proj", "afm");
            this.Property(t => t.certified_level).HasColumnName("certified_level");
            this.Property(t => t.date_application).HasColumnName("date_application");
            this.Property(t => t.date_certified).HasColumnName("date_certified");
            this.Property(t => t.date_closed).HasColumnName("date_closed");
            this.Property(t => t.date_perf_end).HasColumnName("date_perf_end");
            this.Property(t => t.date_perf_start).HasColumnName("date_perf_start");
            this.Property(t => t.date_registered).HasColumnName("date_registered");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.description_area).HasColumnName("description_area");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.goal_level).HasColumnName("goal_level");
            this.Property(t => t.cert_num).HasColumnName("cert_num");
            this.Property(t => t.cert_part_num).HasColumnName("cert_part_num");
            this.Property(t => t.cert_status).HasColumnName("cert_status");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.tot_annual_savings).HasColumnName("tot_annual_savings");
            this.Property(t => t.tot_capital_cost).HasColumnName("tot_capital_cost");
            this.Property(t => t.tot_final_score).HasColumnName("tot_final_score");
            this.Property(t => t.tot_payback_period).HasColumnName("tot_payback_period");
            this.Property(t => t.tot_self_score).HasColumnName("tot_self_score");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.cert_std).HasColumnName("cert_std");
            this.Property(t => t.project_name).HasColumnName("project_name");

            // Relationships
            this.HasRequired(t => t.bl)
                .WithMany(t => t.gb_cert_proj)
                .HasForeignKey(d => d.bl_id);
            this.HasRequired(t => t.gb_cert_levels)
                .WithMany(t => t.gb_cert_proj)
                .HasForeignKey(d => new { d.cert_std, d.certified_level });
            this.HasRequired(t => t.gb_cert_levels1)
                .WithMany(t => t.gb_cert_proj1)
                .HasForeignKey(d => new { d.cert_std, d.goal_level });
            this.HasRequired(t => t.gb_cert_std)
                .WithMany(t => t.gb_cert_proj)
                .HasForeignKey(d => d.cert_std);

        }
    }
}
