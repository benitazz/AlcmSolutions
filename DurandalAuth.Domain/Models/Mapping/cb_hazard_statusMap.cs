using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class cb_hazard_statusMap : EntityTypeConfiguration<cb_hazard_status>
    {
        public cb_hazard_statusMap()
        {
            // Primary Key
            this.HasKey(t => t.hcm_haz_status_id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(512);

            this.Property(t => t.name)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.prob_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.hcm_haz_status_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("cb_hazard_status", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.prob_type).HasColumnName("prob_type");
            this.Property(t => t.hcm_haz_status_id).HasColumnName("hcm_haz_status_id");

            // Relationships
            this.HasOptional(t => t.probtype)
                .WithMany(t => t.cb_hazard_status)
                .HasForeignKey(d => d.prob_type);

        }
    }
}
