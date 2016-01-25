using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_titlesheetMap : EntityTypeConfiguration<afm_titlesheet>
    {
        public afm_titlesheetMap()
        {
            // Primary Key
            this.HasKey(t => t.format_name);

            // Properties
            this.Property(t => t.title_block)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.units_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(256);

            this.Property(t => t.format_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("afm_titlesheet", "afm");
            this.Property(t => t.margin_bottom).HasColumnName("margin_bottom");
            this.Property(t => t.margin_left).HasColumnName("margin_left");
            this.Property(t => t.margin_right).HasColumnName("margin_right");
            this.Property(t => t.margin_top).HasColumnName("margin_top");
            this.Property(t => t.sheet_height).HasColumnName("sheet_height");
            this.Property(t => t.sheet_width).HasColumnName("sheet_width");
            this.Property(t => t.sort_order).HasColumnName("sort_order");
            this.Property(t => t.title_block).HasColumnName("title_block");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.units_type).HasColumnName("units_type");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.format_name).HasColumnName("format_name");
        }
    }
}
