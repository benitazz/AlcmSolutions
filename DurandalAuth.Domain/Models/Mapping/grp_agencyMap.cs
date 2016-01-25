using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class grp_agencyMap : EntityTypeConfiguration<grp_agency>
    {
        public grp_agencyMap()
        {
            // Primary Key
            this.HasKey(t => t.grp_agency_id);

            // Properties
            this.Property(t => t.abbreviation_title)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.title)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(100);

            this.Property(t => t.grp_agency_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("grp_agency", "afm");
            this.Property(t => t.abbreviation_title).HasColumnName("abbreviation_title");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.grp_agency_id).HasColumnName("grp_agency_id");
        }
    }
}
