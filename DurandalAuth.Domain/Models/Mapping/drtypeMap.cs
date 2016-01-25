using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class drtypeMap : EntityTypeConfiguration<drtype>
    {
        public drtypeMap()
        {
            // Primary Key
            this.HasKey(t => t.dr_type);

            // Properties
            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.dr_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("drtype", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.dr_type).HasColumnName("dr_type");
        }
    }
}
