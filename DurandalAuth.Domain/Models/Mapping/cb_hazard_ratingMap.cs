using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class cb_hazard_ratingMap : EntityTypeConfiguration<cb_hazard_rating>
    {
        public cb_hazard_ratingMap()
        {
            // Primary Key
            this.HasKey(t => t.hcm_haz_rating_id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(512);

            this.Property(t => t.name)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.prob_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.hcm_haz_rating_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("cb_hazard_rating", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.prob_type).HasColumnName("prob_type");
            this.Property(t => t.hcm_haz_rating_id).HasColumnName("hcm_haz_rating_id");

            // Relationships
            this.HasOptional(t => t.probtype)
                .WithMany(t => t.cb_hazard_rating)
                .HasForeignKey(d => d.prob_type);

        }
    }
}
