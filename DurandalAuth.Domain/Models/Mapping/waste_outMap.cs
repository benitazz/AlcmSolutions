using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class waste_outMap : EntityTypeConfiguration<waste_out>
    {
        public waste_outMap()
        {
            // Primary Key
            this.HasKey(t => t.waste_id);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.contact_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.container_cat)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.container_id)
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.eq_id)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.facility_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.generator_id)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.manifest_number)
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.method_code)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.notes)
                .HasMaxLength(1000);

            this.Property(t => t.pr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.shipment_id)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.site_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.storage_location)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.transporter_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.units)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.units_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.waste_disposition)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.waste_profile)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("waste_out", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.contact_id).HasColumnName("contact_id");
            this.Property(t => t.container_cat).HasColumnName("container_cat");
            this.Property(t => t.container_id).HasColumnName("container_id");
            this.Property(t => t.date_end).HasColumnName("date_end");
            this.Property(t => t.date_shipped).HasColumnName("date_shipped");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.eq_id).HasColumnName("eq_id");
            this.Property(t => t.facility_id).HasColumnName("facility_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.generator_id).HasColumnName("generator_id");
            this.Property(t => t.manifest_number).HasColumnName("manifest_number");
            this.Property(t => t.method_code).HasColumnName("method_code");
            this.Property(t => t.notes).HasColumnName("notes");
            this.Property(t => t.number_containers).HasColumnName("number_containers");
            this.Property(t => t.pr_id).HasColumnName("pr_id");
            this.Property(t => t.quantity).HasColumnName("quantity");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.shipment_id).HasColumnName("shipment_id");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.storage_location).HasColumnName("storage_location");
            this.Property(t => t.time_end).HasColumnName("time_end");
            this.Property(t => t.time_start).HasColumnName("time_start");
            this.Property(t => t.transporter_id).HasColumnName("transporter_id");
            this.Property(t => t.units).HasColumnName("units");
            this.Property(t => t.units_type).HasColumnName("units_type");
            this.Property(t => t.waste_disposition).HasColumnName("waste_disposition");
            this.Property(t => t.waste_profile).HasColumnName("waste_profile");
            this.Property(t => t.waste_id).HasColumnName("waste_id");

            // Relationships
            this.HasRequired(t => t.bill_type)
                .WithMany(t => t.waste_out)
                .HasForeignKey(d => d.units_type);
            this.HasRequired(t => t.bill_unit)
                .WithMany(t => t.waste_out)
                .HasForeignKey(d => new { d.units_type, d.units });
            this.HasOptional(t => t.hazard_container_cat)
                .WithMany(t => t.waste_out)
                .HasForeignKey(d => d.container_cat);
            this.HasOptional(t => t.vn)
                .WithMany(t => t.waste_out)
                .HasForeignKey(d => d.transporter_id);
            this.HasOptional(t => t.waste_areas)
                .WithMany(t => t.waste_out)
                .HasForeignKey(d => d.storage_location);
            this.HasOptional(t => t.waste_dispositions)
                .WithMany(t => t.waste_out)
                .HasForeignKey(d => d.waste_disposition);
            this.HasOptional(t => t.waste_facilities)
                .WithMany(t => t.waste_out)
                .HasForeignKey(d => d.facility_id);
            this.HasOptional(t => t.waste_generators)
                .WithMany(t => t.waste_out)
                .HasForeignKey(d => d.generator_id);
            this.HasOptional(t => t.waste_manifests)
                .WithMany(t => t.waste_out)
                .HasForeignKey(d => d.manifest_number);
            this.HasOptional(t => t.waste_mgmt_methods)
                .WithMany(t => t.waste_out)
                .HasForeignKey(d => d.method_code);
            this.HasRequired(t => t.waste_profiles)
                .WithMany(t => t.waste_out)
                .HasForeignKey(d => d.waste_profile);

        }
    }
}
