using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class drMap : EntityTypeConfiguration<dr>
    {
        public drMap()
        {
            // Primary Key
            this.HasKey(t => new { t.bl_id, t.fl_id, t.dr_id });

            // Properties
            this.Property(t => t.fr_fnsh)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.fr_matl)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.fr_type)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.head_det)
                .IsFixedLength()
                .HasMaxLength(7);

            this.Property(t => t.head_pf)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.height)
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.jamb_det)
                .IsFixedLength()
                .HasMaxLength(7);

            this.Property(t => t.jamb_pf)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.key_rmno)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.layer_name)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.remarks)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.rm_name)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.setno)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.thkns)
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.thrs_det)
                .IsFixedLength()
                .HasMaxLength(7);

            this.Property(t => t.thrs_pf)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.width)
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.dr_matl)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.dr_std)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.dr_type)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.dwgname)
                .HasMaxLength(128);

            this.Property(t => t.ehandle)
                .HasMaxLength(64);

            this.Property(t => t.fire_lbl)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.dr_fnsh)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.fl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.dr_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("dr", "afm");
            this.Property(t => t.fr_fnsh).HasColumnName("fr_fnsh");
            this.Property(t => t.fr_matl).HasColumnName("fr_matl");
            this.Property(t => t.fr_type).HasColumnName("fr_type");
            this.Property(t => t.head_det).HasColumnName("head_det");
            this.Property(t => t.head_pf).HasColumnName("head_pf");
            this.Property(t => t.height).HasColumnName("height");
            this.Property(t => t.jamb_det).HasColumnName("jamb_det");
            this.Property(t => t.jamb_pf).HasColumnName("jamb_pf");
            this.Property(t => t.key_rmno).HasColumnName("key_rmno");
            this.Property(t => t.layer_name).HasColumnName("layer_name");
            this.Property(t => t.remarks).HasColumnName("remarks");
            this.Property(t => t.rm_name).HasColumnName("rm_name");
            this.Property(t => t.setno).HasColumnName("setno");
            this.Property(t => t.thkns).HasColumnName("thkns");
            this.Property(t => t.thrs_det).HasColumnName("thrs_det");
            this.Property(t => t.thrs_pf).HasColumnName("thrs_pf");
            this.Property(t => t.width).HasColumnName("width");
            this.Property(t => t.dr_matl).HasColumnName("dr_matl");
            this.Property(t => t.dr_std).HasColumnName("dr_std");
            this.Property(t => t.dr_type).HasColumnName("dr_type");
            this.Property(t => t.dwgname).HasColumnName("dwgname");
            this.Property(t => t.ehandle).HasColumnName("ehandle");
            this.Property(t => t.fire_lbl).HasColumnName("fire_lbl");
            this.Property(t => t.dr_fnsh).HasColumnName("dr_fnsh");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.dr_id).HasColumnName("dr_id");

            // Relationships
            this.HasRequired(t => t.bl)
                .WithMany(t => t.drs)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.drfnsh)
                .WithMany(t => t.drs)
                .HasForeignKey(d => d.dr_fnsh);
            this.HasOptional(t => t.drmatl)
                .WithMany(t => t.drs)
                .HasForeignKey(d => d.dr_matl);
            this.HasOptional(t => t.drstd)
                .WithMany(t => t.drs)
                .HasForeignKey(d => d.dr_std);
            this.HasOptional(t => t.drtype)
                .WithMany(t => t.drs)
                .HasForeignKey(d => d.dr_type);
            this.HasRequired(t => t.fl)
                .WithMany(t => t.Drs)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.drfrmatl)
                .WithMany(t => t.drs)
                .HasForeignKey(d => d.fr_matl);

        }
    }
}
