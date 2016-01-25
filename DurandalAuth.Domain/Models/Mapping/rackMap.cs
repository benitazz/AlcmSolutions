using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class rackMap : EntityTypeConfiguration<rack>
    {
        public rackMap()
        {
            // Primary Key
            this.HasKey(t => new { t.bl_id, t.fl_id, t.rm_id, t.rack_id });

            // Properties
            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.dwgname)
                .HasMaxLength(128);

            this.Property(t => t.ehandle)
                .HasMaxLength(64);

            this.Property(t => t.tc_level)
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

            this.Property(t => t.rack_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("rack", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.dwgname).HasColumnName("dwgname");
            this.Property(t => t.ehandle).HasColumnName("ehandle");
            this.Property(t => t.tc_level).HasColumnName("tc_level");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.rack_id).HasColumnName("rack_id");

            // Relationships
            this.HasOptional(t => t.afm_tclevel)
                .WithMany(t => t.racks)
                .HasForeignKey(d => d.tc_level);
            this.HasRequired(t => t.bl)
                .WithMany(t => t.racks)
                .HasForeignKey(d => d.bl_id);
            this.HasRequired(t => t.fl)
                .WithMany(t => t.Racks)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasRequired(t => t.rm)
                .WithMany(t => t.racks)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });

        }
    }
}
