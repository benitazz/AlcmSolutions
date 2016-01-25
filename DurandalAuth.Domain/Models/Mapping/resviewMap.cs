using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class resviewMap : EntityTypeConfiguration<resview>
    {
        public resviewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.cost_res, t.date_created, t.date_end, t.date_start, t.recurring_date_modified, t.res_id, t.res_type, t.status, t.time_end, t.time_start, t.user_created_by, t.user_requested_by, t.user_requested_for });

            // Properties
            this.Property(t => t.ac_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.attendees)
                .HasMaxLength(1000);

            this.Property(t => t.comments)
                .HasMaxLength(2000);

            this.Property(t => t.contact)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.cost_res)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.doc_event)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.email)
                .HasMaxLength(64);

            this.Property(t => t.phone)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.recurring_date_modified)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.recurring_rule)
                .HasMaxLength(5000);

            this.Property(t => t.res_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.res_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.reservation_name)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.user_created_by)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.user_last_modified_by)
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

            // Table & Column Mappings
            this.ToTable("resview", "afm");
            this.Property(t => t.ac_id).HasColumnName("ac_id");
            this.Property(t => t.attendees).HasColumnName("attendees");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.contact).HasColumnName("contact");
            this.Property(t => t.cost_res).HasColumnName("cost_res");
            this.Property(t => t.date_cancelled).HasColumnName("date_cancelled");
            this.Property(t => t.date_created).HasColumnName("date_created");
            this.Property(t => t.date_end).HasColumnName("date_end");
            this.Property(t => t.date_last_modified).HasColumnName("date_last_modified");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.doc_event).HasColumnName("doc_event");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.recurring_date_modified).HasColumnName("recurring_date_modified");
            this.Property(t => t.recurring_rule).HasColumnName("recurring_rule");
            this.Property(t => t.res_id).HasColumnName("res_id");
            this.Property(t => t.res_parent).HasColumnName("res_parent");
            this.Property(t => t.res_type).HasColumnName("res_type");
            this.Property(t => t.reservation_name).HasColumnName("reservation_name");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.time_end).HasColumnName("time_end");
            this.Property(t => t.time_start).HasColumnName("time_start");
            this.Property(t => t.user_created_by).HasColumnName("user_created_by");
            this.Property(t => t.user_last_modified_by).HasColumnName("user_last_modified_by");
            this.Property(t => t.user_requested_by).HasColumnName("user_requested_by");
            this.Property(t => t.user_requested_for).HasColumnName("user_requested_for");
            this.Property(t => t.res_conference).HasColumnName("res_conference");
        }
    }
}
