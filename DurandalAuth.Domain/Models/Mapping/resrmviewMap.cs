using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class resrmviewMap : EntityTypeConfiguration<resrmview>
    {
        public resrmviewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.attendees_in_room, t.bl_id, t.config_id, t.cost_rmres, t.date_created, t.date_start, t.fl_id, t.guests_external, t.guests_internal, t.recurring_order, t.res_id, t.rm_arrange_type_id, t.rm_id, t.rmres_id, t.status, t.time_end, t.time_start, t.verified });

            // Properties
            this.Property(t => t.attendees_in_room)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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

            this.Property(t => t.cost_rmres)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.fl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.guests_external)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.guests_internal)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.recurring_order)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.res_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.rm_arrange_type_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.rm_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.rmres_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.user_last_modified_by)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.verified)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("resrmview", "afm");
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
            this.Property(t => t.rmres_id).HasColumnName("rmres_id");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.time_end).HasColumnName("time_end");
            this.Property(t => t.time_start).HasColumnName("time_start");
            this.Property(t => t.user_last_modified_by).HasColumnName("user_last_modified_by");
            this.Property(t => t.verified).HasColumnName("verified");
        }
    }
}
