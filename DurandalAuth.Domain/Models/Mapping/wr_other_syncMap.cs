using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class wr_other_syncMap : EntityTypeConfiguration<wr_other_sync>
    {
        public wr_other_syncMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(5000);

            this.Property(t => t.mob_locked_by)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.other_rs_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.units_used)
                .IsFixedLength()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("wr_other_sync", "afm");
            this.Property(t => t.cost_estimated).HasColumnName("cost_estimated");
            this.Property(t => t.cost_total).HasColumnName("cost_total");
            this.Property(t => t.date_used).HasColumnName("date_used");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.mob_is_changed).HasColumnName("mob_is_changed");
            this.Property(t => t.mob_locked_by).HasColumnName("mob_locked_by");
            this.Property(t => t.mob_wr_id).HasColumnName("mob_wr_id");
            this.Property(t => t.other_rs_type).HasColumnName("other_rs_type");
            this.Property(t => t.qty_used).HasColumnName("qty_used");
            this.Property(t => t.units_used).HasColumnName("units_used");
            this.Property(t => t.wr_id).HasColumnName("wr_id");
            this.Property(t => t.auto_number).HasColumnName("auto_number");
        }
    }
}
