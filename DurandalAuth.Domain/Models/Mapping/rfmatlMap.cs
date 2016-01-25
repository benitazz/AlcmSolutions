using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class rfmatlMap : EntityTypeConfiguration<rfmatl>
    {
        public rfmatlMap()
        {
            // Primary Key
            this.HasKey(t => t.rf_matl);

            // Properties
            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.rf_matl)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("rfmatl", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.rf_matl).HasColumnName("rf_matl");
        }
    }
}
