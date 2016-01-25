using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class cb_hcmMap : EntityTypeConfiguration<cb_hcm>
    {
        public cb_hcmMap()
        {
            // Primary Key
            this.HasKey(t => t.hcm_id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(512);

            this.Property(t => t.name)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.prob_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.hcm_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("cb_hcm", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.prob_type).HasColumnName("prob_type");
            this.Property(t => t.hcm_id).HasColumnName("hcm_id");

            // Relationships
            this.HasOptional(t => t.probtype)
                .WithMany(t => t.cb_hcm)
                .HasForeignKey(d => d.prob_type);

        }
    }
}
