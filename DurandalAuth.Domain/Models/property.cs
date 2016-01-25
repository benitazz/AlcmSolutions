namespace DurandalAuth.Domain.Models
{
    #region

    using System;
    using System.Collections.Generic;

    #endregion

    /// <summary>
    /// The property.
    /// </summary>
    public partial class Property
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Property"/> class.
        /// </summary>
        public Property()
        {
            this.activity_log = new List<activity_log>();
            this.bls = new List<bl>();
            this.budget_item = new List<budget_item>();
            this.ccost_sum = new List<ccost_sum>();
            this.compliance_locations = new List<compliance_locations>();
            this.contacts = new List<Contact>();
            this.cost_tran_recur = new List<cost_tran_recur>();
            this.cost_tran_sched = new List<cost_tran_sched>();
            this.docs_assigned = new List<docs_assigned>();
            this.ehs_incidents = new List<ehs_incidents>();
            this.ehs_incidents_sync = new List<ehs_incidents_sync>();
            this.eqs = new List<eq>();
            this.invoices = new List<invoice>();
            this.ls = new List<l>();
            this.ots = new List<ot>();
            this.pas = new List<pa>();
            this.pa_dep = new List<pa_dep>();
            this.parcels = new List<parcel>();
            this.parkings = new List<parking>();
            this.prop_amenity = new List<prop_amenity>();
            this.regcompliances = new List<regcompliance>();
            this.runoffareas = new List<runoffarea>();
            this.waste_areas = new List<waste_areas>();
            this.waste_generators = new List<waste_generators>();
            this.work_roles_location = new List<work_roles_location>();
        }

        /// <summary>
        /// Gets or sets the ac_id.
        /// </summary>
        public string ac_id { get; set; }

        /// <summary>
        /// Gets or sets the address 1.
        /// </summary>
        public string address1 { get; set; }

        /// <summary>
        /// Gets or sets the address 2.
        /// </summary>
        public string address2 { get; set; }

        /// <summary>
        /// Gets or sets the air_dist.
        /// </summary>
        public decimal? air_dist { get; set; }

        /// <summary>
        /// Gets or sets the air_name.
        /// </summary>
        public string air_name { get; set; }

        /// <summary>
        /// Gets or sets the area_bl_est_rentable.
        /// </summary>
        public decimal area_bl_est_rentable { get; set; }

        /// <summary>
        /// Gets or sets the area_bl_gross_int.
        /// </summary>
        public decimal area_bl_gross_int { get; set; }

        /// <summary>
        /// Gets or sets the area_bl_rentable.
        /// </summary>
        public decimal area_bl_rentable { get; set; }

        /// <summary>
        /// Gets or sets the area_bl_usable.
        /// </summary>
        public decimal area_bl_usable { get; set; }

        /// <summary>
        /// Gets or sets the area_cad.
        /// </summary>
        public decimal area_cad { get; set; }

        /// <summary>
        /// Gets or sets the area_land_acres.
        /// </summary>
        public decimal? area_land_acres { get; set; }

        /// <summary>
        /// Gets or sets the area_lease_meas.
        /// </summary>
        public decimal area_lease_meas { get; set; }

        /// <summary>
        /// Gets or sets the area_lease_neg.
        /// </summary>
        public decimal area_lease_neg { get; set; }

        /// <summary>
        /// Gets or sets the area_manual.
        /// </summary>
        public decimal area_manual { get; set; }

        /// <summary>
        /// Gets or sets the area_non_permeable.
        /// </summary>
        public decimal area_non_permeable { get; set; }

        /// <summary>
        /// Gets or sets the area_parcel.
        /// </summary>
        public decimal area_parcel { get; set; }

        /// <summary>
        /// Gets or sets the area_parking_total.
        /// </summary>
        public decimal area_parking_total { get; set; }

        /// <summary>
        /// Gets or sets the area_prkg_acres.
        /// </summary>
        public decimal? area_prkg_acres { get; set; }

        /// <summary>
        /// Gets or sets the area_total_permeable.
        /// </summary>
        public decimal area_total_permeable { get; set; }

        /// <summary>
        /// Gets or sets the city_id.
        /// </summary>
        public string city_id { get; set; }

        /// <summary>
        /// Gets or sets the comments.
        /// </summary>
        public string comments { get; set; }

        /// <summary>
        /// Gets or sets the contact 1.
        /// </summary>
        public string contact1 { get; set; }

        /// <summary>
        /// Gets or sets the contact 2.
        /// </summary>
        public string contact2 { get; set; }

        /// <summary>
        /// Gets or sets the cost_irr.
        /// </summary>
        public decimal cost_irr { get; set; }

        /// <summary>
        /// Gets or sets the cost_operating_total.
        /// </summary>
        public decimal cost_operating_total { get; set; }

        /// <summary>
        /// Gets or sets the cost_other_total.
        /// </summary>
        public decimal cost_other_total { get; set; }

        /// <summary>
        /// Gets or sets the cost_purchase.
        /// </summary>
        public decimal cost_purchase { get; set; }

        /// <summary>
        /// Gets or sets the cost_roi.
        /// </summary>
        public decimal cost_roi { get; set; }

        /// <summary>
        /// Gets or sets the cost_selling.
        /// </summary>
        public decimal cost_selling { get; set; }

        /// <summary>
        /// Gets or sets the cost_tax_total.
        /// </summary>
        public decimal cost_tax_total { get; set; }

        /// <summary>
        /// Gets or sets the cost_utility_total.
        /// </summary>
        public decimal cost_utility_total { get; set; }

        /// <summary>
        /// Gets or sets the county_id.
        /// </summary>
        public string county_id { get; set; }

        /// <summary>
        /// Gets or sets the ctry_id.
        /// </summary>
        public string ctry_id { get; set; }

        /// <summary>
        /// Gets or sets the date_book_val.
        /// </summary>
        public DateTime? date_book_val { get; set; }

        /// <summary>
        /// Gets or sets the date_costs_end.
        /// </summary>
        public DateTime? date_costs_end { get; set; }

        /// <summary>
        /// Gets or sets the date_costs_last_calcd.
        /// </summary>
        public DateTime? date_costs_last_calcd { get; set; }

        /// <summary>
        /// Gets or sets the date_costs_start.
        /// </summary>
        public DateTime? date_costs_start { get; set; }

        /// <summary>
        /// Gets or sets the date_market_val.
        /// </summary>
        public DateTime? date_market_val { get; set; }

        /// <summary>
        /// Gets or sets the date_purchase.
        /// </summary>
        public DateTime? date_purchase { get; set; }

        /// <summary>
        /// Gets or sets the date_sold.
        /// </summary>
        public DateTime? date_sold { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Gets or sets the detail_dwg.
        /// </summary>
        public string detail_dwg { get; set; }

        /// <summary>
        /// Gets or sets the dwgname.
        /// </summary>
        public string dwgname { get; set; }

        /// <summary>
        /// Gets or sets the ehandle.
        /// </summary>
        public string ehandle { get; set; }

        /// <summary>
        /// Gets or sets the fronts.
        /// </summary>
        public string fronts { get; set; }

        /// <summary>
        /// Gets or sets the geo_objectid.
        /// </summary>
        public int? geo_objectid { get; set; }

        /// <summary>
        /// Gets or sets the grp_uid.
        /// </summary>
        public string grp_uid { get; set; }

        /// <summary>
        /// Gets or sets the image_file.
        /// </summary>
        public string image_file { get; set; }

        /// <summary>
        /// Gets or sets the image_map.
        /// </summary>
        public string image_map { get; set; }

        /// <summary>
        /// Gets or sets the income_total.
        /// </summary>
        public decimal income_total { get; set; }

        /// <summary>
        /// Gets or sets the int_dist.
        /// </summary>
        public decimal? int_dist { get; set; }

        /// <summary>
        /// Gets or sets the int_name.
        /// </summary>
        public string int_name { get; set; }

        /// <summary>
        /// Gets or sets the land_is.
        /// </summary>
        public string land_is { get; set; }

        /// <summary>
        /// Gets or sets the lat.
        /// </summary>
        public decimal? lat { get; set; }

        /// <summary>
        /// Gets or sets the lon.
        /// </summary>
        public decimal? lon { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the option 1.
        /// </summary>
        public string option1 { get; set; }

        /// <summary>
        /// Gets or sets the option 2.
        /// </summary>
        public string option2 { get; set; }

        /// <summary>
        /// Gets or sets the other_name.
        /// </summary>
        public string other_name { get; set; }

        /// <summary>
        /// Gets or sets the pct_own.
        /// </summary>
        public decimal? pct_own { get; set; }

        /// <summary>
        /// Gets or sets the prop_is.
        /// </summary>
        public string prop_is { get; set; }

        /// <summary>
        /// Gets or sets the prop_photo.
        /// </summary>
        public string prop_photo { get; set; }

        /// <summary>
        /// Gets or sets the property_type.
        /// </summary>
        public string property_type { get; set; }

        /// <summary>
        /// Gets or sets the purchased_from.
        /// </summary>
        public string purchased_from { get; set; }

        /// <summary>
        /// Gets or sets the qty_headcount.
        /// </summary>
        public int qty_headcount { get; set; }

        /// <summary>
        /// Gets or sets the qty_no_bldgs.
        /// </summary>
        public int qty_no_bldgs { get; set; }

        /// <summary>
        /// Gets or sets the qty_no_bldgs_calc.
        /// </summary>
        public int qty_no_bldgs_calc { get; set; }

        /// <summary>
        /// Gets or sets the qty_no_spaces.
        /// </summary>
        public int qty_no_spaces { get; set; }

        /// <summary>
        /// Gets or sets the qty_no_spaces_calc.
        /// </summary>
        public int qty_no_spaces_calc { get; set; }

        /// <summary>
        /// Gets or sets the qty_occupancy.
        /// </summary>
        public int qty_occupancy { get; set; }

        /// <summary>
        /// Gets or sets the qty_su_occupancy.
        /// </summary>
        public int qty_su_occupancy { get; set; }

        /// <summary>
        /// Gets or sets the regn_id.
        /// </summary>
        public string regn_id { get; set; }

        /// <summary>
        /// Gets or sets the selling_broker.
        /// </summary>
        public string selling_broker { get; set; }

        /// <summary>
        /// Gets or sets the selling_commission.
        /// </summary>
        public decimal selling_commission { get; set; }

        /// <summary>
        /// Gets or sets the services.
        /// </summary>
        public string services { get; set; }

        /// <summary>
        /// Gets or sets the site_id.
        /// </summary>
        public string site_id { get; set; }

        /// <summary>
        /// Gets or sets the sold_to.
        /// </summary>
        public string sold_to { get; set; }

        /// <summary>
        /// Gets or sets the state_id.
        /// </summary>
        public string state_id { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// Gets or sets the street.
        /// </summary>
        public string street { get; set; }

        /// <summary>
        /// Gets or sets the tax_rate_prop.
        /// </summary>
        public decimal tax_rate_prop { get; set; }

        /// <summary>
        /// Gets or sets the tax_rate_school.
        /// </summary>
        public decimal tax_rate_school { get; set; }

        /// <summary>
        /// Gets or sets the unit.
        /// </summary>
        public string unit { get; set; }

        /// <summary>
        /// Gets or sets the use 1.
        /// </summary>
        public string use1 { get; set; }

        /// <summary>
        /// Gets or sets the value_assessed_prop_tax.
        /// </summary>
        public decimal value_assessed_prop_tax { get; set; }

        /// <summary>
        /// Gets or sets the value_assessed_school_tax.
        /// </summary>
        public decimal value_assessed_school_tax { get; set; }

        /// <summary>
        /// Gets or sets the value_book.
        /// </summary>
        public decimal value_book { get; set; }

        /// <summary>
        /// Gets or sets the value_market.
        /// </summary>
        public decimal value_market { get; set; }

        /// <summary>
        /// Gets or sets the vicinity.
        /// </summary>
        public string vicinity { get; set; }

        /// <summary>
        /// Gets or sets the zip.
        /// </summary>
        public string zip { get; set; }

        /// <summary>
        /// Gets or sets the zoning.
        /// </summary>
        public string zoning { get; set; }

        /// <summary>
        /// Gets or sets the pr_id.
        /// </summary>
        public string pr_id { get; set; }

        /// <summary>
        /// Gets or sets the ac.
        /// </summary>
        public virtual ac ac { get; set; }

        /// <summary>
        /// Gets or sets the activity_log.
        /// </summary>
        public virtual ICollection<activity_log> activity_log { get; set; }

        /// <summary>
        /// Gets or sets the bls.
        /// </summary>
        public virtual ICollection<bl> bls { get; set; }

        /// <summary>
        /// Gets or sets the budget_item.
        /// </summary>
        public virtual ICollection<budget_item> budget_item { get; set; }

        /// <summary>
        /// Gets or sets the ccost_sum.
        /// </summary>
        public virtual ICollection<ccost_sum> ccost_sum { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        public virtual City city { get; set; }

        /// <summary>
        /// Gets or sets the compliance_locations.
        /// </summary>
        public virtual ICollection<compliance_locations> compliance_locations { get; set; }

        /// <summary>
        /// Gets or sets the contacts.
        /// </summary>
        public virtual ICollection<Contact> contacts { get; set; }

        /// <summary>
        /// Gets or sets the cost_tran_recur.
        /// </summary>
        public virtual ICollection<cost_tran_recur> cost_tran_recur { get; set; }

        /// <summary>
        /// Gets or sets the cost_tran_sched.
        /// </summary>
        public virtual ICollection<cost_tran_sched> cost_tran_sched { get; set; }

        /// <summary>
        /// Gets or sets the county.
        /// </summary>
        public virtual County county { get; set; }

        /// <summary>
        /// Gets or sets the ctry.
        /// </summary>
        public virtual ctry ctry { get; set; }

        /// <summary>
        /// Gets or sets the docs_assigned.
        /// </summary>
        public virtual ICollection<docs_assigned> docs_assigned { get; set; }

        /// <summary>
        /// Gets or sets the ehs_incidents.
        /// </summary>
        public virtual ICollection<ehs_incidents> ehs_incidents { get; set; }

        /// <summary>
        /// Gets or sets the ehs_incidents_sync.
        /// </summary>
        public virtual ICollection<ehs_incidents_sync> ehs_incidents_sync { get; set; }

        /// <summary>
        /// Gets or sets the eqs.
        /// </summary>
        public virtual ICollection<eq> eqs { get; set; }

        /// <summary>
        /// Gets or sets the invoices.
        /// </summary>
        public virtual ICollection<invoice> invoices { get; set; }

        /// <summary>
        /// Gets or sets the ls.
        /// </summary>
        public virtual ICollection<l> ls { get; set; }

        /// <summary>
        /// Gets or sets the ots.
        /// </summary>
        public virtual ICollection<ot> ots { get; set; }

        /// <summary>
        /// Gets or sets the pas.
        /// </summary>
        public virtual ICollection<pa> pas { get; set; }

        /// <summary>
        /// Gets or sets the pa_dep.
        /// </summary>
        public virtual ICollection<pa_dep> pa_dep { get; set; }

        /// <summary>
        /// Gets or sets the parcels.
        /// </summary>
        public virtual ICollection<parcel> parcels { get; set; }

        /// <summary>
        /// Gets or sets the parkings.
        /// </summary>
        public virtual ICollection<parking> parkings { get; set; }

        /// <summary>
        /// Gets or sets the prop_amenity.
        /// </summary>
        public virtual ICollection<prop_amenity> prop_amenity { get; set; }

        /// <summary>
        /// Gets or sets the regn.
        /// </summary>
        public virtual regn regn { get; set; }

        /// <summary>
        /// Gets or sets the site.
        /// </summary>
        public virtual site site { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        public virtual state state { get; set; }

        /// <summary>
        /// Gets or sets the regcompliances.
        /// </summary>
        public virtual ICollection<regcompliance> regcompliances { get; set; }

        /// <summary>
        /// Gets or sets the runoffareas.
        /// </summary>
        public virtual ICollection<runoffarea> runoffareas { get; set; }

        /// <summary>
        /// Gets or sets the waste_areas.
        /// </summary>
        public virtual ICollection<waste_areas> waste_areas { get; set; }

        /// <summary>
        /// Gets or sets the waste_generators.
        /// </summary>
        public virtual ICollection<waste_generators> waste_generators { get; set; }

        /// <summary>
        /// Gets or sets the work_roles_location.
        /// </summary>
        public virtual ICollection<work_roles_location> work_roles_location { get; set; }
    }
}