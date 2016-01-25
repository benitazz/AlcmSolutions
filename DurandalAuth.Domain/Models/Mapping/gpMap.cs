using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class gpMap : EntityTypeConfiguration<gp>
    {
        public gpMap()
        {
            // Primary Key
            this.HasKey(t => t.gp_id);

            // Properties
            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(1024);

            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dwgname)
                .HasMaxLength(128);

            this.Property(t => t.ehandle)
                .HasMaxLength(64);

            this.Property(t => t.fl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.gp_function)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.gp_num)
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.gp_std)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.head)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.layer_name)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.ls_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.name)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.planning_bu_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.portfolio_scenario_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.prorate)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("gp", "afm");
            this.Property(t => t.area).HasColumnName("area");
            this.Property(t => t.area_chargable).HasColumnName("area_chargable");
            this.Property(t => t.area_comn).HasColumnName("area_comn");
            this.Property(t => t.area_comn_gp).HasColumnName("area_comn_gp");
            this.Property(t => t.area_comn_serv).HasColumnName("area_comn_serv");
            this.Property(t => t.area_manual).HasColumnName("area_manual");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.cost).HasColumnName("cost");
            this.Property(t => t.count_em).HasColumnName("count_em");
            this.Property(t => t.date_end).HasColumnName("date_end");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.dwgname).HasColumnName("dwgname");
            this.Property(t => t.ehandle).HasColumnName("ehandle");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.gp_function).HasColumnName("gp_function");
            this.Property(t => t.gp_num).HasColumnName("gp_num");
            this.Property(t => t.gp_std).HasColumnName("gp_std");
            this.Property(t => t.head).HasColumnName("head");
            this.Property(t => t.is_available).HasColumnName("is_available");
            this.Property(t => t.layer_name).HasColumnName("layer_name");
            this.Property(t => t.ls_id).HasColumnName("ls_id");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.pct_floor).HasColumnName("pct_floor");
            this.Property(t => t.planning_bu_id).HasColumnName("planning_bu_id");
            this.Property(t => t.portfolio_scenario_id).HasColumnName("portfolio_scenario_id");
            this.Property(t => t.prorate).HasColumnName("prorate");
            this.Property(t => t.gp_id).HasColumnName("gp_id");

            // Relationships
            this.HasRequired(t => t.bl)
                .WithMany(t => t.gps)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.bu)
                .WithMany(t => t.gps)
                .HasForeignKey(d => d.planning_bu_id);
            this.HasOptional(t => t.dp)
                .WithMany(t => t.gps)
                .HasForeignKey(d => new { d.dv_id, d.dp_id });
            this.HasOptional(t => t.dv)
                .WithMany(t => t.gps)
                .HasForeignKey(d => d.dv_id);
            this.HasRequired(t => t.fl)
                .WithMany(t => t.Gps)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.gpstd)
                .WithMany(t => t.gps)
                .HasForeignKey(d => d.gp_std);
            this.HasOptional(t => t.l)
                .WithMany(t => t.gps)
                .HasForeignKey(d => d.ls_id);
            this.HasOptional(t => t.portfolio_scenario)
                .WithMany(t => t.gps)
                .HasForeignKey(d => d.portfolio_scenario_id);

        }
    }
}
