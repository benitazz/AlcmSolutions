using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class dep_reportsMap : EntityTypeConfiguration<dep_reports>
    {
        public dep_reportsMap()
        {
            // Primary Key
            this.HasKey(t => t.report_id);

            // Properties
            this.Property(t => t.active)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.report_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dep_reports", "afm");
            this.Property(t => t.active).HasColumnName("active");
            this.Property(t => t.last_date).HasColumnName("last_date");
            this.Property(t => t.report_id).HasColumnName("report_id");
        }
    }
}
