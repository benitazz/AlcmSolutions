using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_mobile_appsMap : EntityTypeConfiguration<afm_mobile_apps>
    {
        public afm_mobile_appsMap()
        {
            // Primary Key
            this.HasKey(t => t.activity_id);

            // Properties
            this.Property(t => t.icon_large)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.main_page_url)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.security_group)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.title)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.title_01)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.title_02)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.title_03)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.title_ch)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.title_de)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.title_es)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.title_fr)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.title_it)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.title_jp)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.title_ko)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.title_nl)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.title_no)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.title_zh)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.activity_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("afm_mobile_apps", "afm");
            this.Property(t => t.display_order).HasColumnName("display_order");
            this.Property(t => t.icon_large).HasColumnName("icon_large");
            this.Property(t => t.main_page_url).HasColumnName("main_page_url");
            this.Property(t => t.security_group).HasColumnName("security_group");
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
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.activity_id).HasColumnName("activity_id");

            // Relationships
            this.HasOptional(t => t.afm_groups)
                .WithMany(t => t.afm_mobile_apps)
                .HasForeignKey(d => d.security_group);

        }
    }
}
