using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class wyMap : EntityTypeConfiguration<wy>
    {
        public wyMap()
        {
            // Primary Key
            this.HasKey(t => t.wy_id);

            // Properties
            this.Property(t => t.access_space)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.dwgname)
                .HasMaxLength(128);

            this.Property(t => t.ehandle)
                .HasMaxLength(64);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.tc_cabling_level)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.tc_level)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.wy_type)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.wy_use)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.wy_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("wy", "afm");
            this.Property(t => t.access_space).HasColumnName("access_space");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.date_installed).HasColumnName("date_installed");
            this.Property(t => t.dwgname).HasColumnName("dwgname");
            this.Property(t => t.ehandle).HasColumnName("ehandle");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.length).HasColumnName("length");
            this.Property(t => t.num_cables).HasColumnName("num_cables");
            this.Property(t => t.num_cables_max).HasColumnName("num_cables_max");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.tc_cabling_level).HasColumnName("tc_cabling_level");
            this.Property(t => t.tc_level).HasColumnName("tc_level");
            this.Property(t => t.weight_max).HasColumnName("weight_max");
            this.Property(t => t.weight_total).HasColumnName("weight_total");
            this.Property(t => t.wy_type).HasColumnName("wy_type");
            this.Property(t => t.wy_use).HasColumnName("wy_use");
            this.Property(t => t.wy_id).HasColumnName("wy_id");

            // Relationships
            this.HasOptional(t => t.afm_tclevel)
                .WithMany(t => t.wies)
                .HasForeignKey(d => d.tc_level);
            this.HasOptional(t => t.bl)
                .WithMany(t => t.wies)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.Wies)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.rm)
                .WithMany(t => t.wies)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });
            this.HasOptional(t => t.site)
                .WithMany(t => t.wies)
                .HasForeignKey(d => d.site_id);
            this.HasOptional(t => t.wytype)
                .WithMany(t => t.wies)
                .HasForeignKey(d => d.wy_type);

        }
    }
}
