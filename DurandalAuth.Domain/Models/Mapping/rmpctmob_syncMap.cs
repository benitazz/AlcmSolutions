using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class rmpctmob_syncMap : EntityTypeConfiguration<rmpctmob_sync>
    {
        public rmpctmob_syncMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.del_user_name)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.mob_locked_by)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.pct_id)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.rm_cat)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.rm_type)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.survey_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.user_name)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.action)
                .IsFixedLength()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("rmpctmob_sync", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.date_end).HasColumnName("date_end");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.day_part).HasColumnName("day_part");
            this.Property(t => t.del_user_name).HasColumnName("del_user_name");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.mob_is_changed).HasColumnName("mob_is_changed");
            this.Property(t => t.mob_locked_by).HasColumnName("mob_locked_by");
            this.Property(t => t.pct_id).HasColumnName("pct_id");
            this.Property(t => t.pct_space).HasColumnName("pct_space");
            this.Property(t => t.primary_em).HasColumnName("primary_em");
            this.Property(t => t.primary_rm).HasColumnName("primary_rm");
            this.Property(t => t.rm_cat).HasColumnName("rm_cat");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.rm_type).HasColumnName("rm_type");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.survey_id).HasColumnName("survey_id");
            this.Property(t => t.user_name).HasColumnName("user_name");
            this.Property(t => t.visitor_id).HasColumnName("visitor_id");
            this.Property(t => t.action).HasColumnName("action");
            this.Property(t => t.activity_log_id).HasColumnName("activity_log_id");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasOptional(t => t.activity_log)
                .WithMany(t => t.rmpctmob_sync)
                .HasForeignKey(d => d.activity_log_id);
            this.HasOptional(t => t.bl)
                .WithMany(t => t.rmpctmob_sync)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.dp)
                .WithMany(t => t.rmpctmob_sync)
                .HasForeignKey(d => new { d.dv_id, d.dp_id });
            this.HasOptional(t => t.dv)
                .WithMany(t => t.rmpctmob_sync)
                .HasForeignKey(d => d.dv_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.RmpctmobSync)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.rm)
                .WithMany(t => t.rmpctmob_sync)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });
            this.HasOptional(t => t.rmcat)
                .WithMany(t => t.rmpctmob_sync)
                .HasForeignKey(d => d.rm_cat);
            this.HasOptional(t => t.rmtype)
                .WithMany(t => t.rmpctmob_sync)
                .HasForeignKey(d => new { d.rm_cat, d.rm_type });

        }
    }
}
