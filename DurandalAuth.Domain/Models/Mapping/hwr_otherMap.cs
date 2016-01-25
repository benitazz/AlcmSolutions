using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class hwr_otherMap : EntityTypeConfiguration<hwr_other>
    {
        public hwr_otherMap()
        {
            // Primary Key
            this.HasKey(t => new { t.wr_id, t.date_used, t.other_rs_type });

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(5000);

            this.Property(t => t.units_used)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.wr_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.other_rs_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("hwr_other", "afm");
            this.Property(t => t.cost_estimated).HasColumnName("cost_estimated");
            this.Property(t => t.cost_total).HasColumnName("cost_total");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.qty_used).HasColumnName("qty_used");
            this.Property(t => t.units_used).HasColumnName("units_used");
            this.Property(t => t.wr_id).HasColumnName("wr_id");
            this.Property(t => t.date_used).HasColumnName("date_used");
            this.Property(t => t.other_rs_type).HasColumnName("other_rs_type");

            // Relationships
            this.HasRequired(t => t.hwr)
                .WithMany(t => t.hwr_other)
                .HasForeignKey(d => d.wr_id);

        }
    }
}
