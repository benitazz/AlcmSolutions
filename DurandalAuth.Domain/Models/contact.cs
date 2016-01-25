#region

using System.Collections.Generic;

#endregion

namespace DurandalAuth.Domain.Models
{
    /// <summary>
    /// The contact.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class.
        /// </summary>
        public Contact()
        {
            this.ActivityLog = new List<activity_log>();
            this.CbAccreditPerson = new List<cb_accredit_person>();
            this.CostTranSched = new List<cost_tran_sched>();
            this.EhsIncidentWitness = new List<ehs_incident_witness>();
            this.EhsIncidentWitnessSync = new List<ehs_incident_witness_sync>();
            this.EhsIncidents = new List<ehs_incidents>();
            this.EhsIncidentsSync = new List<ehs_incidents_sync>();
            this.Invoices = new List<invoice>();
            this.Invoices1 = new List<invoice>();
            this.InvoicePayment = new List<invoice_payment>();
            this.LsComm = new List<ls_comm>();
            this.LsResp = new List<ls_resp>();
            this.Orgs = new List<org>();
            this.Projects = new List<project>();
            this.Regcompliances = new List<regcompliance>();
            this.Regprograms = new List<regprogram>();
            this.Regrequirements = new List<regrequirement>();
            this.SystemBl = new List<system_bl>();
            this.WasteGenerators = new List<waste_generators>();
            this.WorkPkgBids = new List<work_pkg_bids>();
            this.Ls = new List<l>();
        }

        /// <summary>
        /// Gets or sets the contact photo.
        /// </summary>
        /// <value>
        /// The contact photo.
        /// </value>
        public string ContactPhoto { get; set; }

        /// <summary>
        /// Gets or sets the contact_type.
        /// </summary>
        public string ContactType { get; set; }

        /// <summary>
        /// Gets or sets the county_id.
        /// </summary>
        public string county_id { get; set; }

