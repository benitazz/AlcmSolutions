using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class drmatlMap : EntityTypeConfiguration<drmatl>
    {
        public drmatlMap()
        {
            // Primary Key
            this.HasKey(t => t.dr_matl);

            // Properties
            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.dr_matl)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("drmatl", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.dr_matl).HasColumnName("dr_matl");
        }
    }
}
