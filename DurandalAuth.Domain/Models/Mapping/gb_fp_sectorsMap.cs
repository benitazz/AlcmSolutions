using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class gb_fp_sectorsMap : EntityTypeConfiguration<gb_fp_sectors>
    {
        public gb_fp_sectorsMap()
        {
            // Primary Key
            this.HasKey(t => t.sector_name);

            // Properties
            this.Property(t => t.sector_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("gb_fp_sectors", "afm");
            this.Property(t => t.sector_name).HasColumnName("sector_name");
        }
    }
}
