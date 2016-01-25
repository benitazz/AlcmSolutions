using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class caMap : EntityTypeConfiguration<ca>
    {
        public caMap()
        {
            // Primary Key
            this.HasKey(t => t.ca_id);

            // Properties
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

            this.Property(t => t.tc_service)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.tc_use_status)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.ca_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("ca", "afm");
            this.Property(t => t.ca_std).HasColumnName("ca_std");
            this.Property(t => t.cost).HasColumnName("cost");
            this.Property(t => t.date_installed).HasColumnName("date_installed");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.drop_pole).HasColumnName("drop_pole");
            this.Property(t => t.dwgname).HasColumnName("dwgname");
            this.Property(t => t.ehandle).HasColumnName("ehandle");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.is_multiplexing).HasColumnName("is_multiplexing");
            this.Property(t => t.length).HasColumnName("length");
            this.Property(t => t.num_pairs).HasColumnName("num_pairs");
            this.Property(t => t.num_pairs_active).HasColumnName("num_pairs_active");
            this.Property(t => t.num_pairs_avail).HasColumnName("num_pairs_avail");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.tc_cabling_level).HasColumnName("tc_cabling_level");
            this.Property(t => t.tc_level).HasColumnName("tc_level");
            this.Property(t => t.tc_service).HasColumnName("tc_service");
            this.Property(t => t.tc_use_status).HasColumnName("tc_use_status");
            this.Property(t => t.unit_weight).HasColumnName("unit_weight");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.ca_id).HasColumnName("ca_id");

            // Relationships
            this.HasMany(t => t.wies)
                .WithMany(t => t.cas)
                .Map(m =>
                    {
                        m.ToTable("cw", "afm");
                        m.MapLeftKey("ca_id");
                        m.MapRightKey("wy_id");
                    });

            this.HasOptional(t => t.afm_tclevel)
                .WithMany(t => t.cas)
                .HasForeignKey(d => d.tc_level);
            this.HasOptional(t => t.bl)
                .WithMany(t => t.cas)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.castd)
                .WithMany(t => t.cas)
                .HasForeignKey(d => d.ca_std);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.Cas)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.rm)
                .WithMany(t => t.cas)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });
            this.HasOptional(t => t.site)
                .WithMany(t => t.cas)
                .HasForeignKey(d => d.site_id);

        }
    }
}
