using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class propertyMap : EntityTypeConfiguration<Property>
    {
        public propertyMap()
        {
            // Primary Key
            this.HasKey(t => t.pr_id);

            // Properties
            this.Property(t => t.ac_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.address1)
                .HasMaxLength(50);

            this.Property(t => t.address2)
                .HasMaxLength(50);

            this.Property(t => t.air_name)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.city_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.comments)
                .HasMaxLength(2000);

            this.Property(t => t.contact1)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.contact2)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.county_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.ctry_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.detail_dwg)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.dwgname)
                .HasMaxLength(128);

            this.Property(t => t.ehandle)
                .HasMaxLength(64);

            this.Property(t => t.fronts)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.grp_uid)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.image_file)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.image_map)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.int_name)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.land_is)
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

            this.Property(t => t.other_name)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.prop_is)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.prop_photo)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.property_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(9);

            this.Property(t => t.purchased_from)
                .HasMaxLength(2000);

            this.Property(t => t.regn_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.selling_broker)
                .HasMaxLength(2000);

            this.Property(t => t.services)
                .HasMaxLength(2000);

            this.Property(t => t.site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.sold_to)
                .HasMaxLength(2000);

            this.Property(t => t.state_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.status)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.street)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.unit)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.use1)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.vicinity)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.zip)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.zoning)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.pr_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("property", "afm");
            this.Property(t => t.ac_id).HasColumnName("ac_id");
            this.Property(t => t.address1).HasColumnName("address1");
            this.Property(t => t.address2).HasColumnName("address2");
            this.Property(t => t.air_dist).HasColumnName("air_dist");
            this.Property(t => t.air_name).HasColumnName("air_name");
            this.Property(t => t.area_bl_est_rentable).HasColumnName("area_bl_est_rentable");
            this.Property(t => t.area_bl_gross_int).HasColumnName("area_bl_gross_int");
            this.Property(t => t.area_bl_rentable).HasColumnName("area_bl_rentable");
            this.Property(t => t.area_bl_usable).HasColumnName("area_bl_usable");
            this.Property(t => t.area_cad).HasColumnName("area_cad");
            this.Property(t => t.area_land_acres).HasColumnName("area_land_acres");
            this.Property(t => t.area_lease_meas).HasColumnName("area_lease_meas");
            this.Property(t => t.area_lease_neg).HasColumnName("area_lease_neg");
            this.Property(t => t.area_manual).HasColumnName("area_manual");
            this.Property(t => t.area_non_permeable).HasColumnName("area_non_permeable");
            this.Property(t => t.area_parcel).HasColumnName("area_parcel");
            this.Property(t => t.area_parking_total).HasColumnName("area_parking_total");
            this.Property(t => t.area_prkg_acres).HasColumnName("area_prkg_acres");
            this.Property(t => t.area_total_permeable).HasColumnName("area_total_permeable");
            this.Property(t => t.city_id).HasColumnName("city_id");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.contact1).HasColumnName("contact1");
            this.Property(t => t.contact2).HasColumnName("contact2");
            this.Property(t => t.cost_irr).HasColumnName("cost_irr");
            this.Property(t => t.cost_operating_total).HasColumnName("cost_operating_total");
            this.Property(t => t.cost_other_total).HasColumnName("cost_other_total");
            this.Property(t => t.cost_purchase).HasColumnName("cost_purchase");
            this.Property(t => t.cost_roi).HasColumnName("cost_roi");
            this.Property(t => t.cost_selling).HasColumnName("cost_selling");
            this.Property(t => t.cost_tax_total).HasColumnName("cost_tax_total");
            this.Property(t => t.cost_utility_total).HasColumnName("cost_utility_total");
            this.Property(t => t.county_id).HasColumnName("county_id");
            this.Property(t => t.ctry_id).HasColumnName("ctry_id");
            this.Property(t => t.date_book_val).HasColumnName("date_book_val");
            this.Property(t => t.date_costs_end).HasColumnName("date_costs_end");
            this.Property(t => t.date_costs_last_calcd).HasColumnName("date_costs_last_calcd");
            this.Property(t => t.date_costs_start).HasColumnName("date_costs_start");
            this.Property(t => t.date_market_val).HasColumnName("date_market_val");
            this.Property(t => t.date_purchase).HasColumnName("date_purchase");
            this.Property(t => t.date_sold).HasColumnName("date_sold");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.detail_dwg).HasColumnName("detail_dwg");
            this.Property(t => t.dwgname).HasColumnName("dwgname");
            this.Property(t => t.ehandle).HasColumnName("ehandle");
            this.Property(t => t.fronts).HasColumnName("fronts");
            this.Property(t => t.geo_objectid).HasColumnName("geo_objectid");
            this.Property(t => t.grp_uid).HasColumnName("grp_uid");
            this.Property(t => t.image_file).HasColumnName("image_file");
            this.Property(t => t.image_map).HasColumnName("image_map");
            this.Property(t => t.income_total).HasColumnName("income_total");
            this.Property(t => t.int_dist).HasColumnName("int_dist");
            this.Property(t => t.int_name).HasColumnName("int_name");
            this.Property(t => t.land_is).HasColumnName("land_is");
            this.Property(t => t.lat).HasColumnName("lat");
            this.Property(t => t.lon).HasColumnName("lon");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.other_name).HasColumnName("other_name");
            this.Property(t => t.pct_own).HasColumnName("pct_own");
            this.Property(t => t.prop_is).HasColumnName("prop_is");
            this.Property(t => t.prop_photo).HasColumnName("prop_photo");
            this.Property(t => t.property_type).HasColumnName("property_type");
            this.Property(t => t.purchased_from).HasColumnName("purchased_from");
            this.Property(t => t.qty_headcount).HasColumnName("qty_headcount");
            this.Property(t => t.qty_no_bldgs).HasColumnName("qty_no_bldgs");
            this.Property(t => t.qty_no_bldgs_calc).HasColumnName("qty_no_bldgs_calc");
            this.Property(t => t.qty_no_spaces).HasColumnName("qty_no_spaces");
            this.Property(t => t.qty_no_spaces_calc).HasColumnName("qty_no_spaces_calc");
            this.Property(t => t.qty_occupancy).HasColumnName("qty_occupancy");
            this.Property(t => t.qty_su_occupancy).HasColumnName("qty_su_occupancy");
            this.Property(t => t.regn_id).HasColumnName("regn_id");
            this.Property(t => t.selling_broker).HasColumnName("selling_broker");
            this.Property(t => t.selling_commission).HasColumnName("selling_commission");
            this.Property(t => t.services).HasColumnName("services");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.sold_to).HasColumnName("sold_to");
            this.Property(t => t.state_id).HasColumnName("state_id");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.street).HasColumnName("street");
            this.Property(t => t.tax_rate_prop).HasColumnName("tax_rate_prop");
            this.Property(t => t.tax_rate_school).HasColumnName("tax_rate_school");
            this.Property(t => t.unit).HasColumnName("unit");
            this.Property(t => t.use1).HasColumnName("use1");
            this.Property(t => t.value_assessed_prop_tax).HasColumnName("value_assessed_prop_tax");
            this.Property(t => t.value_assessed_school_tax).HasColumnName("value_assessed_school_tax");
            this.Property(t => t.value_book).HasColumnName("value_book");
            this.Property(t => t.value_market).HasColumnName("value_market");
            this.Property(t => t.vicinity).HasColumnName("vicinity");
            this.Property(t => t.zip).HasColumnName("zip");
            this.Property(t => t.zoning).HasColumnName("zoning");
            this.Property(t => t.pr_id).HasColumnName("pr_id");

            // Relationships
            this.HasOptional(t => t.ac)
                .WithMany(t => t.properties)
                .HasForeignKey(d => d.ac_id);
            this.HasOptional(t => t.city)
                .WithMany(t => t.Properties)
                .HasForeignKey(d => new { d.state_id, d.city_id });
            this.HasOptional(t => t.county)
                .WithMany(t => t.Properties)
                .HasForeignKey(d => new { d.state_id, d.county_id });
            this.HasOptional(t => t.ctry)
                .WithMany(t => t.properties)
                .HasForeignKey(d => d.ctry_id);
            this.HasOptional(t => t.regn)
                .WithMany(t => t.Properties)
                .HasForeignKey(d => new { d.ctry_id, d.regn_id });
            this.HasOptional(t => t.site)
                .WithMany(t => t.properties)
                .HasForeignKey(d => d.site_id);
            this.HasOptional(t => t.state)
                .WithMany(t => t.properties)
                .HasForeignKey(d => d.state_id);

        }
    }
}
