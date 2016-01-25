using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ehs_incident_long_tm_caMap : EntityTypeConfiguration<ehs_incident_long_tm_ca>
    {
        public ehs_incident_long_tm_caMap()
        {
            // Primary Key
            this.HasKey(t => t.long_term_ca);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(256);

            this.Property(t => t.long_term_ca)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ehs_incident_long_tm_ca", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.long_term_ca).HasColumnName("long_term_ca");
        }
    }
}
