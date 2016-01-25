using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class AddressMap : EntityTypeConfiguration<Address>
    {
        public AddressMap()
        {
            // Primary Key
            this.HasKey(t => t.AddressId);

            // Properties
            this.Property(t => t.PostalCode)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Addresses");
            this.Property(t => t.AddressId).HasColumnName("AddressId");
            this.Property(t => t.AddressTypeId).HasColumnName("AddressTypeId");
            this.Property(t => t.AddressLine1).HasColumnName("AddressLine1");
            this.Property(t => t.AddressLine2).HasColumnName("AddressLine2");
            this.Property(t => t.Suburb).HasColumnName("Suburb");
            this.Property(t => t.ProvinceId).HasColumnName("ProvinceId");
            this.Property(t => t.PostalCode).HasColumnName("PostalCode");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");

            // Relationships
            this.HasRequired(t => t.AddressLookup)
                .WithMany(t => t.Addresses)
                .HasForeignKey(d => d.AddressTypeId);
            this.HasRequired(t => t.ProvinceLookup)
                .WithMany(t => t.Addresses)
                .HasForeignKey(d => d.ProvinceId);

        }
    }
}
