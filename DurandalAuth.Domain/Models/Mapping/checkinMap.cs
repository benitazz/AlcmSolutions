using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class checkinMap : EntityTypeConfiguration<checkin>
    {
        public checkinMap()
        {
            // Primary Key
            this.HasKey(t => new { t.po_id, t.po_line_id, t.ta_id });

            // Properties
            this.Property(t => t.asset_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.serial_number)
                .HasMaxLength(20);

            this.Property(t => t.po_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.po_line_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ta_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("checkin", "afm");
            this.Property(t => t.asset_type).HasColumnName("asset_type");
            this.Property(t => t.date_received).HasColumnName("date_received");
            this.Property(t => t.serial_number).HasColumnName("serial_number");
            this.Property(t => t.po_id).HasColumnName("po_id");
            this.Property(t => t.po_line_id).HasColumnName("po_line_id");
            this.Property(t => t.ta_id).HasColumnName("ta_id");

            // Relationships
            this.HasRequired(t => t.po)
                .WithMany(t => t.checkins)
                .HasForeignKey(d => d.po_id);
            this.HasRequired(t => t.po_line)
                .WithMany(t => t.checkins)
                .HasForeignKey(d => new { d.po_id, d.po_line_id });

        }
    }
}
