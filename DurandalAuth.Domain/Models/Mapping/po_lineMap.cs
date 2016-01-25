using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class po_lineMap : EntityTypeConfiguration<po_line>
    {
        public po_lineMap()
        {
            // Primary Key
            this.HasKey(t => new { t.po_id, t.po_line_id });

            // Properties
            this.Property(t => t.catno)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.description)
                .HasMaxLength(200);

            this.Property(t => t.po_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.po_line_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("po_line", "afm");
            this.Property(t => t.catno).HasColumnName("catno");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.quantity).HasColumnName("quantity");
            this.Property(t => t.unit_cost).HasColumnName("unit_cost");
            this.Property(t => t.po_id).HasColumnName("po_id");
            this.Property(t => t.po_line_id).HasColumnName("po_line_id");

            // Relationships
            this.HasRequired(t => t.po)
                .WithMany(t => t.po_line)
                .HasForeignKey(d => d.po_id);

        }
    }
}
