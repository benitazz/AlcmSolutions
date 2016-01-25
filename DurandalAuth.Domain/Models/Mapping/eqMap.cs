using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class eqMap : EntityTypeConfiguration<eq>
    {
        public eqMap()
        {
            // Primary Key
            this.HasKey(t => t.eq_id);

            // Properties
            this.Property(t => t.eq_std)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.grp_uid)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.hardware_address)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.image_eq_assy)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.image_eq_elec)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.image_eq_lub)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.image_spec)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.layer_name)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.loc_bay)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.loc_column)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.loc_maint_manl)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.meter_units)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.mfr)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.modelno)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.net_address)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.net_address_ip)
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.net_card_type)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.net_id)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.net_node_name)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.net_sub_mask)
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.num_lease)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.num_po)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.num_serial)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.os_type)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.policy_id)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.pr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.property_type)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.rack_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.recovery_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.rf_id)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.servcont_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.status)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.subcomponent_of)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.survey_comments)
                .HasMaxLength(5000);

            this.Property(t => t.survey_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.survey_photo_eq)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.survey_redline_eq)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.ta_lease_id)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.tc_area_level)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.tc_client_server)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.tc_level)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.tc_service)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.use1)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.vn_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.warranty_id)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.asset_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.comments)
                .HasMaxLength(5000);

            this.Property(t => t.condition)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.csi_id)
                .IsFixedLength()
                .HasMaxLength(8);

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

            this.Property(t => t.doc_eop)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.doc_loto)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.doc_mop)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.doc_other)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.doc_sop)
                .IsFixedLength()
                .HasMaxLength(64);

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

            this.Property(t => t.eq_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("eq", "afm");
            this.Property(t => t.eq_std).HasColumnName("eq_std");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.geo_objectid).HasColumnName("geo_objectid");
            this.Property(t => t.grp_uid).HasColumnName("grp_uid");
            this.Property(t => t.hardware_address).HasColumnName("hardware_address");
            this.Property(t => t.image_eq_assy).HasColumnName("image_eq_assy");
            this.Property(t => t.image_eq_elec).HasColumnName("image_eq_elec");
            this.Property(t => t.image_eq_lub).HasColumnName("image_eq_lub");
            this.Property(t => t.image_spec).HasColumnName("image_spec");
            this.Property(t => t.is_multiplexing).HasColumnName("is_multiplexing");
            this.Property(t => t.lat).HasColumnName("lat");
            this.Property(t => t.layer_name).HasColumnName("layer_name");
            this.Property(t => t.limit_alarm_high).HasColumnName("limit_alarm_high");
            this.Property(t => t.limit_alarm_low).HasColumnName("limit_alarm_low");
            this.Property(t => t.limit_ctl_high).HasColumnName("limit_ctl_high");
            this.Property(t => t.limit_ctl_low).HasColumnName("limit_ctl_low");
            this.Property(t => t.loc_bay).HasColumnName("loc_bay");
            this.Property(t => t.loc_column).HasColumnName("loc_column");
            this.Property(t => t.loc_maint_manl).HasColumnName("loc_maint_manl");
            this.Property(t => t.locked_out).HasColumnName("locked_out");
            this.Property(t => t.lon).HasColumnName("lon");
            this.Property(t => t.meter).HasColumnName("meter");
            this.Property(t => t.meter_last_read).HasColumnName("meter_last_read");
            this.Property(t => t.meter_units).HasColumnName("meter_units");
            this.Property(t => t.meter_usage_per_day).HasColumnName("meter_usage_per_day");
            this.Property(t => t.mfr).HasColumnName("mfr");
            this.Property(t => t.modelno).HasColumnName("modelno");
            this.Property(t => t.net_address).HasColumnName("net_address");
            this.Property(t => t.net_address_ip).HasColumnName("net_address_ip");
            this.Property(t => t.net_card_type).HasColumnName("net_card_type");
            this.Property(t => t.net_id).HasColumnName("net_id");
            this.Property(t => t.net_node_name).HasColumnName("net_node_name");
            this.Property(t => t.net_sub_mask).HasColumnName("net_sub_mask");
            this.Property(t => t.num_lease).HasColumnName("num_lease");
            this.Property(t => t.num_po).HasColumnName("num_po");
            this.Property(t => t.num_serial).HasColumnName("num_serial");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.os_type).HasColumnName("os_type");
            this.Property(t => t.po_id).HasColumnName("po_id");
            this.Property(t => t.po_line_id).HasColumnName("po_line_id");
            this.Property(t => t.policy_id).HasColumnName("policy_id");
            this.Property(t => t.pr_id).HasColumnName("pr_id");
            this.Property(t => t.property_type).HasColumnName("property_type");
            this.Property(t => t.qty_dep_period).HasColumnName("qty_dep_period");
            this.Property(t => t.qty_hrs_run_day).HasColumnName("qty_hrs_run_day");
            this.Property(t => t.qty_life_expct).HasColumnName("qty_life_expct");
            this.Property(t => t.qty_MTBF).HasColumnName("qty_MTBF");
            this.Property(t => t.qty_MTTR).HasColumnName("qty_MTTR");
            this.Property(t => t.qty_pms).HasColumnName("qty_pms");
            this.Property(t => t.rack_id).HasColumnName("rack_id");
            this.Property(t => t.recovery_status).HasColumnName("recovery_status");
            this.Property(t => t.rf_id).HasColumnName("rf_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.salvaged).HasColumnName("salvaged");
            this.Property(t => t.servcont_id).HasColumnName("servcont_id");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.subcomponent_of).HasColumnName("subcomponent_of");
            this.Property(t => t.survey_comments).HasColumnName("survey_comments");
            this.Property(t => t.survey_id).HasColumnName("survey_id");
            this.Property(t => t.survey_photo_eq).HasColumnName("survey_photo_eq");
            this.Property(t => t.survey_redline_eq).HasColumnName("survey_redline_eq");
            this.Property(t => t.ta_lease_id).HasColumnName("ta_lease_id");
            this.Property(t => t.tagged_out).HasColumnName("tagged_out");
            this.Property(t => t.tc_area_level).HasColumnName("tc_area_level");
            this.Property(t => t.tc_client_server).HasColumnName("tc_client_server");
            this.Property(t => t.tc_level).HasColumnName("tc_level");
            this.Property(t => t.tc_service).HasColumnName("tc_service");
            this.Property(t => t.use1).HasColumnName("use1");
            this.Property(t => t.value_salvage).HasColumnName("value_salvage");
            this.Property(t => t.vn_id).HasColumnName("vn_id");
            this.Property(t => t.warranty_id).HasColumnName("warranty_id");
            this.Property(t => t.asset_id).HasColumnName("asset_id");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.condition).HasColumnName("condition");
            this.Property(t => t.cost_dep_value).HasColumnName("cost_dep_value");
            this.Property(t => t.cost_purchase).HasColumnName("cost_purchase");
            this.Property(t => t.cost_replace).HasColumnName("cost_replace");
            this.Property(t => t.criticality).HasColumnName("criticality");
            this.Property(t => t.csi_id).HasColumnName("csi_id");
            this.Property(t => t.curr_bl_id).HasColumnName("curr_bl_id");
            this.Property(t => t.curr_fl_id).HasColumnName("curr_fl_id");
            this.Property(t => t.curr_fl_id).HasColumnName("curr_fl_id");
            this.Property(t => t.curr_site_id).HasColumnName("curr_site_id");
            this.Property(t => t.date_in_repair).HasColumnName("date_in_repair");
            this.Property(t => t.date_in_service).HasColumnName("date_in_service");
            this.Property(t => t.date_in_storage).HasColumnName("date_in_storage");
            this.Property(t => t.date_installed).HasColumnName("date_installed");
            this.Property(t => t.date_last_surveyed).HasColumnName("date_last_surveyed");
            this.Property(t => t.date_manufactured).HasColumnName("date_manufactured");
            this.Property(t => t.date_of_stat_chg).HasColumnName("date_of_stat_chg");
            this.Property(t => t.date_purchased).HasColumnName("date_purchased");
            this.Property(t => t.date_salvaged).HasColumnName("date_salvaged");
            this.Property(t => t.date_sold).HasColumnName("date_sold");
            this.Property(t => t.doc_eop).HasColumnName("doc_eop");
            this.Property(t => t.doc_loto).HasColumnName("doc_loto");
            this.Property(t => t.doc_mop).HasColumnName("doc_mop");
            this.Property(t => t.doc_other).HasColumnName("doc_other");
            this.Property(t => t.doc_sop).HasColumnName("doc_sop");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.dwgname).HasColumnName("dwgname");
            this.Property(t => t.ehandle).HasColumnName("ehandle");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.eq_id).HasColumnName("eq_id");

            // Relationships
            this.HasOptional(t => t.afm_tclevel)
                .WithMany(t => t.eqs)
                .HasForeignKey(d => d.tc_level);
            this.HasOptional(t => t.bl)
                .WithMany(t => t.eqs)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.csi)
                .WithMany(t => t.eqs)
                .HasForeignKey(d => d.csi_id);
            this.HasOptional(t => t.dp)
                .WithMany(t => t.eqs)
                .HasForeignKey(d => new { d.dv_id, d.dp_id });
            this.HasOptional(t => t.dv)
                .WithMany(t => t.eqs)
                .HasForeignKey(d => d.dv_id);
            this.HasOptional(t => t.em)
                .WithMany(t => t.Eqs)
                .HasForeignKey(d => d.em_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.Eqs)
                .HasForeignKey(d => new { d.curr_bl_id, d.curr_fl_id });
            this.HasOptional(t => t.rm)
                .WithMany(t => t.eqs)
                .HasForeignKey(d => new { d.curr_bl_id, d.curr_fl_id, d.curr_rm_id });
            this.HasOptional(t => t.eqstd)
                .WithMany(t => t.eqs)
                .HasForeignKey(d => d.eq_std);
            this.HasOptional(t => t.fl1)
                .WithMany(t => t.Eqs1)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.net)
                .WithMany(t => t.eqs)
                .HasForeignKey(d => d.net_id);
            this.HasOptional(t => t.po)
                .WithMany(t => t.eqs)
                .HasForeignKey(d => d.po_id);
            this.HasOptional(t => t.po_line)
                .WithMany(t => t.eqs)
                .HasForeignKey(d => new { d.po_id, d.po_line_id });
            this.HasOptional(t => t.policy)
                .WithMany(t => t.eqs)
                .HasForeignKey(d => d.policy_id);
            this.HasOptional(t => t.property)
                .WithMany(t => t.eqs)
                .HasForeignKey(d => d.pr_id);
            this.HasOptional(t => t.property_type1)
                .WithMany(t => t.eqs)
                .HasForeignKey(d => d.property_type);
            this.HasOptional(t => t.rack)
                .WithMany(t => t.eqs)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id, d.rack_id });
            this.HasOptional(t => t.rm1)
                .WithMany(t => t.eqs1)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });
            this.HasOptional(t => t.servcont)
                .WithMany(t => t.eqs)
                .HasForeignKey(d => d.servcont_id);
            this.HasOptional(t => t.site)
                .WithMany(t => t.eqs)
                .HasForeignKey(d => d.site_id);
            this.HasOptional(t => t.survey)
                .WithMany(t => t.eqs)
                .HasForeignKey(d => d.survey_id);
            this.HasOptional(t => t.ta_lease)
                .WithMany(t => t.eqs)
                .HasForeignKey(d => d.ta_lease_id);
            this.HasOptional(t => t.vn)
                .WithMany(t => t.eqs)
                .HasForeignKey(d => d.vn_id);
            this.HasOptional(t => t.warranty)
                .WithMany(t => t.eqs)
                .HasForeignKey(d => d.warranty_id);

        }
    }
}
