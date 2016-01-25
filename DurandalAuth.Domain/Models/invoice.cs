using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class invoice
    {
        public invoice()
        {
            this.invoice_payment = new List<invoice_payment>();
        }

        public string ac_id { get; set; }
        public decimal amount_approved { get; set; }
        public Nullable<decimal> amount_base_invoice { get; set; }
        public decimal amount_billed { get; set; }
        public decimal amount_billed_total { get; set; }
        public decimal amount_closed { get; set; }
        public decimal amount_deficiency { get; set; }
        public decimal amount_deficiency_tax { get; set; }
        public decimal amount_lien { get; set; }
        public decimal amount_lien_tax { get; set; }
        public decimal amount_reimbursable { get; set; }
        public decimal amount_tax { get; set; }
        public decimal amount_tot_invoice { get; set; }
        public Nullable<decimal> amount_vat_invoice { get; set; }
        public string bl_id { get; set; }
        public string contact_id_remit_to { get; set; }
        public string contact_id_send_to { get; set; }
        public string currency_invoice { get; set; }
        public Nullable<System.DateTime> date_expected_rec { get; set; }
        public Nullable<System.DateTime> date_sent { get; set; }
        public string description { get; set; }
        public string doc { get; set; }
        public string fac_org_level_01 { get; set; }
        public string fac_org_level_02 { get; set; }
        public string fac_org_level_03 { get; set; }
        public string fac_org_level_04 { get; set; }
        public string fac_org_level_05 { get; set; }
        public string fac_org_level_06 { get; set; }
        public string ls_id { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string pr_id { get; set; }
        public string project_id { get; set; }
        public decimal qty_accepted { get; set; }
        public decimal qty_invoiced { get; set; }
        public decimal qty_received { get; set; }
        public string status { get; set; }
        public decimal tax_rate { get; set; }
        public string terms { get; set; }
        public string vn_id { get; set; }
        public string vn_invoice_num { get; set; }
        public string work_pkg_id { get; set; }
        public int invoice_id { get; set; }
        public virtual ac ac { get; set; }
        public virtual afm_currencies afm_currencies { get; set; }
        public virtual bl bl { get; set; }
        public virtual Contact contact { get; set; }
        public virtual Contact contact1 { get; set; }
        public virtual l l { get; set; }
        public virtual ICollection<invoice_payment> invoice_payment { get; set; }
        public virtual Property property { get; set; }
        public virtual project project { get; set; }
        public virtual vn vn { get; set; }
        public virtual work_pkgs work_pkgs { get; set; }
    }
}
