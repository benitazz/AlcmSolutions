#region

using System;
using System.Collections.Generic;

#endregion

namespace DurandalAuth.Domain.Models
{
    public partial class Pm
    {
        public Pm()
        {
            this.Pmsds = new List<pmsd>();
            this.Wrs = new List<wr>();
        }

        public string bl_id { get; set; }

        public string Comments { get; set; }

        public DateTime DateFirstTodo { get; set; }

        public DateTime? DateLastCompleted { get; set; }

        public DateTime? DateNextAltTodo { get; set; }

        public DateTime? DateNextTodo { get; set; }

        public string dp_id { get; set; }

        public string dv_id { get; set; }

        public string EqId { get; set; }

        public short FixedType { get; set; }

        public string fl_id { get; set; }

        public decimal HoursCalc { get; set; }

        public decimal HoursEst { get; set; }

        public int Interval1 { get; set; }

        public int Interval2 { get; set; }

        public int Interval3 { get; set; }

        public int Interval4 { get; set; }

        public short IntervalFreq { get; set; }

        public string IntervalType { get; set; }

        public decimal MeterLastPm { get; set; }

        public short Nactive { get; set; }

        public string Option1 { get; set; }

        public string Option2 { get; set; }

        public string PmGroup { get; set; }

        public string PmpId { get; set; }

        public short Priority { get; set; }

        public string rm_id { get; set; }

        public string SiteId { get; set; }

        public decimal TotalUnit { get; set; }

        public string Units { get; set; }

        public int PmsId { get; set; }

        public virtual bl Bl { get; set; }

        public virtual dp Dp { get; set; }

        public virtual dv Dv { get; set; }

        public virtual eq Eq { get; set; }

        public virtual Fl Fl { get; set; }

        public virtual pmgp Pmgp { get; set; }

        public virtual pmp Pmp { get; set; }

        public virtual Rm Rm { get; set; }

        public virtual site Site { get; set; }

        public virtual ICollection<pmsd> Pmsds { get; set; }

        public virtual ICollection<wr> Wrs { get; set; }
    }
}