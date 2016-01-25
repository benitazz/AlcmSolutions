using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class waste_facilitiesMap : EntityTypeConfiguration<waste_facilities>
    {
        public waste_facilitiesMap()
        {
            // Primary Key
            this.HasKey(t => t.facility_id);

            // Properties
            this.Property(t => t.address1)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.address2)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.city_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.contact_name)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.ctry_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.email)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.facility_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.facility_number)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.fax)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.notes)
                .HasMaxLength(1000);

            this.Property(t => t.phone)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.state_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.title)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.vn_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.zip)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.facility_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("waste_facilities", "afm");
            this.Property(t => t.address1).HasColumnName("address1");
            this.Property(t => t.address2).HasColumnName("address2");
            this.Property(t => t.city_id).HasColumnName("city_id");
            this.Property(t => t.contact_name).HasColumnName("contact_name");
            this.Property(t => t.ctry_id).HasColumnName("ctry_id");
            this.Property(t => t.disposal).HasColumnName("disposal");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.facility_name).HasColumnName("facility_name");
            this.Property(t => t.facility_number).HasColumnName("facility_number");
            this.Property(t => t.fax).HasColumnName("fax");
            this.Property(t => t.notes).HasColumnName("notes");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.recycle).HasColumnName("recycle");
            this.Property(t => t.state_id).HasColumnName("state_id");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.treatment).HasColumnName("treatment");
            this.Property(t => t.vn_id).HasColumnName("vn_id");
            this.Property(t => t.zip).HasColumnName("zip");
            this.Property(t => t.facility_id).HasColumnName("facility_id");

            // Relationships
            this.HasOptional(t => t.city)
                .WithMany(t => t.WasteFacilities)
                .HasForeignKey(d => new { d.state_id, d.city_id });
            this.HasOptional(t => t.ctry)
                .WithMany(t => t.waste_facilities)
                .HasForeignKey(d => d.ctry_id);
            this.HasOptional(t => t.state)
                .WithMany(t => t.waste_facilities)
                .HasForeignKey(d => d.state_id);
            this.HasRequired(t => t.vn)
                .WithMany(t => t.waste_facilities)
                .HasForeignKey(d => d.vn_id);

        }
    }
}
