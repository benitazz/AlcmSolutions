using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class rrdayrmoccMap : EntityTypeConfiguration<rrdayrmocc>
    {
        public rrdayrmoccMap()
        {
            // Primary Key
            this.HasKey(t => new { t.status, t.rm_arrange_type_id, t.config_id, t.rm_arrange_type, t.bl_id, t.fl_id, t.rm_id });

            // Properties
            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.monthtxt)
                .HasMaxLength(8);

            this.Property(t => t.rm_arrange_type_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.config_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.rm_arrange_type)
                .IsRequired()
                .HasMaxLength(56);

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

            // Table & Column Mappings
            this.ToTable("rrdayrmocc", "afm");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.monthtxt).HasColumnName("monthtxt");
            this.Property(t => t.total_hours).HasColumnName("total_hours");
            this.Property(t => t.rm_arrange_type_id).HasColumnName("rm_arrange_type_id");
            this.Property(t => t.rmres_id).HasColumnName("rmres_id");
            this.Property(t => t.res_id).HasColumnName("res_id");
            this.Property(t => t.config_id).HasColumnName("config_id");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.rm_arrange_type).HasColumnName("rm_arrange_type");
            this.Property(t => t.time_start).HasColumnName("time_start");
            this.Property(t => t.time_end).HasColumnName("time_end");
            this.Property(t => t.ctry_id).HasColumnName("ctry_id");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
        }
    }
}
