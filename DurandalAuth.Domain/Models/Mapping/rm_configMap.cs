using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class rm_configMap : EntityTypeConfiguration<rm_config>
    {
        public rm_configMap()
        {
            // Primary Key
            this.HasKey(t => new { t.bl_id, t.fl_id, t.rm_id, t.config_id });

            // Properties
            this.Property(t => t.config_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.doc_layout)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.excluded_config)
                .HasMaxLength(1000);

            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.fl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.rm_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.config_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("rm_config", "afm");
            this.Property(t => t.config_name).HasColumnName("config_name");
            this.Property(t => t.doc_layout).HasColumnName("doc_layout");
            this.Property(t => t.excluded_config).HasColumnName("excluded_config");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.config_id).HasColumnName("config_id");

            // Relationships
            this.HasRequired(t => t.bl)
                .WithMany(t => t.rm_config)
                .HasForeignKey(d => d.bl_id);
            this.HasRequired(t => t.fl)
                .WithMany(t => t.RmConfig)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasRequired(t => t.rm)
                .WithMany(t => t.rm_config)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });

        }
    }
}
