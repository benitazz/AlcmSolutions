using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ehs_chemicalsMap : EntityTypeConfiguration<ehs_chemicals>
    {
        public ehs_chemicalsMap()
        {
            // Primary Key
            this.HasKey(t => t.chemical_name);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(256);

            this.Property(t => t.chemical_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("ehs_chemicals", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.msds_id).HasColumnName("msds_id");
            this.Property(t => t.chemical_name).HasColumnName("chemical_name");

            // Relationships
            this.HasOptional(t => t.msds_data)
                .WithMany(t => t.ehs_chemicals)
                .HasForeignKey(d => d.msds_id);

        }
    }
}
