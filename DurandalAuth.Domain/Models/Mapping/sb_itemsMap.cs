using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class sb_itemsMap : EntityTypeConfiguration<sb_items>
    {
        public sb_itemsMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.bu_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.fg_title)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.p00_expr)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.p01_expr)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.p02_expr)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.p03_expr)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.p04_expr)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.p05_expr)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.p06_expr)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.p07_expr)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.p08_expr)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.p09_expr)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.p10_expr)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.p11_expr)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.p12_expr)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.rm_std)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.sb_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("sb_items", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.bu_id).HasColumnName("bu_id");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.fg_title).HasColumnName("fg_title");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.p00_expr).HasColumnName("p00_expr");
            this.Property(t => t.p00_value).HasColumnName("p00_value");
            this.Property(t => t.p01_expr).HasColumnName("p01_expr");
            this.Property(t => t.p01_value).HasColumnName("p01_value");
            this.Property(t => t.p02_expr).HasColumnName("p02_expr");
            this.Property(t => t.p02_value).HasColumnName("p02_value");
            this.Property(t => t.p03_expr).HasColumnName("p03_expr");
            this.Property(t => t.p03_value).HasColumnName("p03_value");
            this.Property(t => t.p04_expr).HasColumnName("p04_expr");
            this.Property(t => t.p04_value).HasColumnName("p04_value");
            this.Property(t => t.p05_expr).HasColumnName("p05_expr");
            this.Property(t => t.p05_value).HasColumnName("p05_value");
            this.Property(t => t.p06_expr).HasColumnName("p06_expr");
            this.Property(t => t.p06_value).HasColumnName("p06_value");
            this.Property(t => t.p07_expr).HasColumnName("p07_expr");
            this.Property(t => t.p07_value).HasColumnName("p07_value");
            this.Property(t => t.p08_expr).HasColumnName("p08_expr");
            this.Property(t => t.p08_value).HasColumnName("p08_value");
            this.Property(t => t.p09_expr).HasColumnName("p09_expr");
            this.Property(t => t.p09_value).HasColumnName("p09_value");
            this.Property(t => t.p10_expr).HasColumnName("p10_expr");
            this.Property(t => t.p10_value).HasColumnName("p10_value");
            this.Property(t => t.p11_expr).HasColumnName("p11_expr");
            this.Property(t => t.p11_value).HasColumnName("p11_value");
            this.Property(t => t.p12_expr).HasColumnName("p12_expr");
            this.Property(t => t.p12_value).HasColumnName("p12_value");
            this.Property(t => t.rm_std).HasColumnName("rm_std");
            this.Property(t => t.sb_name).HasColumnName("sb_name");
            this.Property(t => t.alloc_score).HasColumnName("alloc_score");
            this.Property(t => t.alloc_score_ext).HasColumnName("alloc_score_ext");
            this.Property(t => t.auto_allocated).HasColumnName("auto_allocated");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasOptional(t => t.bl)
                .WithMany(t => t.sb_items)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.bu)
                .WithMany(t => t.sb_items)
                .HasForeignKey(d => d.bu_id);
            this.HasOptional(t => t.dp)
                .WithMany(t => t.sb_items)
                .HasForeignKey(d => new { d.dv_id, d.dp_id });
            this.HasOptional(t => t.dv)
                .WithMany(t => t.sb_items)
                .HasForeignKey(d => d.dv_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.SbItems)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.rmstd)
                .WithMany(t => t.sb_items)
                .HasForeignKey(d => d.rm_std);
            this.HasRequired(t => t.sb)
                .WithMany(t => t.sb_items)
                .HasForeignKey(d => d.sb_name);

        }
    }
}
