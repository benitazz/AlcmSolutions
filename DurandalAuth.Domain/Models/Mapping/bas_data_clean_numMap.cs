using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class bas_data_clean_numMap : EntityTypeConfiguration<bas_data_clean_num>
    {
        public bas_data_clean_numMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.process_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("bas_data_clean_num", "afm");
            this.Property(t => t.data_point_id).HasColumnName("data_point_id");
            this.Property(t => t.date_measured).HasColumnName("date_measured");
            this.Property(t => t.delta).HasColumnName("delta");
            this.Property(t => t.process_status).HasColumnName("process_status");
            this.Property(t => t.time_measured).HasColumnName("time_measured");
            this.Property(t => t.value_reported).HasColumnName("value_reported");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasRequired(t => t.bas_data_point)
                .WithMany(t => t.bas_data_clean_num)
                .HasForeignKey(d => d.data_point_id);

        }
    }
}
