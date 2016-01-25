using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ProvinceLookup
    {
        public ProvinceLookup()
        {
            this.Addresses = new List<Address>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public int RowVersion { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
