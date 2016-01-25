using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class causetypMap : EntityTypeConfiguration<causetyp>
    {
        public causetypMap()
        {
            // Primary Key
            this.HasKey(t => t.cause_type);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(100);

            this.Property(t => t.cause_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("causetyp", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.cause_type).HasColumnName("cause_type");
        }
    }
}
