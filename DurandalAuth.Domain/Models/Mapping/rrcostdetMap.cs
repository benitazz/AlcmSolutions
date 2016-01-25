using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class rrcostdetMap : EntityTypeConfiguration<rrcostdet>
    {
        public rrcostdetMap()
        {
            // Primary Key
            this.HasKey(t => new { t.date_start, t.time_start, t.time_end, t.bl_id, t.fl_id, t.rm_id, t.rm_arrange_type_id, t.resource_id, t.cost, t.status, t.config_id });

            // Properties
            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.user_requested_by)
                .IsFixedLength()
                .HasMaxLength(35);

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

            this.Property(t => t.rm_arrange_type_id)
                .IsRequired()
                .HasMaxLength(16);

            this.Property(t => t.resource_id)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.cost)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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

            this.Property(t => t.config_id)
                .IsRequired()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("rrcostdet", "afm");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.res_id).HasColumnName("res_id");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.time_start).HasColumnName("time_start");
            this.Property(t => t.time_end).HasColumnName("time_end");
            this.Property(t => t.user_requested_by).HasColumnName("user_requested_by");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.rm_arrange_type_id).HasColumnName("rm_arrange_type_id");
            this.Property(t => t.resource_id).HasColumnName("resource_id");
            this.Property(t => t.quantity).HasColumnName("quantity");
            this.Property(t => t.cost).HasColumnName("cost");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.ctry_id).HasColumnName("ctry_id");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.reservation_name).HasColumnName("reservation_name");
            this.Property(t => t.config_id).HasColumnName("config_id");
        }
    }
}
