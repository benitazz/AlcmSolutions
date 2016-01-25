using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class Contact1Map : EntityTypeConfiguration<Contact1>
    {
        public Contact1Map()
        {
            // Primary Key
            this.HasKey(t => t.ContactId);

            // Properties
            // Table & Column Mappings
            this.ToTable("Contacts");
            this.Property(t => t.ContactId).HasColumnName("ContactId");
            this.Property(t => t.CellPhone).HasColumnName("CellPhone");
            this.Property(t => t.HomePhone).HasColumnName("HomePhone");
            this.Property(t => t.WorkPhone).HasColumnName("WorkPhone");
            this.Property(t => t.FaxNumber).HasColumnName("FaxNumber");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Website).HasColumnName("Website");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");
        }
    }
}
