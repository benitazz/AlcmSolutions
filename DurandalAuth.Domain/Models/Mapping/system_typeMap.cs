using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class system_typeMap : EntityTypeConfiguration<system_type>
    {
        public system_typeMap()
        {
            // Primary Key
            this.HasKey(t => t.system_type1);

            // Properties
            this.Property(t => t.system_cat)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.system_type1)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("system_type", "afm");
            this.Property(t => t.system_cat).HasColumnName("system_cat");
            this.Property(t => t.system_type1).HasColumnName("system_type");
        }
    }
}
