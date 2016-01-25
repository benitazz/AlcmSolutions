using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class cb_hcm_condMap : EntityTypeConfiguration<cb_hcm_cond>
    {
        public cb_hcm_condMap()
        {
            // Primary Key
            this.HasKey(t => t.hcm_cond_id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(512);

            this.Property(t => t.name)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.prob_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.hcm_cond_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("cb_hcm_cond", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.prob_type).HasColumnName("prob_type");
            this.Property(t => t.hcm_cond_id).HasColumnName("hcm_cond_id");

            // Relationships
            this.HasOptional(t => t.probtype)
                .WithMany(t => t.cb_hcm_cond)
                .HasForeignKey(d => d.prob_type);

        }
    }
}
