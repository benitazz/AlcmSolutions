using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class parkingstdMap : EntityTypeConfiguration<parkingstd>
    {
        public parkingstdMap()
        {
            // Primary Key
            this.HasKey(t => t.parking_std);

            // Properties
            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(256);

            this.Property(t => t.parking_std)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("parkingstd", "afm");
            this.Property(t => t.cost).HasColumnName("cost");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.length).HasColumnName("length");
            this.Property(t => t.width).HasColumnName("width");
            this.Property(t => t.parking_std).HasColumnName("parking_std");
        }
    }
}
