using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class commtypeMap : EntityTypeConfiguration<commtype>
    {
        public commtypeMap()
        {
            // Primary Key
            this.HasKey(t => t.comm_type);

            // Properties
            this.Property(t => t.comm_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("commtype", "afm");
            this.Property(t => t.comm_type).HasColumnName("comm_type");
        }
    }
}
