using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class taMap : EntityTypeConfiguration<ta>
    {
        public taMap()
        {
            // Primary Key
            this.HasKey(t => t.ta_id);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.condition)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.curr_bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.curr_fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.curr_fl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.curr_site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dwgname)
                .HasMaxLength(128);

            this.Property(t => t.ehandle)
                .HasMaxLength(64);

            this.Property(t => t.em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.fn_std)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.layer_name)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.policy_id)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.property_type)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.rf_id)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.serial_number)
                .HasMaxLength(20);

            this.Property(t => t.status)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.survey_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.ta_lease_id)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.use1)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.warranty_id)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.ta_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("ta", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.condition).HasColumnName("condition");
            this.Property(t => t.curr_bl_id).HasColumnName("curr_bl_id");
            this.Property(t => t.curr_fl_id).HasColumnName("curr_fl_id");
            this.Property(t => t.curr_fl_id).HasColumnName("curr_fl_id");
            this.Property(t => t.curr_site_id).HasColumnName("curr_site_id");
            this.Property(t => t.date_delivery).HasColumnName("date_delivery");
            this.Property(t => t.date_return).HasColumnName("date_return");
            this.Property(t => t.date_sale).HasColumnName("date_sale");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.dwgname).HasColumnName("dwgname");
            this.Property(t => t.ehandle).HasColumnName("ehandle");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.fn_std).HasColumnName("fn_std");
            this.Property(t => t.geo_objectid).HasColumnName("geo_objectid");
            this.Property(t => t.lat).HasColumnName("lat");
            this.Property(t => t.layer_name).HasColumnName("layer_name");
            this.Property(t => t.lon).HasColumnName("lon");
            this.Property(t => t.po_id).HasColumnName("po_id");
            this.Property(t => t.po_line_id).HasColumnName("po_line_id");
            this.Property(t => t.policy_id).HasColumnName("policy_id");
            this.Property(t => t.property_type).HasColumnName("property_type");
            this.Property(t => t.rf_id).HasColumnName("rf_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.serial_number).HasColumnName("serial_number");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.survey_id).HasColumnName("survey_id");
            this.Property(t => t.ta_lease_id).HasColumnName("ta_lease_id");
            this.Property(t => t.use1).HasColumnName("use1");
            this.Property(t => t.value_original).HasColumnName("value_original");
            this.Property(t => t.value_replace).HasColumnName("value_replace");
            this.Property(t => t.value_salvage).HasColumnName("value_salvage");
            this.Property(t => t.warranty_id).HasColumnName("warranty_id");
            this.Property(t => t.ta_id).HasColumnName("ta_id");

            // Relationships
            this.HasOptional(t => t.bl)
                .WithMany(t => t.tas)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.dp)
                .WithMany(t => t.tas)
                .HasForeignKey(d => new { d.dv_id, d.dp_id });
            this.HasOptional(t => t.dv)
                .WithMany(t => t.tas)
                .HasForeignKey(d => d.dv_id);
            this.HasOptional(t => t.em)
                .WithMany(t => t.tas)
                .HasForeignKey(d => d.em_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.Tas)
                .HasForeignKey(d => new { d.curr_bl_id, d.curr_fl_id });
            this.HasOptional(t => t.fl1)
                .WithMany(t => t.Tas1)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.fnstd)
                .WithMany(t => t.tas)
                .HasForeignKey(d => d.fn_std);
            this.HasOptional(t => t.po)
                .WithMany(t => t.tas)
                .HasForeignKey(d => d.po_id);
            this.HasOptional(t => t.po_line)
                .WithMany(t => t.tas)
                .HasForeignKey(d => new { d.po_id, d.po_line_id });
            this.HasOptional(t => t.policy)
                .WithMany(t => t.tas)
                .HasForeignKey(d => d.policy_id);
            this.HasOptional(t => t.property_type1)
                .WithMany(t => t.tas)
                .HasForeignKey(d => d.property_type);
            this.HasOptional(t => t.rm)
                .WithMany(t => t.tas)
                .HasForeignKey(d => new { d.curr_bl_id, d.curr_fl_id, d.curr_rm_id });
            this.HasOptional(t => t.rm1)
                .WithMany(t => t.tas1)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });
            this.HasOptional(t => t.survey)
                .WithMany(t => t.tas)
                .HasForeignKey(d => d.survey_id);
            this.HasOptional(t => t.ta_lease)
                .WithMany(t => t.tas)
                .HasForeignKey(d => d.ta_lease_id);
            this.HasOptional(t => t.warranty)
                .WithMany(t => t.tas)
                .HasForeignKey(d => d.warranty_id);

        }
    }
}
