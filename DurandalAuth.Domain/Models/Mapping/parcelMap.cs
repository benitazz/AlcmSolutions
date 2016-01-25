using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class parcelMap : EntityTypeConfiguration<parcel>
    {
        public parcelMap()
        {
            // Primary Key
            this.HasKey(t => new { t.pr_id, t.parcel_id });

            // Properties
            this.Property(t => t.block)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.dwgname)
                .HasMaxLength(128);

            this.Property(t => t.ehandle)
                .HasMaxLength(64);

            this.Property(t => t.image_file)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.location)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.lot)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.name)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.pr_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.parcel_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("parcel", "afm");
            this.Property(t => t.area_cad).HasColumnName("area_cad");
            this.Property(t => t.block).HasColumnName("block");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.dwgname).HasColumnName("dwgname");
            this.Property(t => t.ehandle).HasColumnName("ehandle");
            this.Property(t => t.geo_objectid).HasColumnName("geo_objectid");
            this.Property(t => t.image_file).HasColumnName("image_file");
            this.Property(t => t.lat).HasColumnName("lat");
            this.Property(t => t.location).HasColumnName("location");
            this.Property(t => t.lon).HasColumnName("lon");
            this.Property(t => t.lot).HasColumnName("lot");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.pr_id).HasColumnName("pr_id");
            this.Property(t => t.parcel_id).HasColumnName("parcel_id");

            // Relationships
            this.HasRequired(t => t.property)
                .WithMany(t => t.parcels)
                .HasForeignKey(d => d.pr_id);

        }
    }
}
