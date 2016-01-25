using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ehs_incident_witnessMap : EntityTypeConfiguration<ehs_incident_witness>
    {
        public ehs_incident_witnessMap()
        {
            // Primary Key
            this.HasKey(t => t.incident_witness_id);

            // Properties
            this.Property(t => t.contact_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.doc)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.information)
                .IsRequired()
                .HasMaxLength(5000);

            this.Property(t => t.non_em_info)
                .HasMaxLength(500);

            this.Property(t => t.non_em_name)
                .HasMaxLength(60);

            this.Property(t => t.witness_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("ehs_incident_witness", "afm");
            this.Property(t => t.contact_id).HasColumnName("contact_id");
            this.Property(t => t.date_recorded).HasColumnName("date_recorded");
            this.Property(t => t.doc).HasColumnName("doc");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.incident_id).HasColumnName("incident_id");
            this.Property(t => t.information).HasColumnName("information");
            this.Property(t => t.non_em_info).HasColumnName("non_em_info");
            this.Property(t => t.non_em_name).HasColumnName("non_em_name");
            this.Property(t => t.witness_type).HasColumnName("witness_type");
            this.Property(t => t.incident_witness_id).HasColumnName("incident_witness_id");

            // Relationships
            this.HasOptional(t => t.contact)
                .WithMany(t => t.EhsIncidentWitness)
                .HasForeignKey(d => d.contact_id);
            this.HasOptional(t => t.em)
                .WithMany(t => t.EhsIncidentWitness)
                .HasForeignKey(d => d.em_id);
            this.HasRequired(t => t.ehs_incidents)
                .WithMany(t => t.ehs_incident_witness)
                .HasForeignKey(d => d.incident_id);

        }
    }
}
