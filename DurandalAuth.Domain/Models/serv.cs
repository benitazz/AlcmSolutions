using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class serv
    {
        public decimal area { get; set; }
        public string bl_id { get; set; }
        public string dwgname { get; set; }
        public string ehandle { get; set; }
        public string fl_id { get; set; }
        public string layer_name { get; set; }
        public string prorate { get; set; }
        public string serv_num { get; set; }
        public string serv_std { get; set; }
        public int serv_id { get; set; }
        public virtual bl bl { get; set; }
        public virtual Fl fl { get; set; }
        public virtual servstd servstd { get; set; }
    }
}
