using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class wytypeMap : EntityTypeConfiguration<wytype>
    {
        public wytypeMap()
        {
            // Primary Key
            this.HasKey(t => t.wy_type);

            // Properties
            this.Property(t => t.wy_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("wytype", "afm");
            this.Property(t => t.wy_type).HasColumnName("wy_type");
        }
    }
}
