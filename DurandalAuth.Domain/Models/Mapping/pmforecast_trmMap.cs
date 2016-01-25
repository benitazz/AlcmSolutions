using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class pmforecast_trmMap : EntityTypeConfiguration<pmforecast_trm>
    {
        public pmforecast_trmMap()
        {
            // Primary Key
            this.HasKey(t => t.tr_id);

            // Properties
            this.Property(t => t.tr_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("pmforecast_trm", "afm");
            this.Property(t => t.month_01).HasColumnName("month_01");
            this.Property(t => t.month_02).HasColumnName("month_02");
            this.Property(t => t.month_03).HasColumnName("month_03");
            this.Property(t => t.month_04).HasColumnName("month_04");
            this.Property(t => t.month_05).HasColumnName("month_05");
            this.Property(t => t.month_06).HasColumnName("month_06");
            this.Property(t => t.month_07).HasColumnName("month_07");
            this.Property(t => t.month_08).HasColumnName("month_08");
            this.Property(t => t.month_09).HasColumnName("month_09");
            this.Property(t => t.month_10).HasColumnName("month_10");
            this.Property(t => t.month_11).HasColumnName("month_11");
            this.Property(t => t.month_12).HasColumnName("month_12");
            this.Property(t => t.tr_id).HasColumnName("tr_id");

            // Relationships
            this.HasRequired(t => t.tr)
                .WithOptional(t => t.pmforecast_trm);

        }
    }
}
