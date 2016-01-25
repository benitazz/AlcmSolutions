using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ehs_training_resultsMap : EntityTypeConfiguration<ehs_training_results>
    {
        public ehs_training_resultsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.training_id, t.em_id, t.date_actual });

            // Properties
            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(7);

            this.Property(t => t.description)
                .HasMaxLength(500);

            this.Property(t => t.doc)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.training_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.em_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(35);

            // Table & Column Mappings
            this.ToTable("ehs_training_results", "afm");
            this.Property(t => t.hours_training).HasColumnName("hours_training");
            this.Property(t => t.incident_id).HasColumnName("incident_id");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.doc).HasColumnName("doc");
            this.Property(t => t.training_id).HasColumnName("training_id");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.date_actual).HasColumnName("date_actual");

            // Relationships
            this.HasOptional(t => t.ehs_incidents)
                .WithMany(t => t.ehs_training_results)
                .HasForeignKey(d => d.incident_id);
            this.HasRequired(t => t.ehs_training)
                .WithMany(t => t.ehs_training_results)
                .HasForeignKey(d => d.training_id);
            this.HasRequired(t => t.em)
                .WithMany(t => t.EhsTrainingResults)
                .HasForeignKey(d => d.em_id);

        }
    }
}
