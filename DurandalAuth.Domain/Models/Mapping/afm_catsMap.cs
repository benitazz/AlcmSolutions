using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_catsMap : EntityTypeConfiguration<afm_cats>
    {
        public afm_catsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.afm_module, t.act_class, t.act, t.task_cat });

            // Properties
            this.Property(t => t.button)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.comments)
                .HasMaxLength(256);

            this.Property(t => t.help_file)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.help_topic)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.security_group)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.task_cat_01)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.task_cat_02)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.task_cat_03)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.task_cat_ch)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.task_cat_de)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.task_cat_es)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.task_cat_fr)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.task_cat_it)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.task_cat_jp)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.task_cat_ko)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.task_cat_nl)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.task_cat_no)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.task_cat_zh)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

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

            // Table & Column Mappings
            this.ToTable("afm_cats", "afm");
            this.Property(t => t.button).HasColumnName("button");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.dflt_task_cat).HasColumnName("dflt_task_cat");
            this.Property(t => t.display_order).HasColumnName("display_order");
            this.Property(t => t.help_file).HasColumnName("help_file");
            this.Property(t => t.help_topic).HasColumnName("help_topic");
            this.Property(t => t.security_group).HasColumnName("security_group");
            this.Property(t => t.task_cat_01).HasColumnName("task_cat_01");
            this.Property(t => t.task_cat_02).HasColumnName("task_cat_02");
            this.Property(t => t.task_cat_03).HasColumnName("task_cat_03");
            this.Property(t => t.task_cat_ch).HasColumnName("task_cat_ch");
            this.Property(t => t.task_cat_de).HasColumnName("task_cat_de");
            this.Property(t => t.task_cat_es).HasColumnName("task_cat_es");
            this.Property(t => t.task_cat_fr).HasColumnName("task_cat_fr");
            this.Property(t => t.task_cat_it).HasColumnName("task_cat_it");
            this.Property(t => t.task_cat_jp).HasColumnName("task_cat_jp");
            this.Property(t => t.task_cat_ko).HasColumnName("task_cat_ko");
            this.Property(t => t.task_cat_nl).HasColumnName("task_cat_nl");
            this.Property(t => t.task_cat_no).HasColumnName("task_cat_no");
            this.Property(t => t.task_cat_zh).HasColumnName("task_cat_zh");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.afm_module).HasColumnName("afm_module");
            this.Property(t => t.act_class).HasColumnName("act_class");
            this.Property(t => t.act).HasColumnName("act");
            this.Property(t => t.task_cat).HasColumnName("task_cat");

            // Relationships
            this.HasRequired(t => t.afm_acts)
                .WithMany(t => t.afm_cats)
                .HasForeignKey(d => new { d.afm_module, d.act_class, d.act });
            this.HasRequired(t => t.afm_class)
                .WithMany(t => t.afm_cats)
                .HasForeignKey(d => new { d.afm_module, d.act_class });
            this.HasRequired(t => t.afm_mods)
                .WithMany(t => t.afm_cats)
                .HasForeignKey(d => d.afm_module);
            this.HasOptional(t => t.afm_groups)
                .WithMany(t => t.afm_cats)
                .HasForeignKey(d => d.security_group);

        }
    }
}
