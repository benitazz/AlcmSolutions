using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ehs_incident_witness_syncMap : EntityTypeConfiguration<ehs_incident_witness_sync>
    {
        public ehs_incident_witness_syncMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.contact_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.information)
                .IsRequired()
                .HasMaxLength(5000);

            this.Property(t => t.mob_locked_by)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.non_em_info)
                .HasMaxLength(500);

            this.Property(t => t.non_em_name)
                .HasMaxLength(60);

            this.Property(t => t.witness_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("ehs_incident_witness_sync", "afm");
            this.Property(t => t.contact_id).HasColumnName("contact_id");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.information).HasColumnName("information");
            this.Property(t => t.mob_incident_id).HasColumnName("mob_incident_id");
            this.Property(t => t.mob_is_changed).HasColumnName("mob_is_changed");
            this.Property(t => t.mob_locked_by).HasColumnName("mob_locked_by");
            this.Property(t => t.non_em_info).HasColumnName("non_em_info");
            this.Property(t => t.non_em_name).HasColumnName("non_em_name");
            this.Property(t => t.witness_type).HasColumnName("witness_type");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasOptional(t => t.contact)
                .WithMany(t => t.EhsIncidentWitnessSync)
                .HasForeignKey(d => d.contact_id);
            this.HasOptional(t => t.em)
                .WithMany(t => t.EhsIncidentWitnessSync)
                .HasForeignKey(d => d.em_id);

        }
    }
}
