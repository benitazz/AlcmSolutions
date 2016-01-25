using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class gb_fp_setup
    {
        public gb_fp_setup()
        {
            this.gb_fp_s_other = new List<gb_fp_s_other>();
            this.gb_fp_s1_co_airc = new List<gb_fp_s1_co_airc>();
            this.gb_fp_s1_fuel_comb = new List<gb_fp_s1_fuel_comb>();
            this.gb_fp_s1_refrig_ac = new List<gb_fp_s1_refrig_ac>();
            this.gb_fp_s1_s3_mobile = new List<gb_fp_s1_s3_mobile>();
            this.gb_fp_s2_purch_e = new List<gb_fp_s2_purch_e>();
            this.gb_fp_s3_em_air = new List<gb_fp_s3_em_air>();
            this.gb_fp_s3_mat = new List<gb_fp_s3_mat>();
            this.gb_fp_s3_outs = new List<gb_fp_s3_outs>();
            this.gb_fp_s3_serv = new List<gb_fp_s3_serv>();
            this.gb_fp_s3_waste_liq = new List<gb_fp_s3_waste_liq>();
            this.gb_fp_s3_waste_sol = new List<gb_fp_s3_waste_sol>();
        }

        public string carbon_version { get; set; }
        public string carbon_version_type { get; set; }
        public string comm_airc_version { get; set; }
        public string comm_airc_version_type { get; set; }
        public int count_occup { get; set; }
        public string egrid_version { get; set; }
        public string egrid_version_type { get; set; }
        public string em_id { get; set; }
        public string emiss_version { get; set; }
        public string emiss_version_type { get; set; }
        public Nullable<short> energystar_rating { get; set; }
        public string fuel_dens_version { get; set; }
        public string fuel_dens_version_type { get; set; }
        public string gwp_version { get; set; }
        public string gwp_version_type { get; set; }
        public string heat_version { get; set; }
        public string heat_version_type { get; set; }
        public string mobile_version { get; set; }
        public string mobile_version_type { get; set; }
        public string oxid_version { get; set; }
        public string oxid_version_type { get; set; }
        public string refrig_version { get; set; }
        public string refrig_version_type { get; set; }
        public string airc_version { get; set; }
        public string airc_version_type { get; set; }
        public decimal area_gross_ext { get; set; }
        public string sector_name { get; set; }
        public string subregion_code { get; set; }
        public string waste_liq_version { get; set; }
        public string waste_liq_version_type { get; set; }
        public string waste_sol_version { get; set; }
        public string waste_sol_version_type { get; set; }
        public string bl_id { get; set; }
        public short calc_year { get; set; }
        public string scenario_id { get; set; }
        public virtual ICollection<gb_fp_s_other> gb_fp_s_other { get; set; }
        public virtual ICollection<gb_fp_s1_co_airc> gb_fp_s1_co_airc { get; set; }
        public virtual ICollection<gb_fp_s1_fuel_comb> gb_fp_s1_fuel_comb { get; set; }
        public virtual ICollection<gb_fp_s1_refrig_ac> gb_fp_s1_refrig_ac { get; set; }
        public virtual ICollection<gb_fp_s1_s3_mobile> gb_fp_s1_s3_mobile { get; set; }
        public virtual ICollection<gb_fp_s2_purch_e> gb_fp_s2_purch_e { get; set; }
        public virtual ICollection<gb_fp_s3_em_air> gb_fp_s3_em_air { get; set; }
        public virtual ICollection<gb_fp_s3_mat> gb_fp_s3_mat { get; set; }
        public virtual ICollection<gb_fp_s3_outs> gb_fp_s3_outs { get; set; }
        public virtual ICollection<gb_fp_s3_serv> gb_fp_s3_serv { get; set; }
        public virtual ICollection<gb_fp_s3_waste_liq> gb_fp_s3_waste_liq { get; set; }
        public virtual ICollection<gb_fp_s3_waste_sol> gb_fp_s3_waste_sol { get; set; }
        public virtual gb_fp_versions gb_fp_versions { get; set; }
        public virtual gb_fp_versions gb_fp_versions1 { get; set; }
        public virtual gb_fp_versions gb_fp_versions2 { get; set; }
        public virtual gb_fp_versions gb_fp_versions3 { get; set; }
        public virtual gb_fp_versions gb_fp_versions4 { get; set; }
        public virtual gb_fp_versions gb_fp_versions5 { get; set; }
        public virtual gb_fp_versions gb_fp_versions6 { get; set; }
        public virtual gb_fp_versions gb_fp_versions7 { get; set; }
        public virtual gb_fp_versions gb_fp_versions8 { get; set; }
        public virtual gb_fp_versions gb_fp_versions9 { get; set; }
        public virtual gb_fp_versions gb_fp_versions10 { get; set; }
        public virtual gb_fp_versions gb_fp_versions11 { get; set; }
        public virtual gb_fp_versions gb_fp_versions12 { get; set; }
        public virtual gb_fp_totals gb_fp_totals { get; set; }
    }
}
