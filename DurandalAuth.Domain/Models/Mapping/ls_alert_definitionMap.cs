using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ls_alert_definitionMap : EntityTypeConfiguration<ls_alert_definition>
    {
        public ls_alert_definitionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.alert_type, t.role_name, t.color });

            // Properties
            this.Property(t => t.alert_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.role_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.color)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("ls_alert_definition", "afm");
            this.Property(t => t.issue_alert).HasColumnName("issue_alert");
            this.Property(t => t.notification_days).HasColumnName("notification_days");
            this.Property(t => t.removal_days).HasColumnName("removal_days");
            this.Property(t => t.send_email).HasColumnName("send_email");
            this.Property(t => t.alert_type).HasColumnName("alert_type");
            this.Property(t => t.role_name).HasColumnName("role_name");
            this.Property(t => t.color).HasColumnName("color");

            // Relationships
            this.HasRequired(t => t.afm_roles)
                .WithMany(t => t.ls_alert_definition)
                .HasForeignKey(d => d.role_name);

        }
    }
}
