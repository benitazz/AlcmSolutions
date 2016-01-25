using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_classMap : EntityTypeConfiguration<afm_class>
    {
        public afm_classMap()
        {
            // Primary Key
            this.HasKey(t => new { t.afm_module, t.act_class });

            // Properties
            this.Property(t => t.act_class_01)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.act_class_02)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.act_class_03)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.act_class_ch)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.act_class_de)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.act_class_es)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.act_class_fr)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.act_class_it)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.act_class_jp)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.act_class_ko)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.act_class_nl)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.act_class_no)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.act_class_zh)
                .IsFixedLength()
                .HasMaxLength(96);

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

            this.Property(t => t.act_class)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("afm_class", "afm");
            this.Property(t => t.act_class_01).HasColumnName("act_class_01");
            this.Property(t => t.act_class_02).HasColumnName("act_class_02");
            this.Property(t => t.act_class_03).HasColumnName("act_class_03");
            this.Property(t => t.act_class_ch).HasColumnName("act_class_ch");
            this.Property(t => t.act_class_de).HasColumnName("act_class_de");
            this.Property(t => t.act_class_es).HasColumnName("act_class_es");
            this.Property(t => t.act_class_fr).HasColumnName("act_class_fr");
            this.Property(t => t.act_class_it).HasColumnName("act_class_it");
            this.Property(t => t.act_class_jp).HasColumnName("act_class_jp");
            this.Property(t => t.act_class_ko).HasColumnName("act_class_ko");
            this.Property(t => t.act_class_nl).HasColumnName("act_class_nl");
            this.Property(t => t.act_class_no).HasColumnName("act_class_no");
            this.Property(t => t.act_class_zh).HasColumnName("act_class_zh");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.display_order).HasColumnName("display_order");
            this.Property(t => t.help_file).HasColumnName("help_file");
            this.Property(t => t.help_topic).HasColumnName("help_topic");
            this.Property(t => t.security_group).HasColumnName("security_group");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.afm_module).HasColumnName("afm_module");
            this.Property(t => t.act_class).HasColumnName("act_class");

            // Relationships
            this.HasRequired(t => t.afm_mods)
                .WithMany(t => t.afm_class)
                .HasForeignKey(d => d.afm_module);
            this.HasOptional(t => t.afm_groups)
                .WithMany(t => t.afm_class)
                .HasForeignKey(d => d.security_group);

        }
    }
}
