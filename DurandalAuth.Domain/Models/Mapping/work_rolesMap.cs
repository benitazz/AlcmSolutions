using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class work_rolesMap : EntityTypeConfiguration<work_roles>
    {
        public work_rolesMap()
        {
            // Primary Key
            this.HasKey(t => t.work_role_name);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(500);

            this.Property(t => t.title)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.title_01)
                .HasMaxLength(192);

            this.Property(t => t.title_02)
                .HasMaxLength(192);

            this.Property(t => t.title_03)
                .HasMaxLength(192);

            this.Property(t => t.title_ch)
                .HasMaxLength(192);

            this.Property(t => t.title_de)
                .HasMaxLength(192);

            this.Property(t => t.title_es)
                .HasMaxLength(192);

            this.Property(t => t.title_fr)
                .HasMaxLength(192);

            this.Property(t => t.title_it)
                .HasMaxLength(192);

            this.Property(t => t.title_jp)
                .HasMaxLength(192);

            this.Property(t => t.title_ko)
                .HasMaxLength(192);

            this.Property(t => t.title_nl)
                .HasMaxLength(192);

            this.Property(t => t.title_no)
                .HasMaxLength(192);

            this.Property(t => t.title_zh)
                .HasMaxLength(192);

            this.Property(t => t.work_role_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("work_roles", "afm");
            this.Property(t => t.description).HasColumnName("description");
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
            this.Property(t => t.work_role_name).HasColumnName("work_role_name");
        }
    }
}
