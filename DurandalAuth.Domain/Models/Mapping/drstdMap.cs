using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class drstdMap : EntityTypeConfiguration<drstd>
    {
        public drstdMap()
        {
            // Primary Key
            this.HasKey(t => t.dr_std);

            // Properties
            this.Property(t => t.dr_type)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.fire_lbl)
                .IsFixedLength()
                .HasMaxLength(1);

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
                .HasMaxLength(6);

            this.Property(t => t.head_pf)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.height)
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.jamb_det)
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.jamb_pf)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.remarks)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.setno)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.thkns)
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.thrs_det)
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.thrs_pf)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.width)
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.dr_fnsh)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.dr_matl)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.dr_std)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("drstd", "afm");
            this.Property(t => t.dr_type).HasColumnName("dr_type");
            this.Property(t => t.fire_lbl).HasColumnName("fire_lbl");
            this.Property(t => t.fr_fnsh).HasColumnName("fr_fnsh");
            this.Property(t => t.fr_matl).HasColumnName("fr_matl");
            this.Property(t => t.fr_type).HasColumnName("fr_type");
            this.Property(t => t.head_det).HasColumnName("head_det");
            this.Property(t => t.head_pf).HasColumnName("head_pf");
            this.Property(t => t.height).HasColumnName("height");
            this.Property(t => t.jamb_det).HasColumnName("jamb_det");
            this.Property(t => t.jamb_pf).HasColumnName("jamb_pf");
            this.Property(t => t.remarks).HasColumnName("remarks");
            this.Property(t => t.setno).HasColumnName("setno");
            this.Property(t => t.thkns).HasColumnName("thkns");
            this.Property(t => t.thrs_det).HasColumnName("thrs_det");
            this.Property(t => t.thrs_pf).HasColumnName("thrs_pf");
            this.Property(t => t.width).HasColumnName("width");
            this.Property(t => t.dr_fnsh).HasColumnName("dr_fnsh");
            this.Property(t => t.dr_matl).HasColumnName("dr_matl");
            this.Property(t => t.dr_std).HasColumnName("dr_std");

            // Relationships
            this.HasOptional(t => t.drfnsh)
                .WithMany(t => t.drstds)
                .HasForeignKey(d => d.dr_fnsh);
            this.HasOptional(t => t.drfrmatl)
                .WithMany(t => t.drstds)
                .HasForeignKey(d => d.fr_matl);
            this.HasOptional(t => t.drmatl)
                .WithMany(t => t.drstds)
                .HasForeignKey(d => d.dr_matl);
            this.HasOptional(t => t.drtype)
                .WithMany(t => t.drstds)
                .HasForeignKey(d => d.dr_type);

        }
    }
}
