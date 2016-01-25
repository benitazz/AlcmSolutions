#region

using DurandalAuth.Data.Common;
using DurandalAuth.Domain.Models;

#endregion

namespace DurandalAuth.Web.Extensions
{
    /// <summary>
    /// The audit info extension.
    /// </summary>
    public static class AuditInfoExtension
    {
        /// <summary>
        /// The set audit details.
        /// </summary>
        /// <param name="auditInfoComplete">
        /// The audit info complete.
        /// </param>
        public static void SetAuditDetails(this AuditInfoComplete auditInfoComplete)
        {
            if (auditInfoComplete == null)
            {
                return;
            }

            auditInfoComplete.CreatedBy = SystemAdminData.Username;
            auditInfoComplete.CreatedDate = SystemAdminData.CreationDateTime;
            auditInfoComplete.UpdatedBy = SystemAdminData.Username;
            auditInfoComplete.UpdatedDate = SystemAdminData.CreationDateTime;
        }
    }
}