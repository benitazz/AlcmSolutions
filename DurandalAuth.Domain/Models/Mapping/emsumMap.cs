using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class emsumMap : EntityTypeConfiguration<emsum>
    {
        public emsumMap()
        {
            // Primary Key
            this.HasKey(t => t.em_id);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.bu_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.em_std)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("emsum", "afm");
            this.Property(t => t.area).HasColumnName("area");
            this.Property(t => t.area_avg).HasColumnName("area_avg");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.bu_id).HasColumnName("bu_id");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.em_std).HasColumnName("em_std");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.pct_dp).HasColumnName("pct_dp");
            this.Property(t => t.pct_rm).HasColumnName("pct_rm");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.tot_count).HasColumnName("tot_count");
            this.Property(t => t.em_id).HasColumnName("em_id");
        }
    }
}
