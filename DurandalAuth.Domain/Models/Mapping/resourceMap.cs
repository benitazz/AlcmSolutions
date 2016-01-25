using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class resourceMap : EntityTypeConfiguration<resource>
    {
        public resourceMap()
        {
            // Primary Key
            this.HasKey(t => t.resource_id);

            // Properties
            this.Property(t => t.ac_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.available_for_group)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.doc_image)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.eq_id)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.group_name)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.resource_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.resource_std)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.resource_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.room_service_group)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.user_approval_expired)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.resource_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("resources", "afm");
            this.Property(t => t.ac_id).HasColumnName("ac_id");
            this.Property(t => t.action_approval_expired).HasColumnName("action_approval_expired");
            this.Property(t => t.announce_days).HasColumnName("announce_days");
            this.Property(t => t.announce_time).HasColumnName("announce_time");
            this.Property(t => t.approval).HasColumnName("approval");
            this.Property(t => t.approve_days).HasColumnName("approve_days");
            this.Property(t => t.available_for_group).HasColumnName("available_for_group");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.cancel_days).HasColumnName("cancel_days");
            this.Property(t => t.cancel_time).HasColumnName("cancel_time");
            this.Property(t => t.cost_late_cancel_pct).HasColumnName("cost_late_cancel_pct");
            this.Property(t => t.cost_per_unit).HasColumnName("cost_per_unit");
            this.Property(t => t.cost_per_unit_ext).HasColumnName("cost_per_unit_ext");
            this.Property(t => t.cost_unit).HasColumnName("cost_unit");
            this.Property(t => t.day_end).HasColumnName("day_end");
            this.Property(t => t.day_start).HasColumnName("day_start");
            this.Property(t => t.default_calculation).HasColumnName("default_calculation");
            this.Property(t => t.doc_image).HasColumnName("doc_image");
            this.Property(t => t.eq_id).HasColumnName("eq_id");
            this.Property(t => t.group_name).HasColumnName("group_name");
            this.Property(t => t.max_days_ahead).HasColumnName("max_days_ahead");
            this.Property(t => t.post_block).HasColumnName("post_block");
            this.Property(t => t.pre_block).HasColumnName("pre_block");
            this.Property(t => t.quantity).HasColumnName("quantity");
            this.Property(t => t.reservable).HasColumnName("reservable");
            this.Property(t => t.resource_name).HasColumnName("resource_name");
            this.Property(t => t.resource_std).HasColumnName("resource_std");
            this.Property(t => t.resource_type).HasColumnName("resource_type");
            this.Property(t => t.room_service).HasColumnName("room_service");
            this.Property(t => t.room_service_group).HasColumnName("room_service_group");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.user_approval_expired).HasColumnName("user_approval_expired");
            this.Property(t => t.resource_id).HasColumnName("resource_id");

            // Relationships
            this.HasOptional(t => t.ac)
                .WithMany(t => t.resources)
                .HasForeignKey(d => d.ac_id);
            this.HasOptional(t => t.afm_groups)
                .WithMany(t => t.resources)
                .HasForeignKey(d => d.available_for_group);
            this.HasOptional(t => t.afm_groups1)
                .WithMany(t => t.resources1)
                .HasForeignKey(d => d.group_name);
            this.HasOptional(t => t.afm_groups2)
                .WithMany(t => t.resources2)
                .HasForeignKey(d => d.room_service_group);
            this.HasOptional(t => t.afm_users)
                .WithMany(t => t.resources)
                .HasForeignKey(d => d.user_approval_expired);
            this.HasOptional(t => t.bl)
                .WithMany(t => t.resources)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.eq)
                .WithMany(t => t.resources)
                .HasForeignKey(d => d.eq_id);
            this.HasRequired(t => t.resource_std1)
                .WithMany(t => t.resources)
                .HasForeignKey(d => d.resource_std);
            this.HasOptional(t => t.site)
                .WithMany(t => t.resources)
                .HasForeignKey(d => d.site_id);

        }
    }
}
