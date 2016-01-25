#region

using System.Data.Entity.ModelConfiguration;

#endregion

namespace DurandalAuth.Domain.Models.Mapping
{
    /// <summary>
    /// The profile map.
    /// </summary>
    public class ProfileMap : EntityTypeConfiguration<Profile>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileMap"/> class.
        /// </summary>
        public ProfileMap()
        {
            // Primary Key
            this.HasKey(t => t.ProfileId);

            // Properties
            this.Property(t => t.UserId).HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("Profiles");
            this.Property(t => t.ProfileId).HasColumnName("ProfileId");
            this.Property(t => t.AddressId).HasColumnName("AddressId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.ContanctId).HasColumnName("ContanctId");
            this.Property(t => t.EntityTypeId).HasColumnName("EntityTypeId");
            this.Property(t => t.IndividualId).HasColumnName("IndividualId");
            this.Property(t => t.CompanyId).HasColumnName("CompanyId");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");

            // Relationships
            this.HasOptional(t => t.Address).WithMany(t => t.Profiles).HasForeignKey(d => d.AddressId);
            this.HasOptional(t => t.AspNetUser).WithMany(t => t.Profiles).HasForeignKey(d => d.UserId);
            this.HasOptional(t => t.Company).WithMany(t => t.Profiles).HasForeignKey(d => d.CompanyId);
            this.HasOptional(t => t.Contact).WithMany(t => t.Profiles).HasForeignKey(d => d.ContanctId);
            this.HasOptional(t => t.EntityTypeLookup).WithMany(t => t.Profiles).HasForeignKey(d => d.EntityTypeId);
            this.HasOptional(t => t.Individual).WithMany(t => t.Profiles).HasForeignKey(d => d.IndividualId);
        }
    }
}