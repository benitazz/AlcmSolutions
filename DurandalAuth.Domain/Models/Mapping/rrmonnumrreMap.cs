using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class rrmonnumrreMap : EntityTypeConfiguration<rrmonnumrre>
    {
        public rrmonnumrreMap()
        {
            // Primary Key
            this.HasKey(t => new { t.date_start, t.bl_id, t.time_start, t.time_end, t.fl_id });

            // Properties
            this.Property(t => t.ctry_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.monthtxt)
                .HasMaxLength(8);

            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.fl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.resource_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.resource_std)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.status)
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("rrmonnumrres", "afm");
            this.Property(t => t.ctry_id).HasColumnName("ctry_id");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.monthtxt).HasColumnName("monthtxt");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.time_start).HasColumnName("time_start");
            this.Property(t => t.time_end).HasColumnName("time_end");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.resource_id).HasColumnName("resource_id");
            this.Property(t => t.resource_std).HasColumnName("resource_std");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.status).HasColumnName("status");
        }
    }
}
