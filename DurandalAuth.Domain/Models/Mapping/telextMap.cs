using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class telextMap : EntityTypeConfiguration<telext>
    {
        public telextMap()
        {
            // Primary Key
            this.HasKey(t => t.telext_id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(500);

            this.Property(t => t.extension)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.phone)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.telext_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("telext", "afm");
            this.Property(t => t.date_inserted).HasColumnName("date_inserted");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.extension).HasColumnName("extension");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.telext_id).HasColumnName("telext_id");
        }
    }
}
