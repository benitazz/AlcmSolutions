using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class rmuseMap : EntityTypeConfiguration<rmuse>
    {
        public rmuseMap()
        {
            // Primary Key
            this.HasKey(t => t.rm_use);

            // Properties
            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.rm_use)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("rmuse", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.rm_use).HasColumnName("rm_use");
        }
    }
}
