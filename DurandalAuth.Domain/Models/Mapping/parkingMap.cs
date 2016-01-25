using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class parkingMap : EntityTypeConfiguration<parking>
    {
        public parkingMap()
        {
            // Primary Key
            this.HasKey(t => t.parking_id);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.dwgname)
                .HasMaxLength(128);

            this.Property(t => t.ehandle)
                .HasMaxLength(64);

            this.Property(t => t.em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.ls_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.parking_std)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.pr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.parking_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("parking", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.dwgname).HasColumnName("dwgname");
            this.Property(t => t.ehandle).HasColumnName("ehandle");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.geo_objectid).HasColumnName("geo_objectid");
            this.Property(t => t.lat).HasColumnName("lat");
            this.Property(t => t.lon).HasColumnName("lon");
            this.Property(t => t.ls_id).HasColumnName("ls_id");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.parking_std).HasColumnName("parking_std");
            this.Property(t => t.pr_id).HasColumnName("pr_id");
            this.Property(t => t.parking_id).HasColumnName("parking_id");

            // Relationships
            this.HasOptional(t => t.bl)
                .WithMany(t => t.parkings)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.em)
                .WithMany(t => t.parkings)
                .HasForeignKey(d => d.em_id);
            this.HasOptional(t => t.l)
                .WithMany(t => t.parkings)
                .HasForeignKey(d => d.ls_id);
            this.HasOptional(t => t.parkingstd)
                .WithMany(t => t.parkings)
                .HasForeignKey(d => d.parking_std);
            this.HasOptional(t => t.property)
                .WithMany(t => t.parkings)
                .HasForeignKey(d => d.pr_id);

        }
    }
}
