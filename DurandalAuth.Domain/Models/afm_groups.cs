using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_groups
    {
        public afm_groups()
        {
            this.activitytypes = new List<activitytype>();
            this.afm_acts = new List<afm_acts>();
            this.afm_cats = new List<afm_cats>();
            this.afm_class = new List<afm_class>();
            this.afm_flds = new List<afm_flds>();
            this.afm_flds1 = new List<afm_flds>();
            this.afm_groupsforroles = new List<afm_groupsforroles>();
            this.afm_hotlist = new List<afm_hotlist>();
            this.afm_mobile_apps = new List<afm_mobile_apps>();
            this.afm_mobile_menu = new List<afm_mobile_menu>();
            this.afm_mods = new List<afm_mods>();
            this.afm_psubtasks = new List<afm_psubtasks>();
            this.afm_ptasks = new List<afm_ptasks>();
            this.afm_subtasks = new List<afm_subtasks>();
            this.afm_tasks = new List<afm_tasks>();
            this.afm_users = new List<afm_users>();
            this.afm_users1 = new List<afm_users>();
            this.afm_users2 = new List<afm_users>();
            this.afm_users3 = new List<afm_users>();
            this.afm_users4 = new List<afm_users>();
            this.afm_users5 = new List<afm_users>();
            this.afm_users6 = new List<afm_users>();
            this.afm_users7 = new List<afm_users>();
            this.afm_users8 = new List<afm_users>();
            this.afm_users9 = new List<afm_users>();
            this.afm_wf_rules = new List<afm_wf_rules>();
            this.docs_assigned = new List<docs_assigned>();
            this.notify_templates = new List<notify_templates>();
            this.resources = new List<resource>();
            this.resources1 = new List<resource>();
            this.resources2 = new List<resource>();
            this.rm_arrange = new List<rm_arrange>();
            this.rm_arrange1 = new List<rm_arrange>();
        }

        public string group_name { get; set; }
        public string group_title { get; set; }
        public string ww_preferences { get; set; }
        public string transfer_status { get; set; }
        public virtual ICollection<activitytype> activitytypes { get; set; }
        public virtual ICollection<afm_acts> afm_acts { get; set; }
        public virtual ICollection<afm_cats> afm_cats { get; set; }
        public virtual ICollection<afm_class> afm_class { get; set; }
        public virtual ICollection<afm_flds> afm_flds { get; set; }
        public virtual ICollection<afm_flds> afm_flds1 { get; set; }
        public virtual ICollection<afm_groupsforroles> afm_groupsforroles { get; set; }
        public virtual ICollection<afm_hotlist> afm_hotlist { get; set; }
        public virtual ICollection<afm_mobile_apps> afm_mobile_apps { get; set; }
        public virtual ICollection<afm_mobile_menu> afm_mobile_menu { get; set; }
        public virtual ICollection<afm_mods> afm_mods { get; set; }
        public virtual ICollection<afm_psubtasks> afm_psubtasks { get; set; }
        public virtual ICollection<afm_ptasks> afm_ptasks { get; set; }
        public virtual ICollection<afm_subtasks> afm_subtasks { get; set; }
        public virtual ICollection<afm_tasks> afm_tasks { get; set; }
        public virtual ICollection<afm_users> afm_users { get; set; }
        public virtual ICollection<afm_users> afm_users1 { get; set; }
        public virtual ICollection<afm_users> afm_users2 { get; set; }
        public virtual ICollection<afm_users> afm_users3 { get; set; }
        public virtual ICollection<afm_users> afm_users4 { get; set; }
        public virtual ICollection<afm_users> afm_users5 { get; set; }
        public virtual ICollection<afm_users> afm_users6 { get; set; }
        public virtual ICollection<afm_users> afm_users7 { get; set; }
        public virtual ICollection<afm_users> afm_users8 { get; set; }
        public virtual ICollection<afm_users> afm_users9 { get; set; }
        public virtual ICollection<afm_wf_rules> afm_wf_rules { get; set; }
        public virtual ICollection<docs_assigned> docs_assigned { get; set; }
        public virtual ICollection<notify_templates> notify_templates { get; set; }
        public virtual ICollection<resource> resources { get; set; }
        public virtual ICollection<resource> resources1 { get; set; }
        public virtual ICollection<resource> resources2 { get; set; }
        public virtual ICollection<rm_arrange> rm_arrange { get; set; }
        public virtual ICollection<rm_arrange> rm_arrange1 { get; set; }
    }
}
