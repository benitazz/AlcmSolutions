using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class resavailMap : EntityTypeConfiguration<resavail>
    {
        public resavailMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.cf_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.tool_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.tool_type)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.tr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("resavail", "afm");
            this.Property(t => t.cf_id).HasColumnName("cf_id");
            this.Property(t => t.date_assigned).HasColumnName("date_assigned");
            this.Property(t => t.hours_avail_total).HasColumnName("hours_avail_total");
            this.Property(t => t.hours_commited_total).HasColumnName("hours_commited_total");
            this.Property(t => t.hours_remaining).HasColumnName("hours_remaining");
            this.Property(t => t.od_hours_commited).HasColumnName("od_hours_commited");
            this.Property(t => t.pm_hours_commited).HasColumnName("pm_hours_commited");
            this.Property(t => t.tool_id).HasColumnName("tool_id");
            this.Property(t => t.tool_type).HasColumnName("tool_type");
            this.Property(t => t.tr_id).HasColumnName("tr_id");
            this.Property(t => t.auto_number).HasColumnName("auto_number");
        }
    }
}
