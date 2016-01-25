using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class rrressheetpluMap : EntityTypeConfiguration<rrressheetplu>
    {
        public rrressheetpluMap()
        {
            // Primary Key
            this.HasKey(t => new { t.res_id, t.date_start, t.user_created_by, t.user_requested_by, t.user_requested_for, t.status });

            // Properties
            this.Property(t => t.res_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ctry_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.user_created_by)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.user_requested_by)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.user_requested_for)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.reservation_name)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("rrressheetplus", "afm");
            this.Property(t => t.res_id).HasColumnName("res_id");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.ctry_id).HasColumnName("ctry_id");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.user_created_by).HasColumnName("user_created_by");
            this.Property(t => t.user_requested_by).HasColumnName("user_requested_by");
            this.Property(t => t.user_requested_for).HasColumnName("user_requested_for");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.reservation_name).HasColumnName("reservation_name");
            this.Property(t => t.status).HasColumnName("status");
        }
    }
}
