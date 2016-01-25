using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class zoneMap : EntityTypeConfiguration<zone>
    {
        public zoneMap()
        {
            // Primary Key
            this.HasKey(t => new { t.bl_id, t.fl_id, t.zone_id });

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(400);

            this.Property(t => t.dwgname)
                .HasMaxLength(128);

            this.Property(t => t.ehandle)
                .HasMaxLength(64);

            this.Property(t => t.hpattern_acad)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.layer_name)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.system_id)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.fl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.zone_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("zone", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.dwgname).HasColumnName("dwgname");
            this.Property(t => t.ehandle).HasColumnName("ehandle");
            this.Property(t => t.highlight_outline).HasColumnName("highlight_outline");
            this.Property(t => t.hpattern_acad).HasColumnName("hpattern_acad");
            this.Property(t => t.layer_name).HasColumnName("layer_name");
            this.Property(t => t.system_id).HasColumnName("system_id");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.zone_id).HasColumnName("zone_id");

            // Relationships
            this.HasRequired(t => t.bl)
                .WithMany(t => t.zones)
                .HasForeignKey(d => d.bl_id);
            this.HasRequired(t => t.fl)
                .WithMany(t => t.Zones)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.system_bl)
                .WithMany(t => t.zones)
                .HasForeignKey(d => d.system_id);

        }
    }
}
