#region

using System.Data.Entity.Migrations;
using System.Linq;

using DurandalAuth.Domain.Models;

#endregion

namespace DurandalAuth.Data.Common
{
    /// <summary>
    /// The decision data.
    /// </summary>
    public static class DecisionData
    {
        /// <summary>
        /// The yes decision.
        /// </summary>
        public static string YesDecision = "Yes";

        /// <summary>
        /// The no decision.
        /// </summary>
        public static string NoDecision = "No";

        /// <summary>
        /// The set yes no lookup data.
        /// </summary>
        /// <param name="uow">
        /// The uow.
        /// </param>
        /// <param name="hasChanges">
        /// The has changes.
        /// </param>
        public static void SetYesNoLookupData(DurandalAuthDbContext uow, ref bool hasChanges)
        {
            if (uow.YesNoLookups.Any())
            {
                return;
            }

            var yes = GetYesNoLookup(YesDecision);
            uow.YesNoLookups.AddOrUpdate(yes);

            var no = GetYesNoLookup(NoDecision);
            uow.YesNoLookups.AddOrUpdate(no);

            hasChanges = true;
        }

        /// <summary>
        /// The get yes no lookup.
        /// </summary>
        /// <param name="decision">
        /// The decision.
        /// </param>
        /// <returns>
        /// The <see cref="YesNoLookup"/>.
        /// </returns>
        private static YesNoLookup GetYesNoLookup(string decision)
        {
            return new YesNoLookup
                       {
                           Name = decision, 
                           CreatedBy = SystemAdminData.Username, 
                           UpdatedBy = SystemAdminData.Username, 
                           CreatedDate = SystemAdminData.CreationDateTime, 
                           UpdatedDate = SystemAdminData.CreationDateTime
                       };
        }
    }
}