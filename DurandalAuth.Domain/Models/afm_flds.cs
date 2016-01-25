using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_flds
    {
        public afm_flds()
        {
            this.afm_activities = new List<afm_activities>();
            this.afm_activities1 = new List<afm_activities>();
            this.afm_activities2 = new List<afm_activities>();
            this.afm_bim_params = new List<afm_bim_params>();
            this.afm_docs = new List<afm_docs>();
            this.afm_docvers = new List<afm_docvers>();
            this.afm_dwgpub = new List<afm_dwgpub>();
            this.afm_metric_definitions = new List<afm_metric_definitions>();
            this.afm_metric_definitions1 = new List<afm_metric_definitions>();
            this.helpdesk_step_log = new List<helpdesk_step_log>();
            this.questionnaires = new List<questionnaire>();
            this.questions = new List<question>();
            this.status_log = new List<status_log>();
        }

        public string table_name { get; set; }
        public string field_name { get; set; }
        public short afm_type { get; set; }
        public short allow_null { get; set; }
        public string comments { get; set; }
        public short data_type { get; set; }
        public short decimals { get; set; }
        public string dep_cols { get; set; }
        public string dflt_val { get; set; }
        public string edit_group { get; set; }
        public string edit_mask { get; set; }
        public string enum_list { get; set; }
        public short is_atxt { get; set; }
        public string max_val { get; set; }
        public string min_val { get; set; }
        public string ml_heading { get; set; }
        public Nullable<short> afm_module { get; set; }
        public short num_format { get; set; }
        public short primary_key { get; set; }
        public string ref_table { get; set; }
        public string review_group { get; set; }
        public short afm_size { get; set; }
        public string sl_heading { get; set; }
        public short string_format { get; set; }
        public short is_tc_traceable { get; set; }
        public string field_grouping { get; set; }
        public string attributes { get; set; }
        public short validate_data { get; set; }
        public string transfer_status { get; set; }
        public virtual ICollection<afm_activities> afm_activities { get; set; }
        public virtual ICollection<afm_activities> afm_activities1 { get; set; }
        public virtual ICollection<afm_activities> afm_activities2 { get; set; }
        public virtual ICollection<afm_bim_params> afm_bim_params { get; set; }
        public virtual ICollection<afm_docs> afm_docs { get; set; }
        public virtual ICollection<afm_docvers> afm_docvers { get; set; }
        public virtual ICollection<afm_dwgpub> afm_dwgpub { get; set; }
        public virtual afm_groups afm_groups { get; set; }
        public virtual afm_flds_lang afm_flds_lang { get; set; }
        public virtual afm_tbls afm_tbls { get; set; }
        public virtual afm_groups afm_groups1 { get; set; }
        public virtual afm_tbls afm_tbls1 { get; set; }
        public virtual ICollection<afm_metric_definitions> afm_metric_definitions { get; set; }
        public virtual ICollection<afm_metric_definitions> afm_metric_definitions1 { get; set; }
        public virtual ICollection<helpdesk_step_log> helpdesk_step_log { get; set; }
        public virtual ICollection<questionnaire> questionnaires { get; set; }
        public virtual ICollection<question> questions { get; set; }
        public virtual ICollection<status_log> status_log { get; set; }
    }
}
