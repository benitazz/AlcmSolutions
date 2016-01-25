using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_cal_datesMap : EntityTypeConfiguration<afm_cal_dates>
    {
        public afm_cal_datesMap()
        {
            // Primary Key
            this.HasKey(t => t.cal_date);

            // Properties
            this.Property(t => t.day_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.description)
                .HasMaxLength(128);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("afm_cal_dates", "afm");
            this.Property(t => t.day_type).HasColumnName("day_type");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.cal_date).HasColumnName("cal_date");
        }
    }
}
