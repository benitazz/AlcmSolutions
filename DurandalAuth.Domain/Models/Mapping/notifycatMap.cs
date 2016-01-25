using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class notifycatMap : EntityTypeConfiguration<notifycat>
    {
        public notifycatMap()
        {
            // Primary Key
            this.HasKey(t => new { t.activity_id, t.notify_cat });

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(256);

            this.Property(t => t.activity_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.notify_cat)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("notifycat", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.activity_id).HasColumnName("activity_id");
            this.Property(t => t.notify_cat).HasColumnName("notify_cat");

            // Relationships
            this.HasRequired(t => t.afm_activities)
                .WithMany(t => t.notifycats)
                .HasForeignKey(d => d.activity_id);

        }
    }
}
