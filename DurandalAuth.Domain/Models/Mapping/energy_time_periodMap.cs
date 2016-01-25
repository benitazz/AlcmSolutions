using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class energy_time_periodMap : EntityTypeConfiguration<energy_time_period>
    {
        public energy_time_periodMap()
        {
            // Primary Key
            this.HasKey(t => t.time_period);

            // Properties
            this.Property(t => t.name)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.time_period)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(7);

            // Table & Column Mappings
            this.ToTable("energy_time_period", "afm");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.period_index).HasColumnName("period_index");
            this.Property(t => t.time_period).HasColumnName("time_period");
        }
    }
}
