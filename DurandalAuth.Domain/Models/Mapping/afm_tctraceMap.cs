using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_tctraceMap : EntityTypeConfiguration<afm_tctrace>
    {
        public afm_tctraceMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.branch_level)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.detailed_memo)
                .HasMaxLength(2000);

            this.Property(t => t.source_key)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.source_table)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.summary_memo)
                .HasMaxLength(2000);

            this.Property(t => t.trace_direction)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.trace_level)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("afm_tctrace", "afm");
            this.Property(t => t.branch_level).HasColumnName("branch_level");
            this.Property(t => t.detailed_memo).HasColumnName("detailed_memo");
            this.Property(t => t.source_key).HasColumnName("source_key");
            this.Property(t => t.source_table).HasColumnName("source_table");
            this.Property(t => t.summary_memo).HasColumnName("summary_memo");
            this.Property(t => t.trace_direction).HasColumnName("trace_direction");
            this.Property(t => t.trace_level).HasColumnName("trace_level");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.auto_number).HasColumnName("auto_number");
        }
    }
}
