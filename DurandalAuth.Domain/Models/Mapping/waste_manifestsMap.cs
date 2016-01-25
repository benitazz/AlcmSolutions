using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class waste_manifestsMap : EntityTypeConfiguration<waste_manifests>
    {
        public waste_manifestsMap()
        {
            // Primary Key
            this.HasKey(t => t.manifest_number);

            // Properties
            this.Property(t => t.doc)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.exception_notes)
                .HasMaxLength(500);

            this.Property(t => t.facility_contact_notes)
                .HasMaxLength(500);

            this.Property(t => t.facility_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.facility_id_alt)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.handling_instructions)
                .HasMaxLength(200);

            this.Property(t => t.international_shipments)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.manifest_reference_num)
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.port)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.sign_alternate_facility)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.sign_facility)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.sign_transporter)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.sign_transporter_2)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.signed_by)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.transporter_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.transporter_id_2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.manifest_number)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("waste_manifests", "afm");
            this.Property(t => t.date_acceptance).HasColumnName("date_acceptance");
            this.Property(t => t.date_alternate_facility).HasColumnName("date_alternate_facility");
            this.Property(t => t.date_country_departure).HasColumnName("date_country_departure");
            this.Property(t => t.date_exception).HasColumnName("date_exception");
            this.Property(t => t.date_facility_contact).HasColumnName("date_facility_contact");
            this.Property(t => t.date_received).HasColumnName("date_received");
            this.Property(t => t.date_shipped).HasColumnName("date_shipped");
            this.Property(t => t.date_shipped_alt).HasColumnName("date_shipped_alt");
            this.Property(t => t.date_transporter).HasColumnName("date_transporter");
            this.Property(t => t.date_transporter_2).HasColumnName("date_transporter_2");
            this.Property(t => t.discrepancy_full_rejection).HasColumnName("discrepancy_full_rejection");
            this.Property(t => t.discrepancy_partial_rejection).HasColumnName("discrepancy_partial_rejection");
            this.Property(t => t.discrepancy_qty).HasColumnName("discrepancy_qty");
            this.Property(t => t.discrepancy_residue).HasColumnName("discrepancy_residue");
            this.Property(t => t.discrepancy_type).HasColumnName("discrepancy_type");
            this.Property(t => t.doc).HasColumnName("doc");
            this.Property(t => t.exception_notes).HasColumnName("exception_notes");
            this.Property(t => t.facility_contact_notes).HasColumnName("facility_contact_notes");
            this.Property(t => t.facility_id).HasColumnName("facility_id");
            this.Property(t => t.facility_id_alt).HasColumnName("facility_id_alt");
            this.Property(t => t.handling_instructions).HasColumnName("handling_instructions");
            this.Property(t => t.international_shipments).HasColumnName("international_shipments");
            this.Property(t => t.manifest_reference_num).HasColumnName("manifest_reference_num");
            this.Property(t => t.port).HasColumnName("port");
            this.Property(t => t.sign_alternate_facility).HasColumnName("sign_alternate_facility");
            this.Property(t => t.sign_facility).HasColumnName("sign_facility");
            this.Property(t => t.sign_transporter).HasColumnName("sign_transporter");
            this.Property(t => t.sign_transporter_2).HasColumnName("sign_transporter_2");
            this.Property(t => t.signed_by).HasColumnName("signed_by");
            this.Property(t => t.transporter_id).HasColumnName("transporter_id");
            this.Property(t => t.transporter_id_2).HasColumnName("transporter_id_2");
            this.Property(t => t.manifest_number).HasColumnName("manifest_number");

            // Relationships
            this.HasOptional(t => t.vn)
                .WithMany(t => t.waste_manifests)
                .HasForeignKey(d => d.transporter_id);
            this.HasOptional(t => t.vn1)
                .WithMany(t => t.waste_manifests1)
                .HasForeignKey(d => d.transporter_id_2);
            this.HasOptional(t => t.waste_facilities)
                .WithMany(t => t.waste_manifests)
                .HasForeignKey(d => d.facility_id);
            this.HasOptional(t => t.waste_facilities1)
                .WithMany(t => t.waste_manifests1)
                .HasForeignKey(d => d.facility_id_alt);

        }
    }
}
