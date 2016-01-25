using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class drfnshMap : EntityTypeConfiguration<drfnsh>
    {
        public drfnshMap()
        {
            // Primary Key
            this.HasKey(t => t.dr_fnsh);

            // Properties
            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.dr_fnsh)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("drfnsh", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.dr_fnsh).HasColumnName("dr_fnsh");
        }
    }
}
