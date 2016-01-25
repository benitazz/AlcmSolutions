using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_metric_gran_defsMap : EntityTypeConfiguration<afm_metric_gran_defs>
    {
        public afm_metric_gran_defsMap()
        {
            // Primary Key
            this.HasKey(t => t.collect_group_by);

            // Properties
            this.Property(t => t.fields_required)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.granularity_title)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.collect_group_by)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("afm_metric_gran_defs", "afm");
            this.Property(t => t.fields_present).HasColumnName("fields_present");
            this.Property(t => t.fields_required).HasColumnName("fields_required");
            this.Property(t => t.granularity_title).HasColumnName("granularity_title");
            this.Property(t => t.collect_group_by).HasColumnName("collect_group_by");
        }
    }
}
