#region

using System.Data.Entity.Migrations;
using System.Linq;

using DurandalAuth.Domain.Models;

#endregion

namespace DurandalAuth.Data.Common
{
    /// <summary>
    /// The gender data.
    /// </summary>
    public static class GenderData
    {
        /// <summary>
        /// The male.
        /// </summary>
        public static string Male = "Male";

        /// <summary>
        /// The female.
        /// </summary>
        public static string Female = "Female";

        /// <summary>
        /// The set gender data.
        /// </summary>
        /// <param name="uow">
        /// The uow.
        /// </param>
        /// <param name="hasChanges">
        /// The has changes.
        /// </param>
        public static void SetGenderData(DurandalAuthDbContext uow, ref bool hasChanges)
        {
            if (uow.GenderLookups.Any())
            {
                return;
            }

            var male = GetGenderLookup(Male);
            uow.GenderLookups.AddOrUpdate(male);

            var female = GetGenderLookup(Female);
            uow.GenderLookups.AddOrUpdate(female);

            hasChanges = true;
        }

        /// <summary>
        /// The get gender lookup.
        /// </summary>
        /// <param name="gender">
        /// The gender.
        /// </param>
        /// <returns>
        /// The <see cref="GenderLookup"/>.
        /// </returns>
        private static GenderLookup GetGenderLookup(string gender)
        {
            return new GenderLookup
                       {
                           Name = gender, 
                           CreatedBy = SystemAdminData.Username, 
                           UpdatedBy = SystemAdminData.Username, 
                           CreatedDate = SystemAdminData.CreationDateTime, 
                           UpdatedDate = SystemAdminData.CreationDateTime
                       };
        }
    }
}