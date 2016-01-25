#region

using System.Data.Entity.Migrations;
using System.Linq;

using DurandalAuth.Domain.Models;

#endregion

namespace DurandalAuth.Data.Common
{
    /// <summary>
    /// The title data.
    /// </summary>
    public class TitleData
    {
        /// <summary>
        /// The mr.
        /// </summary>
        public static string Mr = "Mr";

        /// <summary>
        /// The mrs.
        /// </summary>
        public static string Mrs = "Mrs";

        /// <summary>
        /// The dr.
        /// </summary>
        public static string Dr = "Dr";

        /// <summary>
        /// The set title data.
        /// </summary>
        /// <param name="uow">
        /// The uow.
        /// </param>
        /// <param name="hasChanges">
        /// The has changes.
        /// </param>
        public static void SetTitleData(DurandalAuthDbContext uow, ref bool hasChanges)
        {
            if (uow.TitleLookups.Any())
            {
                return;
            }

            var mr = GetTitle(Mr);
            uow.TitleLookups.AddOrUpdate(mr);

            var mrs = GetTitle(Mrs);
            uow.TitleLookups.AddOrUpdate(mrs);

            hasChanges = true;
        }

        /// <summary>
        /// The get title.
        /// </summary>
        /// <param name="addressType">
        /// The address type.
        /// </param>
        /// <returns>
        /// The <see cref="TitleLookup"/>.
        /// </returns>
        private static TitleLookup GetTitle(string addressType)
        {
            return new TitleLookup
                       {
                           Name = addressType, 
                           CreatedBy = SystemAdminData.Username, 
                           UpdatedBy = SystemAdminData.Username, 
                           CreatedDate = SystemAdminData.CreationDateTime, 
                           UpdatedDate = SystemAdminData.CreationDateTime
                       };
        }
    }
}