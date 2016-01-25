using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class em_syncMap : EntityTypeConfiguration<em_sync>
    {
        public em_syncMap()
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
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.em_number)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.em_photo)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.em_std)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.email)
                .HasMaxLength(50);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.mob_locked_by)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.name_first)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.name_last)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.phone)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.survey_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("em_sync", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.em_number).HasColumnName("em_number");
            this.Property(t => t.em_photo).HasColumnName("em_photo");
            this.Property(t => t.em_std).HasColumnName("em_std");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.mob_is_changed).HasColumnName("mob_is_changed");
            this.Property(t => t.mob_locked_by).HasColumnName("mob_locked_by");
            this.Property(t => t.name_first).HasColumnName("name_first");
            this.Property(t => t.name_last).HasColumnName("name_last");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.survey_id).HasColumnName("survey_id");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasOptional(t => t.bl)
                .WithMany(t => t.em_sync)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.dp)
                .WithMany(t => t.em_sync)
                .HasForeignKey(d => new { d.dv_id, d.dp_id });
            this.HasOptional(t => t.dv)
                .WithMany(t => t.em_sync)
                .HasForeignKey(d => d.dv_id);
            this.HasOptional(t => t.emstd)
                .WithMany(t => t.em_sync)
                .HasForeignKey(d => d.em_std);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.EmSync)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.rm)
                .WithMany(t => t.em_sync)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });

        }
    }
}
