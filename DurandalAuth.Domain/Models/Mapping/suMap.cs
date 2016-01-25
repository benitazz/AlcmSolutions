using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class suMap : EntityTypeConfiguration<su>
    {
        public suMap()
        {
            // Primary Key
            this.HasKey(t => new { t.bl_id, t.fl_id, t.su_id });

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(512);

            this.Property(t => t.doc_image)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.dwgname)
                .HasMaxLength(128);

            this.Property(t => t.ehandle)
                .HasMaxLength(64);

            this.Property(t => t.facility_type_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.image_file)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.ls_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.name)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.fl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.su_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("su", "afm");
            this.Property(t => t.area_comn).HasColumnName("area_comn");
            this.Property(t => t.area_manual).HasColumnName("area_manual");
            this.Property(t => t.area_rentable).HasColumnName("area_rentable");
            this.Property(t => t.area_usable).HasColumnName("area_usable");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.doc_image).HasColumnName("doc_image");
            this.Property(t => t.dwgname).HasColumnName("dwgname");
            this.Property(t => t.ehandle).HasColumnName("ehandle");
            this.Property(t => t.facility_type_id).HasColumnName("facility_type_id");
            this.Property(t => t.image_file).HasColumnName("image_file");
            this.Property(t => t.ls_id).HasColumnName("ls_id");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.occupancy).HasColumnName("occupancy");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.su_id).HasColumnName("su_id");

            // Relationships
            this.HasRequired(t => t.bl)
                .WithMany(t => t.sus)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.facility_type)
                .WithMany(t => t.sus)
                .HasForeignKey(d => d.facility_type_id);
            this.HasRequired(t => t.fl)
                .WithMany(t => t.Sus)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.l)
                .WithMany(t => t.sus)
                .HasForeignKey(d => d.ls_id);

        }
    }
}
