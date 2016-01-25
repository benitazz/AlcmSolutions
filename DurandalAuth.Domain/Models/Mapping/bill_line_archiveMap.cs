using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class bill_line_archiveMap : EntityTypeConfiguration<bill_line_archive>
    {
        public bill_line_archiveMap()
        {
            // Primary Key
            this.HasKey(t => new { t.vn_id, t.bill_id, t.bill_line_id });

            // Properties
            this.Property(t => t.bill_type_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.bill_unit_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.description)
                .HasMaxLength(5000);

            this.Property(t => t.vn_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.bill_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.bill_line_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("bill_line_archive", "afm");
            this.Property(t => t.bill_type_id).HasColumnName("bill_type_id");
            this.Property(t => t.bill_unit_id).HasColumnName("bill_unit_id");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.qty).HasColumnName("qty");
            this.Property(t => t.qty_energy).HasColumnName("qty_energy");
            this.Property(t => t.qty_power).HasColumnName("qty_power");
            this.Property(t => t.qty_volume).HasColumnName("qty_volume");
            this.Property(t => t.amount_expense).HasColumnName("amount_expense");
            this.Property(t => t.amount_income).HasColumnName("amount_income");
            this.Property(t => t.vn_id).HasColumnName("vn_id");
            this.Property(t => t.bill_id).HasColumnName("bill_id");
            this.Property(t => t.bill_line_id).HasColumnName("bill_line_id");
        }
    }
}
