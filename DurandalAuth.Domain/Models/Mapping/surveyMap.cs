using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class surveyMap : EntityTypeConfiguration<survey>
    {
        public surveyMap()
        {
            // Primary Key
            this.HasKey(t => t.survey_id);

            // Properties
            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(200);

            this.Property(t => t.em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.report)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.survey_fields)
                .HasMaxLength(512);

            this.Property(t => t.survey_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("survey", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.report).HasColumnName("report");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.survey_date).HasColumnName("survey_date");
            this.Property(t => t.survey_fields).HasColumnName("survey_fields");
            this.Property(t => t.survey_id).HasColumnName("survey_id");

            // Relationships
            this.HasOptional(t => t.em)
                .WithMany(t => t.surveys)
                .HasForeignKey(d => d.em_id);

        }
    }
}
