using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class fnstd
    {
        public fnstd()
        {
            this.fns = new List<fn>();
            this.fn_compinvsur = new List<fn_compinvsur>();
            this.fn_compinvtrial = new List<fn_compinvtrial>();
            this.fn_comptrialtrial = new List<fn_comptrialtrial>();
            this.fn_fnstdcnts = new List<fn_fnstdcnts>();
            this.fn_trial = new List<fn_trial>();
            this.fs = new List<f>();
            this.mo_fncount = new List<mo_fncount>();
            this.mo_ta = new List<mo_ta>();
            this.rmstd_fn = new List<rmstd_fn>();
            this.tas = new List<ta>();
            this.ta_fnstdcnts = new List<ta_fnstdcnts>();
            this.ta_trial = new List<ta_trial>();
        }

        public string catalog_id { get; set; }
        public string category { get; set; }
        public string color { get; set; }
        public decimal cost_moving { get; set; }
        public decimal depth { get; set; }
        public string description { get; set; }
        public string doc_block { get; set; }
        public string doc_graphic { get; set; }
        public string finish { get; set; }
        public decimal height { get; set; }
        public string image_file { get; set; }
        public string image_of_block { get; set; }
        public short is_ergo_comp { get; set; }
        public string mfr_id { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string policy_id { get; set; }
        public Nullable<decimal> price { get; set; }
        public string product_line { get; set; }
        public string symbol { get; set; }
        public string ta_lease_id { get; set; }
        public string warranty_id { get; set; }
        public decimal weight { get; set; }
        public decimal width { get; set; }
        public string fn_std { get; set; }
        public virtual ICollection<fn> fns { get; set; }
        public virtual ICollection<fn_compinvsur> fn_compinvsur { get; set; }
        public virtual ICollection<fn_compinvtrial> fn_compinvtrial { get; set; }
        public virtual ICollection<fn_comptrialtrial> fn_comptrialtrial { get; set; }
        public virtual ICollection<fn_fnstdcnts> fn_fnstdcnts { get; set; }
        public virtual ICollection<fn_trial> fn_trial { get; set; }
        public virtual policy policy { get; set; }
        public virtual ta_lease ta_lease { get; set; }
        public virtual warranty warranty { get; set; }
        public virtual ICollection<f> fs { get; set; }
        public virtual ICollection<mo_fncount> mo_fncount { get; set; }
        public virtual ICollection<mo_ta> mo_ta { get; set; }
        public virtual ICollection<rmstd_fn> rmstd_fn { get; set; }
        public virtual ICollection<ta> tas { get; set; }
        public virtual ICollection<ta_fnstdcnts> ta_fnstdcnts { get; set; }
        public virtual ICollection<ta_trial> ta_trial { get; set; }
    }
}
