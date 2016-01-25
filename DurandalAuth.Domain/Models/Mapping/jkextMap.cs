using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class jkextMap : EntityTypeConfiguration<jkext>
    {
        public jkextMap()
        {
            // Primary Key
            this.HasKey(t => new { t.jk_id, t.phone, t.extension });

            // Properties
            this.Property(t => t.fp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.jk_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.phone)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.extension)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("jkext", "afm");
            this.Property(t => t.fp_id).HasColumnName("fp_id");
            this.Property(t => t.jk_id).HasColumnName("jk_id");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.extension).HasColumnName("extension");

            // Relationships
            this.HasOptional(t => t.fp)
                .WithMany(t => t.jkexts)
                .HasForeignKey(d => d.fp_id);
            this.HasRequired(t => t.jk)
                .WithMany(t => t.jkexts)
                .HasForeignKey(d => d.jk_id);

        }
    }
}
