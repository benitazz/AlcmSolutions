using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class advisoryMap : EntityTypeConfiguration<advisory>
    {
        public advisoryMap()
        {
            // Primary Key
            this.HasKey(t => t.advisory_id);

            // Properties
            this.Property(t => t.bulletin)
                .HasMaxLength(4000);

            this.Property(t => t.advisory_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("advisory", "afm");
            this.Property(t => t.bulletin).HasColumnName("bulletin");
            this.Property(t => t.advisory_id).HasColumnName("advisory_id");
        }
    }
}
