using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class rf_activityMap : EntityTypeConfiguration<rf_activity>
    {
        public rf_activityMap()
        {
            // Primary Key
            this.HasKey(t => t.rf_act_id);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.reader_id)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.tag_id)
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("rf_activity", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.date_activity).HasColumnName("date_activity");
            this.Property(t => t.direction).HasColumnName("direction");
            this.Property(t => t.epoch_time).HasColumnName("epoch_time");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.geo_objectid).HasColumnName("geo_objectid");
            this.Property(t => t.lat).HasColumnName("lat");
            this.Property(t => t.lon).HasColumnName("lon");
            this.Property(t => t.reader_id).HasColumnName("reader_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.tag_id).HasColumnName("tag_id");
            this.Property(t => t.time_activity).HasColumnName("time_activity");
            this.Property(t => t.rf_act_id).HasColumnName("rf_act_id");

            // Relationships
            this.HasOptional(t => t.bl)
                .WithMany(t => t.rf_activity)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.RfActivity)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.rf_reader)
                .WithMany(t => t.rf_activity)
                .HasForeignKey(d => d.reader_id);
            this.HasOptional(t => t.rm)
                .WithMany(t => t.rf_activity)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });
            this.HasOptional(t => t.site)
                .WithMany(t => t.rf_activity)
                .HasForeignKey(d => d.site_id);

        }
    }
}
