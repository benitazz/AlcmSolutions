using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class hist_em_countMap : EntityTypeConfiguration<hist_em_count>
    {
        public hist_em_countMap()
        {
            // Primary Key
            this.HasKey(t => new { t.bl_id, t.dv_id, t.dp_id, t.year, t.month });

            // Properties
            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.dv_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dp_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.year)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.month)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("hist_em_count", "afm");
            this.Property(t => t.count_em).HasColumnName("count_em");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.year).HasColumnName("year");
            this.Property(t => t.month).HasColumnName("month");
        }
    }
}
