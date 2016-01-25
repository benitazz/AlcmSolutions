using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class rm_arrangeMap : EntityTypeConfiguration<rm_arrange>
    {
        public rm_arrangeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.bl_id, t.fl_id, t.rm_id, t.config_id, t.rm_arrange_type_id });

            // Properties
            this.Property(t => t.ac_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.available_for_group)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.doc_image)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.group_name)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.res_stds_not_allowed)
                .HasMaxLength(1000);

            this.Property(t => t.user_approval_expired)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.fl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.rm_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.config_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.rm_arrange_type_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("rm_arrange", "afm");
            this.Property(t => t.ac_id).HasColumnName("ac_id");
            this.Property(t => t.action_approval_expired).HasColumnName("action_approval_expired");
            this.Property(t => t.announce_days).HasColumnName("announce_days");
            this.Property(t => t.announce_time).HasColumnName("announce_time");
            this.Property(t => t.approval).HasColumnName("approval");
            this.Property(t => t.approve_days).HasColumnName("approve_days");
            this.Property(t => t.available_for_group).HasColumnName("available_for_group");
            this.Property(t => t.cost_late_cancel_pct).HasColumnName("cost_late_cancel_pct");
            this.Property(t => t.cost_per_unit).HasColumnName("cost_per_unit");
            this.Property(t => t.cost_per_unit_ext).HasColumnName("cost_per_unit_ext");
            this.Property(t => t.cost_unit).HasColumnName("cost_unit");
            this.Property(t => t.day_end).HasColumnName("day_end");
            this.Property(t => t.day_start).HasColumnName("day_start");
            this.Property(t => t.doc_image).HasColumnName("doc_image");
            this.Property(t => t.external_allowed).HasColumnName("external_allowed");
            this.Property(t => t.group_name).HasColumnName("group_name");
            this.Property(t => t.is_default).HasColumnName("is_default");
            this.Property(t => t.max_capacity).HasColumnName("max_capacity");
            this.Property(t => t.max_days_ahead).HasColumnName("max_days_ahead");
            this.Property(t => t.min_required).HasColumnName("min_required");
            this.Property(t => t.post_block).HasColumnName("post_block");
            this.Property(t => t.pre_block).HasColumnName("pre_block");
            this.Property(t => t.res_stds_not_allowed).HasColumnName("res_stds_not_allowed");
            this.Property(t => t.reservable).HasColumnName("reservable");
            this.Property(t => t.cancel_days).HasColumnName("cancel_days");
            this.Property(t => t.cancel_time).HasColumnName("cancel_time");
            this.Property(t => t.user_approval_expired).HasColumnName("user_approval_expired");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.config_id).HasColumnName("config_id");
            this.Property(t => t.rm_arrange_type_id).HasColumnName("rm_arrange_type_id");

            // Relationships
            this.HasOptional(t => t.ac)
                .WithMany(t => t.rm_arrange)
                .HasForeignKey(d => d.ac_id);
            this.HasOptional(t => t.afm_groups)
                .WithMany(t => t.rm_arrange)
                .HasForeignKey(d => d.available_for_group);
            this.HasOptional(t => t.afm_groups1)
                .WithMany(t => t.rm_arrange1)
                .HasForeignKey(d => d.group_name);
            this.HasOptional(t => t.afm_users)
                .WithMany(t => t.rm_arrange)
                .HasForeignKey(d => d.user_approval_expired);
            this.HasRequired(t => t.bl)
                .WithMany(t => t.rm_arrange)
                .HasForeignKey(d => d.bl_id);
            this.HasRequired(t => t.fl)
                .WithMany(t => t.RmArrange)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasRequired(t => t.rm)
                .WithMany(t => t.rm_arrange)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });
            this.HasRequired(t => t.rm_config)
                .WithMany(t => t.rm_arrange)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id, d.config_id });
            this.HasRequired(t => t.rm_arrange_type)
                .WithMany(t => t.rm_arrange)
                .HasForeignKey(d => d.rm_arrange_type_id);

        }
    }
}
