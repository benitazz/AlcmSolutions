using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class msds_h_constituentMap : EntityTypeConfiguration<msds_h_constituent>
    {
        public msds_h_constituentMap()
        {
            // Primary Key
            this.HasKey(t => new { t.msds_id, t.chemical_id, t.date_archived, t.time_archived });

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
            this.ToTable("msds_h_constituent", "afm");
            this.Property(t => t.pct_high).HasColumnName("pct_high");
            this.Property(t => t.pct_low).HasColumnName("pct_low");
            this.Property(t => t.pct_operator).HasColumnName("pct_operator");
            this.Property(t => t.msds_id).HasColumnName("msds_id");
            this.Property(t => t.chemical_id).HasColumnName("chemical_id");
            this.Property(t => t.date_archived).HasColumnName("date_archived");
            this.Property(t => t.time_archived).HasColumnName("time_archived");
        }
    }
}
