using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ehs_medical_mon_resultsMap : EntityTypeConfiguration<ehs_medical_mon_results>
    {
        public ehs_medical_mon_resultsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.medical_monitoring_id, t.em_id, t.date_actual });

            // Properties
            this.Property(t => t.comments)
                .HasMaxLength(500);

            this.Property(t => t.monitoring_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(17);

            this.Property(t => t.resulting_actions)
                .HasMaxLength(500);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(7);

            this.Property(t => t.tracking_number)
                .HasMaxLength(30);

            this.Property(t => t.medical_monitoring_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.em_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(35);

            // Table & Column Mappings
            this.ToTable("ehs_medical_mon_results", "afm");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.incident_id).HasColumnName("incident_id");
            this.Property(t => t.monitoring_type).HasColumnName("monitoring_type");
            this.Property(t => t.resulting_actions).HasColumnName("resulting_actions");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.tracking_number).HasColumnName("tracking_number");
            this.Property(t => t.medical_monitoring_id).HasColumnName("medical_monitoring_id");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.date_actual).HasColumnName("date_actual");

            // Relationships
            this.HasOptional(t => t.ehs_incidents)
                .WithMany(t => t.ehs_medical_mon_results)
                .HasForeignKey(d => d.incident_id);
            this.HasRequired(t => t.em)
                .WithMany(t => t.EhsMedicalMonResults)
                .HasForeignKey(d => d.em_id);
            this.HasRequired(t => t.ehs_medical_monitoring)
                .WithMany(t => t.ehs_medical_mon_results)
                .HasForeignKey(d => d.medical_monitoring_id);

        }
    }
}
