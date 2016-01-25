#region

using System.Data.Entity.ModelConfiguration;

#endregion

namespace DurandalAuth.Domain.Models.Mapping
{
    public class eq_reserveMap : EntityTypeConfiguration<eq_reserve>
    {
        public eq_reserveMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.bl_id).IsFixedLength().HasMaxLength(8);

            this.Property(t => t.comments).HasMaxLength(2000);

            this.Property(t => t.contact).IsFixedLength().HasMaxLength(35);

            this.Property(t => t.dp_id).IsFixedLength().HasMaxLength(16);

            this.Property(t => t.dv_id).IsFixedLength().HasMaxLength(16);

            this.Property(t => t.eq_id).IsFixedLength().HasMaxLength(12);

            this.Property(t => t.eventType).IsFixedLength().HasMaxLength(64);

            this.Property(t => t.fl_id).IsFixedLength().HasMaxLength(4);

            this.Property(t => t.option1).IsFixedLength().HasMaxLength(16);

            this.Property(t => t.option2).IsFixedLength().HasMaxLength(16);

            this.Property(t => t.rm_id).IsFixedLength().HasMaxLength(8);

            this.Property(t => t.status).IsRequired().IsFixedLength().HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("eq_reserve", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.contact).HasColumnName("contact");
            this.Property(t => t.date_end).HasColumnName("date_end");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.eq_id).HasColumnName("eq_id");
            this.Property(t => t.eventType).HasColumnName("event");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.group_size).HasColumnName("group_size");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.time_end).HasColumnName("time_end");
            this.Property(t => t.time_start).HasColumnName("time_start");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasOptional(t => t.bl).WithMany(t => t.eq_reserve).HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.dp).WithMany(t => t.eq_reserve).HasForeignKey(d => new { d.dv_id, d.dp_id });
            this.HasOptional(t => t.dv).WithMany(t => t.eq_reserve).HasForeignKey(d => d.dv_id);
            this.HasOptional(t => t.em).WithMany(t => t.EqReserve).HasForeignKey(d => d.contact);
            this.HasOptional(t => t.eq).WithMany(t => t.eq_reserve).HasForeignKey(d => d.eq_id);
            this.HasOptional(t => t.fl).WithMany(t => t.EqReserve).HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.rm)
                .WithMany(t => t.eq_reserve)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });
        }
    }
}