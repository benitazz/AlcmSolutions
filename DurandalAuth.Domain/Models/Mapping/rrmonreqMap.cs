using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class rrmonreqMap : EntityTypeConfiguration<rrmonreq>
    {
        public rrmonreqMap()
        {
            // Primary Key
            this.HasKey(t => new { t.bl_id, t.fl_id, t.rm_id, t.rm_arrange_type_id, t.date_start, t.config_id, t.usertype });

            // Properties
            this.Property(t => t.ctry_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.site_id)
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

            this.Property(t => t.rm_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.rm_arrange_type_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.status)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.config_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.monthtxt)
                .HasMaxLength(8);

            this.Property(t => t.usertype)
                .IsRequired()
                .HasMaxLength(24);

            // Table & Column Mappings
            this.ToTable("rrmonreq", "afm");
            this.Property(t => t.ctry_id).HasColumnName("ctry_id");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.rm_arrange_type_id).HasColumnName("rm_arrange_type_id");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.config_id).HasColumnName("config_id");
            this.Property(t => t.monthtxt).HasColumnName("monthtxt");
            this.Property(t => t.usertype).HasColumnName("usertype");
        }
    }
}
