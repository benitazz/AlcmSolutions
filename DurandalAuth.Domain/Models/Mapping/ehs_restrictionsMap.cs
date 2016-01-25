using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ehs_restrictionsMap : EntityTypeConfiguration<ehs_restrictions>
    {
        public ehs_restrictionsMap()
        {
            // Primary Key
            this.HasKey(t => t.restriction_id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(500);

            this.Property(t => t.doc)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.restriction_category_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.restriction_class)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.restriction_type_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("ehs_restrictions", "afm");
            this.Property(t => t.date_actual).HasColumnName("date_actual");
            this.Property(t => t.date_end).HasColumnName("date_end");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.doc).HasColumnName("doc");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.incident_id).HasColumnName("incident_id");
            this.Property(t => t.lost_work_days).HasColumnName("lost_work_days");
            this.Property(t => t.medical_monitoring_id).HasColumnName("medical_monitoring_id");
            this.Property(t => t.restriction_category_id).HasColumnName("restriction_category_id");
            this.Property(t => t.restriction_class).HasColumnName("restriction_class");
            this.Property(t => t.restriction_type_id).HasColumnName("restriction_type_id");
            this.Property(t => t.restriction_id).HasColumnName("restriction_id");

            // Relationships
            this.HasOptional(t => t.ehs_incidents)
                .WithMany(t => t.ehs_restrictions)
                .HasForeignKey(d => d.incident_id);
            this.HasOptional(t => t.ehs_medical_monitoring)
                .WithMany(t => t.ehs_restrictions)
                .HasForeignKey(d => d.medical_monitoring_id);
            this.HasRequired(t => t.ehs_restriction_cat)
                .WithMany(t => t.ehs_restrictions)
                .HasForeignKey(d => d.restriction_category_id);
            this.HasOptional(t => t.em)
                .WithMany(t => t.EhsRestrictions)
                .HasForeignKey(d => d.em_id);

        }
    }
}
