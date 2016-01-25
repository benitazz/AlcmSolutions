using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class wnstdMap : EntityTypeConfiguration<wnstd>
    {
        public wnstdMap()
        {
            // Primary Key
            this.HasKey(t => t.wn_std);

            // Properties
            this.Property(t => t.fr_elev)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.fr_matl)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.gl_thkns)
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.gl_type)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.head_det)
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.head_sec)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.height)
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.hm_det)
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.hm_sec)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.jamb_det)
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.jamb_sec)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.remarks)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.sill_det)
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.sill_sec)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.thkns)
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.vm_det)
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.vm_sec)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.width)
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.wn_type)
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.wn_std)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("wnstd", "afm");
            this.Property(t => t.fr_elev).HasColumnName("fr_elev");
            this.Property(t => t.fr_matl).HasColumnName("fr_matl");
            this.Property(t => t.gl_thkns).HasColumnName("gl_thkns");
            this.Property(t => t.gl_type).HasColumnName("gl_type");
            this.Property(t => t.head_det).HasColumnName("head_det");
            this.Property(t => t.head_sec).HasColumnName("head_sec");
            this.Property(t => t.height).HasColumnName("height");
            this.Property(t => t.hm_det).HasColumnName("hm_det");
            this.Property(t => t.hm_sec).HasColumnName("hm_sec");
            this.Property(t => t.jamb_det).HasColumnName("jamb_det");
            this.Property(t => t.jamb_sec).HasColumnName("jamb_sec");
            this.Property(t => t.remarks).HasColumnName("remarks");
            this.Property(t => t.sill_det).HasColumnName("sill_det");
            this.Property(t => t.sill_sec).HasColumnName("sill_sec");
            this.Property(t => t.thkns).HasColumnName("thkns");
            this.Property(t => t.vm_det).HasColumnName("vm_det");
            this.Property(t => t.vm_sec).HasColumnName("vm_sec");
            this.Property(t => t.width).HasColumnName("width");
            this.Property(t => t.wn_type).HasColumnName("wn_type");
            this.Property(t => t.wn_std).HasColumnName("wn_std");

            // Relationships
            this.HasOptional(t => t.wnfrmatl)
                .WithMany(t => t.wnstds)
                .HasForeignKey(d => d.fr_matl);
            this.HasOptional(t => t.wngltype)
                .WithMany(t => t.wnstds)
                .HasForeignKey(d => d.gl_type);
            this.HasOptional(t => t.wntype)
                .WithMany(t => t.wnstds)
                .HasForeignKey(d => d.wn_type);

        }
    }
}
