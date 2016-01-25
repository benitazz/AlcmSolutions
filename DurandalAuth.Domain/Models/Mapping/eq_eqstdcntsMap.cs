using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class eq_eqstdcntsMap : EntityTypeConfiguration<eq_eqstdcnts>
    {
        public eq_eqstdcntsMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.eq_std)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("eq_eqstdcnts", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.eq_std).HasColumnName("eq_std");
            this.Property(t => t.eqstd_count).HasColumnName("eqstd_count");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasOptional(t => t.bl)
                .WithMany(t => t.eq_eqstdcnts)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.dp)
                .WithMany(t => t.eq_eqstdcnts)
                .HasForeignKey(d => new { d.dv_id, d.dp_id });
            this.HasOptional(t => t.dv)
                .WithMany(t => t.eq_eqstdcnts)
                .HasForeignKey(d => d.dv_id);
            this.HasOptional(t => t.em)
                .WithMany(t => t.EqEqstdcnts)
                .HasForeignKey(d => d.em_id);
            this.HasOptional(t => t.eqstd)
                .WithMany(t => t.eq_eqstdcnts)
                .HasForeignKey(d => d.eq_std);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.EqEqstdcnts)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.rm)
                .WithMany(t => t.eq_eqstdcnts)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });

        }
    }
}
