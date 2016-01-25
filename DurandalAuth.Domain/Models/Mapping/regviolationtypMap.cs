using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class regviolationtypMap : EntityTypeConfiguration<regviolationtyp>
    {
        public regviolationtypMap()
        {
            // Primary Key
            this.HasKey(t => t.violation_type);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.summary)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.violation_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("regviolationtyp", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.summary).HasColumnName("summary");
            this.Property(t => t.violation_type).HasColumnName("violation_type");
        }
    }
}
