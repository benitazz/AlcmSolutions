using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_ptasksMap : EntityTypeConfiguration<afm_ptasks>
    {
        public afm_ptasksMap()
        {
            // Primary Key
            this.HasKey(t => new { t.activity_id, t.process_id, t.task_id });

            // Properties
            this.Property(t => t.comments)
                .HasMaxLength(256);

            this.Property(t => t.help_link)
                .HasMaxLength(255);

            this.Property(t => t.hot_user_name)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.icon_large)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.icon_small)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.security_group)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.task_01)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.task_02)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.task_03)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.task_action)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.task_ch)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.task_de)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.task_es)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.task_file)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.task_fr)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.task_it)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.task_jp)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.task_ko)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.task_nl)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.task_no)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.task_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.task_zh)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.view_type_override)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.activity_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.process_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.task_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("afm_ptasks", "afm");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.display_order).HasColumnName("display_order");
            this.Property(t => t.help_link).HasColumnName("help_link");
            this.Property(t => t.hot_user_name).HasColumnName("hot_user_name");
            this.Property(t => t.icon_large).HasColumnName("icon_large");
            this.Property(t => t.icon_small).HasColumnName("icon_small");
            this.Property(t => t.iframe_height).HasColumnName("iframe_height");
            this.Property(t => t.iframe_width).HasColumnName("iframe_width");
            this.Property(t => t.internal_use1).HasColumnName("internal_use1");
            this.Property(t => t.is_hotlist).HasColumnName("is_hotlist");
            this.Property(t => t.security_group).HasColumnName("security_group");
            this.Property(t => t.task_01).HasColumnName("task_01");
            this.Property(t => t.task_02).HasColumnName("task_02");
            this.Property(t => t.task_03).HasColumnName("task_03");
            this.Property(t => t.task_action).HasColumnName("task_action");
            this.Property(t => t.task_ch).HasColumnName("task_ch");
            this.Property(t => t.task_de).HasColumnName("task_de");
            this.Property(t => t.task_es).HasColumnName("task_es");
            this.Property(t => t.task_file).HasColumnName("task_file");
            this.Property(t => t.task_fr).HasColumnName("task_fr");
            this.Property(t => t.task_it).HasColumnName("task_it");
            this.Property(t => t.task_jp).HasColumnName("task_jp");
            this.Property(t => t.task_ko).HasColumnName("task_ko");
            this.Property(t => t.task_nl).HasColumnName("task_nl");
            this.Property(t => t.task_no).HasColumnName("task_no");
            this.Property(t => t.task_type).HasColumnName("task_type");
            this.Property(t => t.task_zh).HasColumnName("task_zh");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.view_type_override).HasColumnName("view_type_override");
            this.Property(t => t.activity_id).HasColumnName("activity_id");
            this.Property(t => t.process_id).HasColumnName("process_id");
            this.Property(t => t.task_id).HasColumnName("task_id");

            // Relationships
            this.HasRequired(t => t.afm_activities)
                .WithMany(t => t.afm_ptasks)
                .HasForeignKey(d => d.activity_id);
            this.HasOptional(t => t.afm_groups)
                .WithMany(t => t.afm_ptasks)
                .HasForeignKey(d => d.security_group);
            this.HasRequired(t => t.afm_processes)
                .WithMany(t => t.afm_ptasks)
                .HasForeignKey(d => new { d.activity_id, d.process_id });
            this.HasOptional(t => t.afm_users)
                .WithMany(t => t.afm_ptasks)
                .HasForeignKey(d => d.hot_user_name);

        }
    }
}
