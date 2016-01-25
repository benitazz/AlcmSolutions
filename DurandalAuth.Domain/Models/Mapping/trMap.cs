using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class trMap : EntityTypeConfiguration<tr>
    {
        public trMap()
        {
            // Primary Key
            this.HasKey(t => t.tr_id);

            // Properties
            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.issue_work_in_format)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.issue_work_to)
                .IsFixedLength()
                .HasMaxLength(255);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.tr_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("tr", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.issue_work_in_format).HasColumnName("issue_work_in_format");
            this.Property(t => t.issue_work_to).HasColumnName("issue_work_to");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.rate_double).HasColumnName("rate_double");
            this.Property(t => t.rate_hourly).HasColumnName("rate_hourly");
            this.Property(t => t.rate_over).HasColumnName("rate_over");
            this.Property(t => t.std_hours_avail).HasColumnName("std_hours_avail");
            this.Property(t => t.wr_from_reserve).HasColumnName("wr_from_reserve");
            this.Property(t => t.tr_id).HasColumnName("tr_id");
        }
    }
}
