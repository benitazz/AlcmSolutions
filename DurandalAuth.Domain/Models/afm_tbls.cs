using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_tbls
    {
        public afm_tbls()
        {
            this.afm_act_tbls = new List<afm_act_tbls>();
            this.afm_activities = new List<afm_activities>();
            this.afm_atyp = new List<afm_atyp>();
            this.afm_bim_families = new List<afm_bim_families>();
            this.afm_bim_params = new List<afm_bim_params>();
            this.afm_conn_flds = new List<afm_conn_flds>();
            this.afm_connector = new List<afm_connector>();
            this.afm_docs = new List<afm_docs>();
            this.afm_docvers = new List<afm_docvers>();
            this.afm_dwgpub = new List<afm_dwgpub>();
            this.afm_dwgpub1 = new List<afm_dwgpub>();
            this.afm_flds = new List<afm_flds>();
            this.afm_flds1 = new List<afm_flds>();
            this.afm_flds_lang = new List<afm_flds_lang>();
            this.afm_metric_definitions = new List<afm_metric_definitions>();
            this.afm_tbl_map = new List<afm_tbl_map>();
            this.afm_tccn = new List<afm_tccn>();
            this.afm_tccn1 = new List<afm_tccn>();
            this.helpdesk_step_log = new List<helpdesk_step_log>();
            this.projteams = new List<ProjectTeam>();
            this.questionnaires = new List<questionnaire>();
            this.questions = new List<question>();
            this.status_log = new List<status_log>();
        }

        public string table_name { get; set; }
        public string comments { get; set; }
        public Nullable<short> afm_module { get; set; }
        public string title { get; set; }
        public short is_sql_view { get; set; }
        public string title_ch { get; set; }
        public string title_de { get; set; }
        public string title_es { get; set; }
        public string title_fr { get; set; }
        public string title_it { get; set; }
        public string title_jp { get; set; }
        public string title_ko { get; set; }
        public string title_nl { get; set; }
        public string title_no { get; set; }
        public string title_zh { get; set; }
        public string title_01 { get; set; }
        public string title_02 { get; set; }
        public string title_03 { get; set; }
        public string default_view { get; set; }
        public string table_type { get; set; }
        public string transfer_status { get; set; }
        public virtual ICollection<afm_act_tbls> afm_act_tbls { get; set; }
        public virtual ICollection<afm_activities> afm_activities { get; set; }
        public virtual ICollection<afm_atyp> afm_atyp { get; set; }
        public virtual afm_atyp afm_atyp1 { get; set; }
        public virtual ICollection<afm_bim_families> afm_bim_families { get; set; }
        public virtual ICollection<afm_bim_params> afm_bim_params { get; set; }
        public virtual ICollection<afm_conn_flds> afm_conn_flds { get; set; }
        public virtual ICollection<afm_connector> afm_connector { get; set; }
        public virtual ICollection<afm_docs> afm_docs { get; set; }
        public virtual ICollection<afm_docvers> afm_docvers { get; set; }
        public virtual ICollection<afm_dwgpub> afm_dwgpub { get; set; }
        public virtual ICollection<afm_dwgpub> afm_dwgpub1 { get; set; }
        public virtual ICollection<afm_flds> afm_flds { get; set; }
        public virtual ICollection<afm_flds> afm_flds1 { get; set; }
        public virtual ICollection<afm_flds_lang> afm_flds_lang { get; set; }
        public virtual ICollection<afm_metric_definitions> afm_metric_definitions { get; set; }
        public virtual ICollection<afm_tbl_map> afm_tbl_map { get; set; }
        public virtual ICollection<afm_tccn> afm_tccn { get; set; }
        public virtual ICollection<afm_tccn> afm_tccn1 { get; set; }
        public virtual ICollection<helpdesk_step_log> helpdesk_step_log { get; set; }
        public virtual ICollection<ProjectTeam> projteams { get; set; }
        public virtual ICollection<questionnaire> questionnaires { get; set; }
        public virtual ICollection<question> questions { get; set; }
        public virtual ICollection<status_log> status_log { get; set; }
    }
}
