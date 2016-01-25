using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class rffnshMap : EntityTypeConfiguration<rffnsh>
    {
        public rffnshMap()
        {
            // Primary Key
            this.HasKey(t => t.rf_fnsh);

            // Properties
            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.surface)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.rf_fnsh)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("rffnsh", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.surface).HasColumnName("surface");
            this.Property(t => t.rf_fnsh).HasColumnName("rf_fnsh");
        }
    }
}
