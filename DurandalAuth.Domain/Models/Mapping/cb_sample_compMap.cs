using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class cb_sample_compMap : EntityTypeConfiguration<cb_sample_comp>
    {
        public cb_sample_compMap()
        {
            // Primary Key
            this.HasKey(t => t.sample_comp_id);

            // Properties
            this.Property(t => t.cas_num)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.description)
                .HasMaxLength(512);

            this.Property(t => t.name)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.prob_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.sample_comp_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("cb_sample_comp", "afm");
            this.Property(t => t.cas_num).HasColumnName("cas_num");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.is_hazard).HasColumnName("is_hazard");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.prob_type).HasColumnName("prob_type");
            this.Property(t => t.sample_comp_id).HasColumnName("sample_comp_id");

            // Relationships
            this.HasOptional(t => t.probtype)
                .WithMany(t => t.cb_sample_comp)
                .HasForeignKey(d => d.prob_type);

        }
    }
}
