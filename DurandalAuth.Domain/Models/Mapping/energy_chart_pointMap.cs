using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class energy_chart_pointMap : EntityTypeConfiguration<energy_chart_point>
    {
        public energy_chart_pointMap()
        {
            // Primary Key
            this.HasKey(t => new { t.bl_id, t.time_period, t.value_name });

            // Properties
            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.time_period)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(7);

            this.Property(t => t.value_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("energy_chart_point", "afm");
            this.Property(t => t.outlier).HasColumnName("outlier");
            this.Property(t => t.value).HasColumnName("value");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.time_period).HasColumnName("time_period");
            this.Property(t => t.value_name).HasColumnName("value_name");

            // Relationships
            this.HasRequired(t => t.bl)
                .WithMany(t => t.energy_chart_point)
                .HasForeignKey(d => d.bl_id);
            this.HasRequired(t => t.energy_time_period)
                .WithMany(t => t.energy_chart_point)
                .HasForeignKey(d => d.time_period);

        }
    }
}
