using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class other_rsMap : EntityTypeConfiguration<other_rs>
    {
        public other_rsMap()
        {
            // Primary Key
            this.HasKey(t => t.other_rs_type);

            // Properties
            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.other_rs_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("other_rs", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.other_rs_type).HasColumnName("other_rs_type");
        }
    }
}
