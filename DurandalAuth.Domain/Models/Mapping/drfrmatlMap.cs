using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class drfrmatlMap : EntityTypeConfiguration<drfrmatl>
    {
        public drfrmatlMap()
        {
            // Primary Key
            this.HasKey(t => t.fr_matl);

            // Properties
            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.fr_matl)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("drfrmatl", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.fr_matl).HasColumnName("fr_matl");
        }
    }
}
