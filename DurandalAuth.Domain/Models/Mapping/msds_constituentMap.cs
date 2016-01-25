using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class msds_constituentMap : EntityTypeConfiguration<msds_constituent>
    {
        public msds_constituentMap()
        {
            // Primary Key
            this.HasKey(t => new { t.msds_id, t.chemical_id });

            // Properties
            this.Property(t => t.pct_operator)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.msds_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.chemical_id)
                .IsRequired()
                .HasMaxLength(160);

            // Table & Column Mappings
            this.ToTable("msds_constituent", "afm");
            this.Property(t => t.pct_high).HasColumnName("pct_high");
            this.Property(t => t.pct_low).HasColumnName("pct_low");
            this.Property(t => t.pct_operator).HasColumnName("pct_operator");
            this.Property(t => t.msds_id).HasColumnName("msds_id");
            this.Property(t => t.chemical_id).HasColumnName("chemical_id");

            // Relationships
            this.HasRequired(t => t.msds_chemical)
                .WithMany(t => t.msds_constituent)
                .HasForeignKey(d => d.chemical_id);
            this.HasRequired(t => t.msds_data)
                .WithMany(t => t.msds_constituent)
                .HasForeignKey(d => d.msds_id);

        }
    }
}
