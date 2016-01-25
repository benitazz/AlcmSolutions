using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_hotlistMap : EntityTypeConfiguration<afm_hotlist>
    {
        public afm_hotlistMap()
        {
            // Primary Key
            this.HasKey(t => new { t.super_cat, t.category, t.view_title });

            // Properties
            this.Property(t => t.category_01)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.category_02)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.category_03)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.category_ch)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.category_de)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.category_es)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.category_fr)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.category_it)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.category_jp)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.category_ko)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.category_nl)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.category_no)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.category_zh)
                .IsFixedLength()
                .HasMaxLength(96);

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

            this.Property(t => t.inet_file)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.language)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.proc_file)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.proc_name)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.security_group)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.super_cat_01)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.super_cat_02)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.super_cat_03)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.super_cat_ch)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.super_cat_de)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.super_cat_es)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.super_cat_fr)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.super_cat_it)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.super_cat_jp)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.super_cat_ko)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.super_cat_nl)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.super_cat_no)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.super_cat_zh)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.view_name)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.view_title_01)
                .IsFixedLength()
                .HasMaxLength(144);

            this.Property(t => t.view_title_02)
                .IsFixedLength()
                .HasMaxLength(144);

            this.Property(t => t.view_title_03)
                .IsFixedLength()
                .HasMaxLength(144);

            this.Property(t => t.view_title_ch)
                .IsFixedLength()
                .HasMaxLength(144);

            this.Property(t => t.view_title_de)
                .IsFixedLength()
                .HasMaxLength(144);

            this.Property(t => t.view_title_es)
                .IsFixedLength()
                .HasMaxLength(144);

            this.Property(t => t.view_title_fr)
                .IsFixedLength()
                .HasMaxLength(144);

            this.Property(t => t.view_title_it)
                .IsFixedLength()
                .HasMaxLength(144);

            this.Property(t => t.view_title_jp)
                .IsFixedLength()
                .HasMaxLength(144);

            this.Property(t => t.view_title_ko)
                .IsFixedLength()
                .HasMaxLength(144);

            this.Property(t => t.view_title_nl)
                .IsFixedLength()
                .HasMaxLength(144);

            this.Property(t => t.view_title_no)
                .IsFixedLength()
                .HasMaxLength(144);

            this.Property(t => t.view_title_zh)
                .IsFixedLength()
                .HasMaxLength(144);

            this.Property(t => t.super_cat)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.category)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.view_title)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(96);

            // Table & Column Mappings
            this.ToTable("afm_hotlist", "afm");
            this.Property(t => t.category_01).HasColumnName("category_01");
            this.Property(t => t.category_02).HasColumnName("category_02");
            this.Property(t => t.category_03).HasColumnName("category_03");
            this.Property(t => t.category_ch).HasColumnName("category_ch");
            this.Property(t => t.category_de).HasColumnName("category_de");
            this.Property(t => t.category_es).HasColumnName("category_es");
            this.Property(t => t.category_fr).HasColumnName("category_fr");
            this.Property(t => t.category_it).HasColumnName("category_it");
            this.Property(t => t.category_jp).HasColumnName("category_jp");
            this.Property(t => t.category_ko).HasColumnName("category_ko");
            this.Property(t => t.category_nl).HasColumnName("category_nl");
            this.Property(t => t.category_no).HasColumnName("category_no");
            this.Property(t => t.category_zh).HasColumnName("category_zh");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.display_order).HasColumnName("display_order");
            this.Property(t => t.fixedformat_file).HasColumnName("fixedformat_file");
            this.Property(t => t.help_file).HasColumnName("help_file");
            this.Property(t => t.help_topic).HasColumnName("help_topic");
            this.Property(t => t.inet_file).HasColumnName("inet_file");
            this.Property(t => t.language).HasColumnName("language");
            this.Property(t => t.proc_file).HasColumnName("proc_file");
            this.Property(t => t.proc_name).HasColumnName("proc_name");
            this.Property(t => t.security_group).HasColumnName("security_group");
            this.Property(t => t.super_cat_01).HasColumnName("super_cat_01");
            this.Property(t => t.super_cat_02).HasColumnName("super_cat_02");
            this.Property(t => t.super_cat_03).HasColumnName("super_cat_03");
            this.Property(t => t.super_cat_ch).HasColumnName("super_cat_ch");
            this.Property(t => t.super_cat_de).HasColumnName("super_cat_de");
            this.Property(t => t.super_cat_es).HasColumnName("super_cat_es");
            this.Property(t => t.super_cat_fr).HasColumnName("super_cat_fr");
            this.Property(t => t.super_cat_it).HasColumnName("super_cat_it");
            this.Property(t => t.super_cat_jp).HasColumnName("super_cat_jp");
            this.Property(t => t.super_cat_ko).HasColumnName("super_cat_ko");
            this.Property(t => t.super_cat_nl).HasColumnName("super_cat_nl");
            this.Property(t => t.super_cat_no).HasColumnName("super_cat_no");
            this.Property(t => t.super_cat_zh).HasColumnName("super_cat_zh");
            this.Property(t => t.task_cat).HasColumnName("task_cat");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.view_name).HasColumnName("view_name");
            this.Property(t => t.view_title_01).HasColumnName("view_title_01");
            this.Property(t => t.view_title_02).HasColumnName("view_title_02");
            this.Property(t => t.view_title_03).HasColumnName("view_title_03");
            this.Property(t => t.view_title_ch).HasColumnName("view_title_ch");
            this.Property(t => t.view_title_de).HasColumnName("view_title_de");
            this.Property(t => t.view_title_es).HasColumnName("view_title_es");
            this.Property(t => t.view_title_fr).HasColumnName("view_title_fr");
            this.Property(t => t.view_title_it).HasColumnName("view_title_it");
            this.Property(t => t.view_title_jp).HasColumnName("view_title_jp");
            this.Property(t => t.view_title_ko).HasColumnName("view_title_ko");
            this.Property(t => t.view_title_nl).HasColumnName("view_title_nl");
            this.Property(t => t.view_title_no).HasColumnName("view_title_no");
            this.Property(t => t.view_title_zh).HasColumnName("view_title_zh");
            this.Property(t => t.super_cat).HasColumnName("super_cat");
            this.Property(t => t.category).HasColumnName("category");
            this.Property(t => t.view_title).HasColumnName("view_title");

            // Relationships
            this.HasOptional(t => t.afm_groups)
                .WithMany(t => t.afm_hotlist)
                .HasForeignKey(d => d.security_group);

        }
    }
}
