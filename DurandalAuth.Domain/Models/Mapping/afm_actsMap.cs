using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_actsMap : EntityTypeConfiguration<afm_acts>
    {
        public afm_actsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.afm_module, t.act_class, t.act });

            // Properties
            this.Property(t => t.act_de)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.act_es)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.act_fr)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.act_it)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.act_jp)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.act_ko)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.act_nl)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.act_no)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.act_zh)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.act_01)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.act_02)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.act_03)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.act_ch)
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

            this.Property(t => t.act)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("afm_acts", "afm");
            this.Property(t => t.act_de).HasColumnName("act_de");
            this.Property(t => t.act_es).HasColumnName("act_es");
            this.Property(t => t.act_fr).HasColumnName("act_fr");
            this.Property(t => t.act_it).HasColumnName("act_it");
            this.Property(t => t.act_jp).HasColumnName("act_jp");
            this.Property(t => t.act_ko).HasColumnName("act_ko");
            this.Property(t => t.act_nl).HasColumnName("act_nl");
            this.Property(t => t.act_no).HasColumnName("act_no");
            this.Property(t => t.act_zh).HasColumnName("act_zh");
            this.Property(t => t.act_01).HasColumnName("act_01");
            this.Property(t => t.act_02).HasColumnName("act_02");
            this.Property(t => t.act_03).HasColumnName("act_03");
            this.Property(t => t.act_ch).HasColumnName("act_ch");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.display_order).HasColumnName("display_order");
            this.Property(t => t.help_file).HasColumnName("help_file");
            this.Property(t => t.help_topic).HasColumnName("help_topic");
            this.Property(t => t.security_group).HasColumnName("security_group");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.afm_module).HasColumnName("afm_module");
            this.Property(t => t.act_class).HasColumnName("act_class");
            this.Property(t => t.act).HasColumnName("act");

            // Relationships
            this.HasRequired(t => t.afm_class)
                .WithMany(t => t.afm_acts)
                .HasForeignKey(d => new { d.afm_module, d.act_class });
            this.HasRequired(t => t.afm_mods)
                .WithMany(t => t.afm_acts)
                .HasForeignKey(d => d.afm_module);
            this.HasOptional(t => t.afm_groups)
                .WithMany(t => t.afm_acts)
                .HasForeignKey(d => d.security_group);

        }
    }
}
