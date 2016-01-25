using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class servsumMap : EntityTypeConfiguration<servsum>
    {
        public servsumMap()
        {
            // Primary Key
            this.HasKey(t => t.serv_id);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.serv_std)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("servsum", "afm");
            this.Property(t => t.area).HasColumnName("area");
            this.Property(t => t.area_avg).HasColumnName("area_avg");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.pct_gross_int).HasColumnName("pct_gross_int");
            this.Property(t => t.pct_rentable).HasColumnName("pct_rentable");
            this.Property(t => t.serv_std).HasColumnName("serv_std");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.tot_count).HasColumnName("tot_count");
            this.Property(t => t.serv_id).HasColumnName("serv_id");
        }
    }
}
