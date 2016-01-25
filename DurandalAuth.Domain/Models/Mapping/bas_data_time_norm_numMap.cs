using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class bas_data_time_norm_numMap : EntityTypeConfiguration<bas_data_time_norm_num>
    {
        public bas_data_time_norm_numMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.interval)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("bas_data_time_norm_num", "afm");
            this.Property(t => t.data_point_id).HasColumnName("data_point_id");
            this.Property(t => t.date_measured).HasColumnName("date_measured");
            this.Property(t => t.delta).HasColumnName("delta");
            this.Property(t => t.interval).HasColumnName("interval");
            this.Property(t => t.time_measured).HasColumnName("time_measured");
            this.Property(t => t.value_common).HasColumnName("value_common");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasRequired(t => t.bas_data_point)
                .WithMany(t => t.bas_data_time_norm_num)
                .HasForeignKey(d => d.data_point_id);

        }
    }
}
