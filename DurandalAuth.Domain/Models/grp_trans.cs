using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class grp_trans
    {
        public Nullable<short> grp_type_id { get; set; }
        public Nullable<short> grp_use_id { get; set; }
        public Nullable<short> historical_status { get; set; }
        public string installation_identifier { get; set; }
        public string installation_name { get; set; }
        public string latitude { get; set; }
        public string lease_authority_id { get; set; }
        public string lease_id { get; set; }
        public string lease_maintenance_ind { get; set; }
        public string lease_option_to_term_early { get; set; }
        public string legal_interest_ind { get; set; }
        public string longitude { get; set; }
        public Nullable<short> mission_dependency { get; set; }
        public Nullable<decimal> net_proceeds { get; set; }
        public string outgrant_indicator { get; set; }
        public string real_property_name { get; set; }
        public string recipient { get; set; }
        public string reporting_grp_agency_id { get; set; }
        public string restrictions { get; set; }
        public string sale_candidate { get; set; }
        public Nullable<decimal> size_gross_area { get; set; }
        public Nullable<decimal> size_rural_acres { get; set; }
        public Nullable<decimal> size_structural_unit { get; set; }
        public Nullable<short> size_unit_of_measure { get; set; }
        public Nullable<decimal> size_urban_acres { get; set; }
        public string state { get; set; }
        public string status { get; set; }
        public string status_indicator { get; set; }
        public string street_address { get; set; }
        public string sub_installation_identifier { get; set; }
        public Nullable<short> sustainability { get; set; }
        public Nullable<System.DateTime> time_of_app_rej { get; set; }
        public System.DateTime time_of_transaction { get; set; }
        public string trans_type { get; set; }
        public string unique_identifier { get; set; }
        public string user_name_app_rej { get; set; }
        public string user_name_requestor { get; set; }
        public string using_grp_agency_id { get; set; }
        public Nullable<short> utilization { get; set; }
        public Nullable<decimal> value { get; set; }
        public string zip_code { get; set; }
        public Nullable<decimal> annual_operating_costs { get; set; }
        public Nullable<decimal> btu_consumption { get; set; }
        public string city { get; set; }
        public string comments { get; set; }
        public Nullable<short> condition_index { get; set; }
        public string congressional_district { get; set; }
        public Nullable<int> count_emp_contractor { get; set; }
        public Nullable<int> count_emp_fed { get; set; }
        public Nullable<int> count_emp_fed_telework { get; set; }
        public string country { get; set; }
        public string county { get; set; }
        public Nullable<System.DateTime> date_lease_expiration { get; set; }
        public Nullable<System.DateTime> date_of_app_rej { get; set; }
        public System.DateTime date_of_transaction { get; set; }
        public string description_of_change { get; set; }
        public string dispos_anticipated { get; set; }
        public string dispos_anticipated_method { get; set; }
        public Nullable<System.DateTime> disposition_date { get; set; }
        public string disposition_method_id { get; set; }
        public Nullable<decimal> disposition_value { get; set; }
        public string excess_is_anticipated { get; set; }
        public int grp_trans_id { get; set; }
        public Nullable<short> sale_anticipated_year { get; set; }
        public Nullable<short> dispos_anticipated_year { get; set; }
        public Nullable<short> excess_anticipated_year { get; set; }
        public virtual afm_users afm_users { get; set; }
        public virtual afm_users afm_users1 { get; set; }
        public virtual grp_agency grp_agency { get; set; }
        public virtual grp_agency grp_agency1 { get; set; }
        public virtual grp_type grp_type { get; set; }
        public virtual grp_use grp_use { get; set; }
    }
}
