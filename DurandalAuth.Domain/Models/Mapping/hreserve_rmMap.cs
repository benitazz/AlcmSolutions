using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class hreserve_rmMap : EntityTypeConfiguration<hreserve_rm>
    {
        public hreserve_rmMap()
        {
            // Primary Key
            this.HasKey(t => t.rmres_id);

            // Properties
            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.comments)
                .HasMaxLength(2000);

            this.Property(t => t.config_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.fl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.rm_arrange_type_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.rm_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.user_last_modified_by)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.rmres_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("hreserve_rm", "afm");
            this.Property(t => t.attendees_in_room).HasColumnName("attendees_in_room");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.config_id).HasColumnName("config_id");
            this.Property(t => t.cost_rmres).HasColumnName("cost_rmres");
            this.Property(t => t.date_cancelled).HasColumnName("date_cancelled");
            this.Property(t => t.date_created).HasColumnName("date_created");
            this.Property(t => t.date_last_modified).HasColumnName("date_last_modified");
            this.Property(t => t.date_rejected).HasColumnName("date_rejected");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.guests_external).HasColumnName("guests_external");
            this.Property(t => t.guests_internal).HasColumnName("guests_internal");
            this.Property(t => t.recurring_order).HasColumnName("recurring_order");
            this.Property(t => t.res_id).HasColumnName("res_id");
            this.Property(t => t.rm_arrange_type_id).HasColumnName("rm_arrange_type_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.time_end).HasColumnName("time_end");
            this.Property(t => t.time_start).HasColumnName("time_start");
            this.Property(t => t.user_last_modified_by).HasColumnName("user_last_modified_by");
            this.Property(t => t.verified).HasColumnName("verified");
            this.Property(t => t.rmres_id).HasColumnName("rmres_id");
        }
    }
}
