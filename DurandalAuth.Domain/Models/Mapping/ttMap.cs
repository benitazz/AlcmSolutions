using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ttMap : EntityTypeConfiguration<tt>
    {
        public ttMap()
        {
            // Primary Key
            this.HasKey(t => t.tool_type);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(200);

            this.Property(t => t.tool_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("tt", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.out_of_svc_qty).HasColumnName("out_of_svc_qty");
            this.Property(t => t.rate_hourly).HasColumnName("rate_hourly");
            this.Property(t => t.rate_over).HasColumnName("rate_over");
            this.Property(t => t.reserved_qty).HasColumnName("reserved_qty");
            this.Property(t => t.std_hours_avail).HasColumnName("std_hours_avail");
            this.Property(t => t.total_quantity).HasColumnName("total_quantity");
            this.Property(t => t.tool_type).HasColumnName("tool_type");
        }
    }
}