        /// <summary>
        /// Gets or sets the ctry_id.
        /// </summary>
        public string ctry_id { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the fax.
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        /// Gets or sets the honorific.
        /// </summary>
        public string Honorific { get; set; }

        /// <summary>
        /// Gets or sets the image_file.
        /// </summary>
        public string ImageFile { get; set; }

        /// <summary>
        /// Gets or sets the ls_id.
        /// </summary>
        public string LsId { get; set; }

        /// <summary>
        /// Gets or sets the name_first.
        /// </summary>
        public string NameFirst { get; set; }

        /// <summary>
        /// Gets or sets the name_last.
        /// </summary>
        public string NameLast { get; set; }

        /// <summary>
        /// Gets or sets the notes.
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Gets or sets the option 1.
        /// </summary>
        public string Option1 { get; set; }

        /// <summary>
        /// Gets or sets the option 2.
        /// </summary>
        public string Option2 { get; set; }

        /// <summary>
        /// Gets or sets the pager.
        /// </summary>
        public string Pager { get; set; }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the pin.
        /// </summary>
        public string Pin { get; set; }

        /// <summary>
        /// Gets or sets the pr_id.
        /// </summary>
        public string PrId { get; set; }

        /// <summary>
        /// Gets or sets the regn_id.
        /// </summary>
        public string regn_id { get; set; }

        /// <summary>
        /// Gets or sets the state_id.
        /// </summary>
        public string state_id { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the tax_auth_type.
        /// </summary>
        public string TaxAuthType { get; set; }

        /// <summary>
        /// Gets or sets the zip.
        /// </summary>
        public string Zip { get; set; }

        /// <summary>
        /// Gets or sets the address 1.
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or sets the address 2.
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or sets the bl_id.
        /// </summary>
        public string bl_id { get; set; }

        /// <summary>
        /// Gets or sets the cellular_number.
        /// </summary>
        public string CellularNumber { get; set; }

        /// <summary>
        /// Gets or sets the city_id.
        /// </summary>
        public string city_id { get; set; }

        /// <summary>
        /// Gets or sets the company.
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// Gets or sets the contact_id.
        /// </summary>
        public string ContactId { get; set; }

        /// <summary>
        /// Gets or sets the activity_log.
        /// </summary>
        public ICollection<activity_log> ActivityLog { get; set; }

        /// <summary>
        /// Gets or sets the bl.
        /// </summary>
        public bl Bl { get; set; }

        /// <summary>
        /// Gets or sets the cb_accredit_person.
        /// </summary>
        public ICollection<cb_accredit_person> CbAccreditPerson { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        public City City { get; set; }

        /// <summary>
        /// Gets or sets the company 1.
        /// </summary>
        public Company Company1 { get; set; }

        /// <summary>
        /// Gets or sets the county.
        /// </summary>
        public County County { get; set; }

        /// <summary>
        /// Gets or sets the ctry.
        /// </summary>
        public ctry Ctry { get; set; }

        /// <summary>
        /// Gets or sets the l.
        /// </summary>
        public l l { get; set; }

        /// <summary>
        /// Gets or sets the property.
        /// </summary>
        public Property Property { get; set; }

        /// <summary>
        /// Gets or sets the regn.
        /// </summary>
        public regn Regn { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        public state State { get; set; }

        /// <summary>
        /// Gets or sets the cost_tran_sched.
        /// </summary>
        public ICollection<cost_tran_sched> CostTranSched { get; set; }

        /// <summary>
        /// Gets or sets the ehs_incident_witness.
        /// </summary>
        public ICollection<ehs_incident_witness> EhsIncidentWitness { get; set; }

        /// <summary>
        /// Gets or sets the ehs_incident_witness_sync.
        /// </summary>
        public ICollection<ehs_incident_witness_sync> EhsIncidentWitnessSync { get; set; }

        /// <summary>
        /// Gets or sets the ehs_incidents.
        /// </summary>
        public ICollection<ehs_incidents> EhsIncidents { get; set; }

        /// <summary>
        /// Gets or sets the ehs_incidents_sync.
        /// </summary>
        public ICollection<ehs_incidents_sync> EhsIncidentsSync { get; set; }

        /// <summary>
        /// Gets or sets the invoices.
        /// </summary>
        public ICollection<invoice> Invoices { get; set; }

        /// <summary>
        /// Gets or sets the invoices 1.
        /// </summary>
        public ICollection<invoice> Invoices1 { get; set; }

        /// <summary>
        /// Gets or sets the invoice_payment.
        /// </summary>
        public ICollection<invoice_payment> InvoicePayment { get; set; }

        /// <summary>
        /// Gets or sets the ls_comm.
        /// </summary>
        public ICollection<ls_comm> LsComm { get; set; }

        /// <summary>
        /// Gets or sets the ls_resp.
        /// </summary>
        public ICollection<ls_resp> LsResp { get; set; }

        /// <summary>
        /// Gets or sets the orgs.
        /// </summary>
        public ICollection<org> Orgs { get; set; }

        /// <summary>
        /// Gets or sets the projects.
        /// </summary>
        public ICollection<project> Projects { get; set; }

        /// <summary>
        /// Gets or sets the regcompliances.
        /// </summary>
        public ICollection<regcompliance> Regcompliances { get; set; }

        /// <summary>
        /// Gets or sets the regprograms.
        /// </summary>
        public ICollection<regprogram> Regprograms { get; set; }

        /// <summary>
        /// Gets or sets the regrequirements.
        /// </summary>
        public ICollection<regrequirement> Regrequirements { get; set; }

        /// <summary>
        /// Gets or sets the system_bl.
        /// </summary>
        public ICollection<system_bl> SystemBl { get; set; }

        /// <summary>
        /// Gets or sets the waste_generators.
        /// </summary>
        public ICollection<waste_generators> WasteGenerators { get; set; }

        /// <summary>
        /// Gets or sets the work_pkg_bids.
        /// </summary>
        public ICollection<work_pkg_bids> WorkPkgBids { get; set; }

        /// <summary>
        /// Gets or sets the ls.
        /// </summary>
        public ICollection<l> Ls { get; set; }
    }
}