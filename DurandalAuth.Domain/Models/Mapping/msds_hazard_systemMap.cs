using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class msds_hazard_systemMap : EntityTypeConfiguration<msds_hazard_system>
    {
        public msds_hazard_systemMap()
        {
            // Primary Key
            this.HasKey(t => t.hazard_system_id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.hazard_system_id)
                .IsRequired()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("msds_hazard_system", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.hazard_system_id).HasColumnName("hazard_system_id");
        }
    }
}
