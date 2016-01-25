using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_tasksMap : EntityTypeConfiguration<afm_tasks>
    {
        public afm_tasksMap()
        {
            // Primary Key
            this.HasKey(t => new { t.afm_module, t.act_class, t.act, t.task_cat, t.task });

            // Properties
            this.Property(t => t.comments)
                .HasMaxLength(256);

            this.Property(t => t.fixedformat_file)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.help_file)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.help_topic)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.proc_file)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.proc_name)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.security_group)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.task_ch)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.task_de)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.task_es)
                .IsFixedLength()
                .HasMaxLength(96);

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

            this.Property(t => t.task_zh)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.view_name)
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

            this.Property(t => t.afm_module)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.act_class)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.act)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.task_cat)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.task)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("afm_tasks", "afm");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.display_order).HasColumnName("display_order");
            this.Property(t => t.fixedformat_file).HasColumnName("fixedformat_file");
            this.Property(t => t.help_file).HasColumnName("help_file");
            this.Property(t => t.help_topic).HasColumnName("help_topic");
            this.Property(t => t.proc_file).HasColumnName("proc_file");
            this.Property(t => t.proc_name).HasColumnName("proc_name");
            this.Property(t => t.security_group).HasColumnName("security_group");
            this.Property(t => t.task_ch).HasColumnName("task_ch");
            this.Property(t => t.task_de).HasColumnName("task_de");
            this.Property(t => t.task_es).HasColumnName("task_es");
            this.Property(t => t.task_fr).HasColumnName("task_fr");
            this.Property(t => t.task_it).HasColumnName("task_it");
            this.Property(t => t.task_jp).HasColumnName("task_jp");
            this.Property(t => t.task_ko).HasColumnName("task_ko");
            this.Property(t => t.task_nl).HasColumnName("task_nl");
            this.Property(t => t.task_no).HasColumnName("task_no");
            this.Property(t => t.task_zh).HasColumnName("task_zh");
            this.Property(t => t.test_has_dialog).HasColumnName("test_has_dialog");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.view_name).HasColumnName("view_name");
            this.Property(t => t.task_01).HasColumnName("task_01");
            this.Property(t => t.task_02).HasColumnName("task_02");
            this.Property(t => t.task_03).HasColumnName("task_03");
            this.Property(t => t.afm_module).HasColumnName("afm_module");
            this.Property(t => t.act_class).HasColumnName("act_class");
            this.Property(t => t.act).HasColumnName("act");
            this.Property(t => t.task_cat).HasColumnName("task_cat");
            this.Property(t => t.task).HasColumnName("task");

            // Relationships
            this.HasRequired(t => t.afm_acts)
                .WithMany(t => t.afm_tasks)
                .HasForeignKey(d => new { d.afm_module, d.act_class, d.act });
            this.HasRequired(t => t.afm_cats)
                .WithMany(t => t.afm_tasks)
                .HasForeignKey(d => new { d.afm_module, d.act_class, d.act, d.task_cat });
            this.HasRequired(t => t.afm_class)
                .WithMany(t => t.afm_tasks)
                .HasForeignKey(d => new { d.afm_module, d.act_class });
            this.HasOptional(t => t.afm_groups)
                .WithMany(t => t.afm_tasks)
                .HasForeignKey(d => d.security_group);
            this.HasRequired(t => t.afm_mods)
                .WithMany(t => t.afm_tasks)
                .HasForeignKey(d => d.afm_module);

        }
    }
}
