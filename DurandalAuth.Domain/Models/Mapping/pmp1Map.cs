using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class pmp1Map : EntityTypeConfiguration<pmp1>
    {
        public pmp1Map()
        {
            // Primary Key
            this.HasKey(t => new { t.pmp_id, t.pmps_id });

            // Properties
            this.Property(t => t.doc)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.instructions)
                .IsRequired()
                .HasMaxLength(5000);

            this.Property(t => t.pmp_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.pmps_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("pmps", "afm");
            this.Property(t => t.doc).HasColumnName("doc");
            this.Property(t => t.instructions).HasColumnName("instructions");
            this.Property(t => t.pmp_id).HasColumnName("pmp_id");
            this.Property(t => t.pmps_id).HasColumnName("pmps_id");

            // Relationships
            this.HasRequired(t => t.pmp)
                .WithMany(t => t.pmps)
                .HasForeignKey(d => d.pmp_id);

        }
    }
}
