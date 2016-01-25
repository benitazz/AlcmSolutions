using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class jkMap : EntityTypeConfiguration<jk>
    {
        public jkMap()
        {
            // Primary Key
            this.HasKey(t => t.jk_id);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.ca_std)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.drop_pole)
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.dwgname)
                .HasMaxLength(128);

            this.Property(t => t.ehandle)
                .HasMaxLength(64);

            this.Property(t => t.em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.extension)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.fp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.grid_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.jk_std)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.pbx_port_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.phone)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.tc_level)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.tc_service)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.tc_use)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.tc_use_status)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.jk_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("jk", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.ca_std).HasColumnName("ca_std");
            this.Property(t => t.date_installed).HasColumnName("date_installed");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.drop_pole).HasColumnName("drop_pole");
            this.Property(t => t.dwgname).HasColumnName("dwgname");
            this.Property(t => t.ehandle).HasColumnName("ehandle");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.extension).HasColumnName("extension");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.fp_id).HasColumnName("fp_id");
            this.Property(t => t.grid_id).HasColumnName("grid_id");
            this.Property(t => t.jk_std).HasColumnName("jk_std");
            this.Property(t => t.pbx_port_id).HasColumnName("pbx_port_id");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.tc_level).HasColumnName("tc_level");
            this.Property(t => t.tc_service).HasColumnName("tc_service");
            this.Property(t => t.tc_use).HasColumnName("tc_use");
            this.Property(t => t.tc_use_status).HasColumnName("tc_use_status");
            this.Property(t => t.jk_id).HasColumnName("jk_id");

            // Relationships
            this.HasMany(t => t.wies)
                .WithMany(t => t.jks)
                .Map(m =>
                    {
                        m.ToTable("jw", "afm");
                        m.MapLeftKey("jk_id");
                        m.MapRightKey("wy_id");
                    });

            this.HasOptional(t => t.afm_tclevel)
                .WithMany(t => t.jks)
                .HasForeignKey(d => d.tc_level);
            this.HasOptional(t => t.bl)
                .WithMany(t => t.jks)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.castd)
                .WithMany(t => t.jks)
                .HasForeignKey(d => d.ca_std);
            this.HasOptional(t => t.em)
                .WithMany(t => t.Jks)
                .HasForeignKey(d => d.em_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.Jks)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.fp)
                .WithMany(t => t.jks)
                .HasForeignKey(d => d.fp_id);
            this.HasOptional(t => t.grid)
                .WithMany(t => t.jks)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.grid_id });
            this.HasOptional(t => t.jkstd)
                .WithMany(t => t.jks)
                .HasForeignKey(d => d.jk_std);
            this.HasOptional(t => t.rm)
                .WithMany(t => t.jks)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });

        }
    }
}
