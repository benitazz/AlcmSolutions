using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class repairtyMap : EntityTypeConfiguration<repairty>
    {
        public repairtyMap()
        {
            // Primary Key
            this.HasKey(t => t.repair_type);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(100);

            this.Property(t => t.repair_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("repairty", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.repair_type).HasColumnName("repair_type");
        }
    }
}
