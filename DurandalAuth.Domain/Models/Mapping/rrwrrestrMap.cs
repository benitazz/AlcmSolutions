using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class rrwrrestrMap : EntityTypeConfiguration<rrwrrestr>
    {
        public rrwrrestrMap()
        {
            // Primary Key
            this.HasKey(t => t.status);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.name)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.tr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.prob_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.resource_name)
                .HasMaxLength(32);

            this.Property(t => t.rm_arrange_type_id)
                .HasMaxLength(16);

            this.Property(t => t.requestor)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.phone)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.description)
                .HasMaxLength(5000);

            this.Property(t => t.ctry_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.vn_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.config_id)
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("rrwrrestr", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.tr_id).HasColumnName("tr_id");
            this.Property(t => t.date_assigned).HasColumnName("date_assigned");
            this.Property(t => t.time_assigned).HasColumnName("time_assigned");
            this.Property(t => t.prob_type).HasColumnName("prob_type");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.resource_name).HasColumnName("resource_name");
            this.Property(t => t.quantity).HasColumnName("quantity");
            this.Property(t => t.rm_arrange_type_id).HasColumnName("rm_arrange_type_id");
            this.Property(t => t.total_guest).HasColumnName("total_guest");
            this.Property(t => t.requestor).HasColumnName("requestor");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.ctry_id).HasColumnName("ctry_id");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.res_id).HasColumnName("res_id");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.vn_id).HasColumnName("vn_id");
            this.Property(t => t.config_id).HasColumnName("config_id");
        }
    }
}
