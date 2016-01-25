using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class gb_fp_totals
    {
        public decimal s_other { get; set; }
        public decimal s1_co_airc { get; set; }
        public decimal s1_co_road { get; set; }
        public decimal s1_fuel_comb { get; set; }
        public decimal s1_refrig_airc { get; set; }
        public decimal s2_purch_e { get; set; }
        public decimal s3_cont { get; set; }
        public decimal s3_em_air { get; set; }
        public decimal s3_em_rail { get; set; }
        public decimal s3_em_road { get; set; }
        public decimal s3_mat { get; set; }
        public decimal s3_outs { get; set; }
        public decimal s3_serv { get; set; }
        public decimal s3_waste_liq { get; set; }
        public decimal s3_waste_sol { get; set; }
        public decimal total { get; set; }
        public decimal total_s1_s2_s_other { get; set; }
        public string bl_id { get; set; }
        public short calc_year { get; set; }
        public string scenario_id { get; set; }
        public virtual gb_fp_setup gb_fp_setup { get; set; }
    }
}
