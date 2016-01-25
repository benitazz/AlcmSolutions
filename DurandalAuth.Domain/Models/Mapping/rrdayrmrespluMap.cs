using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class rrdayrmrespluMap : EntityTypeConfiguration<rrdayrmresplu>
    {
        public rrdayrmrespluMap()
        {
            // Primary Key
            this.HasKey(t => new { t.bl_id, t.date_start, t.time_start, t.time_end, t.fl_id, t.rm_id, t.resource_id, t.quantity, t.rm_arrange_type_id, t.status });

            // Properties
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

            this.Property(t => t.resource_id)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.quantity)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.user_requested_for)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.phone)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.comments)
                .HasMaxLength(2000);

            this.Property(t => t.rm_arrange_type_id)
                .IsRequired()
                .HasMaxLength(16);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.ctry_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.reservation_name)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.tr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.vn_id)
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("rrdayrmresplus", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.time_start).HasColumnName("time_start");
            this.Property(t => t.time_end).HasColumnName("time_end");
            this.Property(t => t.res_id).HasColumnName("res_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.resource_id).HasColumnName("resource_id");
            this.Property(t => t.quantity).HasColumnName("quantity");
            this.Property(t => t.user_requested_for).HasColumnName("user_requested_for");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.rm_arrange_type_id).HasColumnName("rm_arrange_type_id");
            this.Property(t => t.total_guest).HasColumnName("total_guest");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.ctry_id).HasColumnName("ctry_id");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.reservation_name).HasColumnName("reservation_name");
            this.Property(t => t.tr_id).HasColumnName("tr_id");
            this.Property(t => t.vn_id).HasColumnName("vn_id");
        }
    }
}
