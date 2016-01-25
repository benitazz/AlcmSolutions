using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class fundingMap : EntityTypeConfiguration<funding>
    {
        public fundingMap()
        {
            // Primary Key
            this.HasKey(t => t.fund_id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(4000);

            this.Property(t => t.fund_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.program_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.source_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.fund_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("funding", "afm");
            this.Property(t => t.amt_total).HasColumnName("amt_total");
            this.Property(t => t.date_avail).HasColumnName("date_avail");
            this.Property(t => t.date_avail_end).HasColumnName("date_avail_end");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.fund_type).HasColumnName("fund_type");
            this.Property(t => t.program_id).HasColumnName("program_id");
            this.Property(t => t.source_type).HasColumnName("source_type");
            this.Property(t => t.fund_id).HasColumnName("fund_id");

            // Relationships
            this.HasOptional(t => t.program)
                .WithMany(t => t.fundings)
                .HasForeignKey(d => d.program_id);

        }
    }
}
