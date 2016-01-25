using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class regviolationMap : EntityTypeConfiguration<regviolation>
    {
        public regviolationMap()
        {
            // Primary Key
            this.HasKey(t => t.violation_num);

            // Properties
            this.Property(t => t.authority)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.doc)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.issued_by)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.penalty)
                .HasMaxLength(1000);

            this.Property(t => t.reg_program)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.reg_requirement)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.regulation)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.summary)
                .HasMaxLength(128);

            this.Property(t => t.violation_id)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.violation_type)
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("regviolation", "afm");
            this.Property(t => t.authority).HasColumnName("authority");
            this.Property(t => t.cost_total).HasColumnName("cost_total");
            this.Property(t => t.date_assessed).HasColumnName("date_assessed");
            this.Property(t => t.date_from).HasColumnName("date_from");
            this.Property(t => t.date_to).HasColumnName("date_to");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.doc).HasColumnName("doc");
            this.Property(t => t.issued_by).HasColumnName("issued_by");
            this.Property(t => t.location_id).HasColumnName("location_id");
            this.Property(t => t.penalty).HasColumnName("penalty");
            this.Property(t => t.reg_program).HasColumnName("reg_program");
            this.Property(t => t.reg_requirement).HasColumnName("reg_requirement");
            this.Property(t => t.regulation).HasColumnName("regulation");
            this.Property(t => t.severity).HasColumnName("severity");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.summary).HasColumnName("summary");
            this.Property(t => t.violation_id).HasColumnName("violation_id");
            this.Property(t => t.violation_type).HasColumnName("violation_type");
            this.Property(t => t.violation_num).HasColumnName("violation_num");

            // Relationships
            this.HasOptional(t => t.company)
                .WithMany(t => t.Regviolations)
                .HasForeignKey(d => d.authority);
            this.HasOptional(t => t.compliance_locations)
                .WithMany(t => t.regviolations)
                .HasForeignKey(d => d.location_id);
            this.HasOptional(t => t.regprogram)
                .WithMany(t => t.regviolations)
                .HasForeignKey(d => new { d.regulation, d.reg_program });
            this.HasOptional(t => t.regrequirement)
                .WithMany(t => t.regviolations)
                .HasForeignKey(d => new { d.regulation, d.reg_program, d.reg_requirement });
            this.HasOptional(t => t.regulation1)
                .WithMany(t => t.regviolations)
                .HasForeignKey(d => d.regulation);
            this.HasOptional(t => t.regviolationtyp)
                .WithMany(t => t.regviolations)
                .HasForeignKey(d => d.violation_type);

        }
    }
}
