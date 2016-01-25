using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class tlMap : EntityTypeConfiguration<tl>
    {
        public tlMap()
        {
            // Primary Key
            this.HasKey(t => t.tool_id);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.location)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.tool_type)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.tool_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("tl", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.date_purchased).HasColumnName("date_purchased");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.location).HasColumnName("location");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.std_hours_avail).HasColumnName("std_hours_avail");
            this.Property(t => t.tool_type).HasColumnName("tool_type");
            this.Property(t => t.tool_id).HasColumnName("tool_id");

            // Relationships
            this.HasOptional(t => t.bl)
                .WithMany(t => t.tls)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.Tls)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.rm)
                .WithMany(t => t.tls)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });
            this.HasOptional(t => t.tt)
                .WithMany(t => t.tls)
                .HasForeignKey(d => d.tool_type);

        }
    }
}
