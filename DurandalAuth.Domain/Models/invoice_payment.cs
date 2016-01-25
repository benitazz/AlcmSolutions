using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class invoice_payment
    {
        public decimal amount_expense { get; set; }
        public decimal amount_income { get; set; }
        public string check_number { get; set; }
        public string contact_id { get; set; }
        public string currency_invoice { get; set; }
        public System.DateTime date_paid { get; set; }
        public System.DateTime date_trans_created { get; set; }
        public string description { get; set; }
        public Nullable<int> invoice_id { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string payment_method { get; set; }
        public int payment_id { get; set; }
        public virtual afm_currencies afm_currencies { get; set; }
        public virtual Contact contact { get; set; }
        public virtual invoice invoice { get; set; }
    }
}
