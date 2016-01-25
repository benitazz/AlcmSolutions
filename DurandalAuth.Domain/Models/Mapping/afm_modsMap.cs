using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_modsMap : EntityTypeConfiguration<afm_mods>
    {
        public afm_modsMap()
        {
            // Primary Key
            this.HasKey(t => t.afm_module);

            // Properties
            this.Property(t => t.afm_module_01)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.afm_module_02)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.afm_module_03)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.afm_module_ch)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.afm_module_de)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.afm_module_es)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.afm_module_fr)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.afm_module_it)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.afm_module_jp)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.afm_module_ko)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.afm_module_nl)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.afm_module_no)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.afm_module_zh)
                .IsFixedLength()
                .HasMaxLength(48);

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

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.afm_module)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("afm_mods", "afm");
            this.Property(t => t.afm_module_01).HasColumnName("afm_module_01");
            this.Property(t => t.afm_module_02).HasColumnName("afm_module_02");
            this.Property(t => t.afm_module_03).HasColumnName("afm_module_03");
            this.Property(t => t.afm_module_ch).HasColumnName("afm_module_ch");
            this.Property(t => t.afm_module_de).HasColumnName("afm_module_de");
            this.Property(t => t.afm_module_es).HasColumnName("afm_module_es");
            this.Property(t => t.afm_module_fr).HasColumnName("afm_module_fr");
            this.Property(t => t.afm_module_it).HasColumnName("afm_module_it");
            this.Property(t => t.afm_module_jp).HasColumnName("afm_module_jp");
            this.Property(t => t.afm_module_ko).HasColumnName("afm_module_ko");
            this.Property(t => t.afm_module_nl).HasColumnName("afm_module_nl");
            this.Property(t => t.afm_module_no).HasColumnName("afm_module_no");
            this.Property(t => t.afm_module_zh).HasColumnName("afm_module_zh");
            this.Property(t => t.button).HasColumnName("button");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.display_order).HasColumnName("display_order");
            this.Property(t => t.help_file).HasColumnName("help_file");
            this.Property(t => t.help_topic).HasColumnName("help_topic");
            this.Property(t => t.security_group).HasColumnName("security_group");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.visible).HasColumnName("visible");
            this.Property(t => t.afm_module).HasColumnName("afm_module");

            // Relationships
            this.HasOptional(t => t.afm_groups)
                .WithMany(t => t.afm_mods)
                .HasForeignKey(d => d.security_group);

        }
    }
}
