using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class catypeMap : EntityTypeConfiguration<catype>
    {
        public catypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ca_type);

            // Properties
            this.Property(t => t.ca_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("catype", "afm");
            this.Property(t => t.ca_type).HasColumnName("ca_type");
        }
    }
}
