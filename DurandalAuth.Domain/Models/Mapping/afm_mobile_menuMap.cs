using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_mobile_menuMap : EntityTypeConfiguration<afm_mobile_menu>
    {
        public afm_mobile_menuMap()
        {
            // Primary Key
            this.HasKey(t => t.menu_id);

            // Properties
            this.Property(t => t.activity_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.description)
                .HasMaxLength(512);

            this.Property(t => t.description_01)
                .HasMaxLength(512);

            this.Property(t => t.description_02)
                .HasMaxLength(512);

            this.Property(t => t.description_03)
                .HasMaxLength(512);

            this.Property(t => t.description_ch)
                .HasMaxLength(512);

            this.Property(t => t.description_de)
                .HasMaxLength(512);

            this.Property(t => t.description_es)
                .HasMaxLength(512);

            this.Property(t => t.description_fr)
                .HasMaxLength(512);

            this.Property(t => t.description_it)
                .HasMaxLength(512);

            this.Property(t => t.description_jp)
                .HasMaxLength(512);

            this.Property(t => t.description_ko)
                .HasMaxLength(512);

            this.Property(t => t.description_nl)
                .HasMaxLength(512);

            this.Property(t => t.description_no)
                .HasMaxLength(512);

            this.Property(t => t.description_zh)
                .HasMaxLength(512);

            this.Property(t => t.group_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.menu_icon)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.mobile_action)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.title)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.title_01)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.title_02)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.title_03)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.title_ch)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.title_de)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.title_es)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.title_fr)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.title_it)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.title_jp)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.title_ko)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.title_nl)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.title_no)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.title_zh)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.menu_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("afm_mobile_menu", "afm");
            this.Property(t => t.activity_id).HasColumnName("activity_id");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.description_01).HasColumnName("description_01");
            this.Property(t => t.description_02).HasColumnName("description_02");
            this.Property(t => t.description_03).HasColumnName("description_03");
            this.Property(t => t.description_ch).HasColumnName("description_ch");
            this.Property(t => t.description_de).HasColumnName("description_de");
            this.Property(t => t.description_es).HasColumnName("description_es");
            this.Property(t => t.description_fr).HasColumnName("description_fr");
            this.Property(t => t.description_it).HasColumnName("description_it");
            this.Property(t => t.description_jp).HasColumnName("description_jp");
            this.Property(t => t.description_ko).HasColumnName("description_ko");
            this.Property(t => t.description_nl).HasColumnName("description_nl");
            this.Property(t => t.description_no).HasColumnName("description_no");
            this.Property(t => t.description_zh).HasColumnName("description_zh");
            this.Property(t => t.display_order).HasColumnName("display_order");
            this.Property(t => t.group_name).HasColumnName("group_name");
            this.Property(t => t.menu_icon).HasColumnName("menu_icon");
            this.Property(t => t.mobile_action).HasColumnName("mobile_action");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.title_01).HasColumnName("title_01");
            this.Property(t => t.title_02).HasColumnName("title_02");
            this.Property(t => t.title_03).HasColumnName("title_03");
            this.Property(t => t.title_ch).HasColumnName("title_ch");
            this.Property(t => t.title_de).HasColumnName("title_de");
            this.Property(t => t.title_es).HasColumnName("title_es");
            this.Property(t => t.title_fr).HasColumnName("title_fr");
            this.Property(t => t.title_it).HasColumnName("title_it");
            this.Property(t => t.title_jp).HasColumnName("title_jp");
            this.Property(t => t.title_ko).HasColumnName("title_ko");
            this.Property(t => t.title_nl).HasColumnName("title_nl");
            this.Property(t => t.title_no).HasColumnName("title_no");
            this.Property(t => t.title_zh).HasColumnName("title_zh");
            this.Property(t => t.menu_id).HasColumnName("menu_id");

            // Relationships
            this.HasRequired(t => t.afm_groups)
                .WithMany(t => t.afm_mobile_menu)
                .HasForeignKey(d => d.group_name);
            this.HasRequired(t => t.afm_mobile_apps)
                .WithMany(t => t.afm_mobile_menu)
                .HasForeignKey(d => d.activity_id);

        }
    }
}
