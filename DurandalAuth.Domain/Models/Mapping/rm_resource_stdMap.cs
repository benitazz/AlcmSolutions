using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class rm_resource_stdMap : EntityTypeConfiguration<rm_resource_std>
    {
        public rm_resource_stdMap()
        {
            // Primary Key
            this.HasKey(t => new { t.bl_id, t.fl_id, t.rm_id, t.config_id, t.rm_arrange_type_id, t.fixed_resource_id });

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(500);

            this.Property(t => t.eq_id)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.resource_std)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

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

            this.Property(t => t.rm_arrange_type_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.fixed_resource_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("rm_resource_std", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.eq_id).HasColumnName("eq_id");
            this.Property(t => t.resource_std).HasColumnName("resource_std");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.config_id).HasColumnName("config_id");
            this.Property(t => t.rm_arrange_type_id).HasColumnName("rm_arrange_type_id");
            this.Property(t => t.fixed_resource_id).HasColumnName("fixed_resource_id");

            // Relationships
            this.HasRequired(t => t.bl)
                .WithMany(t => t.rm_resource_std)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.eq)
                .WithMany(t => t.rm_resource_std)
                .HasForeignKey(d => d.eq_id);
            this.HasRequired(t => t.fl)
                .WithMany(t => t.RmResourceStd)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasRequired(t => t.resource_std1)
                .WithMany(t => t.rm_resource_std)
                .HasForeignKey(d => d.resource_std);
            this.HasRequired(t => t.rm)
                .WithMany(t => t.rm_resource_std)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });
            this.HasRequired(t => t.rm_arrange)
                .WithMany(t => t.rm_resource_std)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id, d.config_id, d.rm_arrange_type_id });
            this.HasRequired(t => t.rm_config)
                .WithMany(t => t.rm_resource_std)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id, d.config_id });

        }
    }
}
