using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class servMap : EntityTypeConfiguration<serv>
    {
        public servMap()
        {
            // Primary Key
            this.HasKey(t => t.serv_id);

            // Properties
            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.dwgname)
                .HasMaxLength(128);

            this.Property(t => t.ehandle)
                .HasMaxLength(64);

            this.Property(t => t.fl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.layer_name)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.prorate)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.serv_num)
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.serv_std)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("serv", "afm");
            this.Property(t => t.area).HasColumnName("area");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.dwgname).HasColumnName("dwgname");
            this.Property(t => t.ehandle).HasColumnName("ehandle");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.layer_name).HasColumnName("layer_name");
            this.Property(t => t.prorate).HasColumnName("prorate");
            this.Property(t => t.serv_num).HasColumnName("serv_num");
            this.Property(t => t.serv_std).HasColumnName("serv_std");
            this.Property(t => t.serv_id).HasColumnName("serv_id");

            // Relationships
            this.HasRequired(t => t.bl)
                .WithMany(t => t.servs)
                .HasForeignKey(d => d.bl_id);
            this.HasRequired(t => t.fl)
                .WithMany(t => t.Servs)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.servstd)
                .WithMany(t => t.servs)
                .HasForeignKey(d => d.serv_std);

        }
    }
}
