using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class facility_typeMap : EntityTypeConfiguration<facility_type>
    {
        public facility_typeMap()
        {
            // Primary Key
            this.HasKey(t => t.facility_type_id);

            // Properties
            this.Property(t => t.facility_type_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("facility_type", "afm");
            this.Property(t => t.facility_type_id).HasColumnName("facility_type_id");
        }
    }
}
