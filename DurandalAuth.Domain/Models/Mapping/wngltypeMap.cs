using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class wngltypeMap : EntityTypeConfiguration<wngltype>
    {
        public wngltypeMap()
        {
            // Primary Key
            this.HasKey(t => t.gl_type);

            // Properties
            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.gl_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("wngltype", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.gl_type).HasColumnName("gl_type");
        }
    }
}
