using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class visitorMap : EntityTypeConfiguration<visitor>
    {
        public visitorMap()
        {
            // Primary Key
            this.HasKey(t => t.visitor_id);

            // Properties
            this.Property(t => t.authorized_by)
                .HasMaxLength(128);

            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.car_make)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.car_registration)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.cellular_number)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.comments)
                .HasMaxLength(500);

            this.Property(t => t.company)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.contact)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.contact_phone)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.contact_relation)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.email)
                .HasMaxLength(128);

            this.Property(t => t.entered_by)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.honorific)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.image_file)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.name_first)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.name_last)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.rm_name)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.security_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.visitor_photo)
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("visitors", "afm");
            this.Property(t => t.authorized_by).HasColumnName("authorized_by");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.car_make).HasColumnName("car_make");
            this.Property(t => t.car_registration).HasColumnName("car_registration");
            this.Property(t => t.cellular_number).HasColumnName("cellular_number");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.company).HasColumnName("company");
            this.Property(t => t.contact).HasColumnName("contact");
            this.Property(t => t.contact_phone).HasColumnName("contact_phone");
            this.Property(t => t.contact_relation).HasColumnName("contact_relation");
            this.Property(t => t.date_end).HasColumnName("date_end");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.entered_by).HasColumnName("entered_by");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.has_parking).HasColumnName("has_parking");
            this.Property(t => t.honorific).HasColumnName("honorific");
            this.Property(t => t.image_file).HasColumnName("image_file");
            this.Property(t => t.is_authorized).HasColumnName("is_authorized");
            this.Property(t => t.name_first).HasColumnName("name_first");
            this.Property(t => t.name_last).HasColumnName("name_last");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.rm_name).HasColumnName("rm_name");
            this.Property(t => t.security_type).HasColumnName("security_type");
            this.Property(t => t.visitor_photo).HasColumnName("visitor_photo");
            this.Property(t => t.visitor_id).HasColumnName("visitor_id");

            // Relationships
            this.HasOptional(t => t.bl)
                .WithMany(t => t.visitors)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.dp)
                .WithMany(t => t.visitors)
                .HasForeignKey(d => new { d.dv_id, d.dp_id });
            this.HasOptional(t => t.dv)
                .WithMany(t => t.visitors)
                .HasForeignKey(d => d.dv_id);
            this.HasOptional(t => t.em)
                .WithMany(t => t.visitors)
                .HasForeignKey(d => d.em_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.Visitors)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.rm)
                .WithMany(t => t.visitors)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });

        }
    }
}
