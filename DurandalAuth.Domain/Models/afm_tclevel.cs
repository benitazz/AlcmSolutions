using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_tclevel
    {
        public afm_tclevel()
        {
            this.cas = new List<ca>();
            this.cards = new List<card>();
            this.cardstds = new List<cardstd>();
            this.castds = new List<castd>();
            this.cdports = new List<cdport>();
            this.cps = new List<cp>();
            this.ems = new List<Em>();
            this.eqs = new List<eq>();
            this.eqports = new List<eqport>();
            this.eqstds = new List<eqstd>();
            this.fps = new List<fp>();
            this.fpstds = new List<fpstd>();
            this.jks = new List<jk>();
            this.jkcfgs = new List<jkcfg>();
            this.jkstds = new List<jkstd>();
            this.ndports = new List<ndport>();
            this.netdevs = new List<netdev>();
            this.netdevstds = new List<netdevstd>();
            this.pbs = new List<pb>();
            this.pbstds = new List<pbstd>();
            this.pns = new List<pn>();
            this.pnports = new List<pnport>();
            this.pnstds = new List<pnstd>();
            this.ports = new List<port>();
            this.portcfgs = new List<portcfg>();
            this.portstds = new List<portstd>();
            this.racks = new List<rack>();
            this.rms = new List<Rm>();
            this.wies = new List<wy>();
        }

        public string description { get; set; }
        public string eia_level { get; set; }
        public string tc_service { get; set; }
        public string transfer_status { get; set; }
        public string tc_level { get; set; }
        public virtual ICollection<ca> cas { get; set; }
        public virtual ICollection<card> cards { get; set; }
        public virtual ICollection<cardstd> cardstds { get; set; }
        public virtual ICollection<castd> castds { get; set; }
        public virtual ICollection<cdport> cdports { get; set; }
        public virtual ICollection<cp> cps { get; set; }
        public virtual ICollection<Em> ems { get; set; }
        public virtual ICollection<eq> eqs { get; set; }
        public virtual ICollection<eqport> eqports { get; set; }
        public virtual ICollection<eqstd> eqstds { get; set; }
        public virtual ICollection<fp> fps { get; set; }
        public virtual ICollection<fpstd> fpstds { get; set; }
        public virtual ICollection<jk> jks { get; set; }
        public virtual ICollection<jkcfg> jkcfgs { get; set; }
        public virtual ICollection<jkstd> jkstds { get; set; }
        public virtual ICollection<ndport> ndports { get; set; }
        public virtual ICollection<netdev> netdevs { get; set; }
        public virtual ICollection<netdevstd> netdevstds { get; set; }
        public virtual ICollection<pb> pbs { get; set; }
        public virtual ICollection<pbstd> pbstds { get; set; }
        public virtual ICollection<pn> pns { get; set; }
        public virtual ICollection<pnport> pnports { get; set; }
        public virtual ICollection<pnstd> pnstds { get; set; }
        public virtual ICollection<port> ports { get; set; }
        public virtual ICollection<portcfg> portcfgs { get; set; }
        public virtual ICollection<portstd> portstds { get; set; }
        public virtual ICollection<rack> racks { get; set; }
        public virtual ICollection<Rm> rms { get; set; }
        public virtual ICollection<wy> wies { get; set; }
    }
}
