using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_metric_scard_defsMap : EntityTypeConfiguration<afm_metric_scard_defs>
    {
        public afm_metric_scard_defsMap()
        {
            // Primary Key
            this.HasKey(t => t.scorecard_code);

            // Properties
            this.Property(t => t.scorecard_title)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.scorecard_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("afm_metric_scard_defs", "afm");
            this.Property(t => t.scorecard_title).HasColumnName("scorecard_title");
            this.Property(t => t.scorecard_code).HasColumnName("scorecard_code");
        }
    }
}
