using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ehs_medical_monitoringMap : EntityTypeConfiguration<ehs_medical_monitoring>
    {
        public ehs_medical_monitoringMap()
        {
            // Primary Key
            this.HasKey(t => t.medical_monitoring_id);

            // Properties
            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.monitoring_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(17);

            this.Property(t => t.recurring_rule)
                .HasMaxLength(5000);

            this.Property(t => t.reg_program)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.reg_requirement)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.regulation)
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("ehs_medical_monitoring", "afm");
            this.Property(t => t.date_recurrence_end).HasColumnName("date_recurrence_end");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.is_recurring).HasColumnName("is_recurring");
            this.Property(t => t.monitoring_type).HasColumnName("monitoring_type");
            this.Property(t => t.recurring_rule).HasColumnName("recurring_rule");
            this.Property(t => t.reg_program).HasColumnName("reg_program");
            this.Property(t => t.reg_requirement).HasColumnName("reg_requirement");
            this.Property(t => t.regulation).HasColumnName("regulation");
            this.Property(t => t.medical_monitoring_id).HasColumnName("medical_monitoring_id");

            // Relationships
            this.HasMany(t => t.work_categories)
                .WithMany(t => t.ehs_medical_monitoring)
                .Map(m =>
                    {
                        m.ToTable("ehs_work_cat_med_mon", "afm");
                        m.MapLeftKey("medical_monitoring_id");
                        m.MapRightKey("work_category_id");
                    });

            this.HasOptional(t => t.regprogram)
                .WithMany(t => t.ehs_medical_monitoring)
                .HasForeignKey(d => new { d.regulation, d.reg_program });
            this.HasOptional(t => t.regrequirement)
                .WithMany(t => t.ehs_medical_monitoring)
                .HasForeignKey(d => new { d.regulation, d.reg_program, d.reg_requirement });
            this.HasOptional(t => t.regulation1)
                .WithMany(t => t.ehs_medical_monitoring)
                .HasForeignKey(d => d.regulation);

        }
    }
}
