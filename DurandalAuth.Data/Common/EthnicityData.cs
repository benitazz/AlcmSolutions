#region

using System.Data.Entity.Migrations;
using System.Linq;

using DurandalAuth.Domain.Models;

#endregion

namespace DurandalAuth.Data.Common
{
    /// <summary>
    /// The ethnicity data.
    /// </summary>
    public static class EthnicityData
    {
        /// <summary>
        /// The african.
        /// </summary>
        public static string African = "African";

        /// <summary>
        /// The coloured.
        /// </summary>
        public static string Coloured = "Coloured";

        /// <summary>
        /// The indian.
        /// </summary>
        public static string Indian = "Indian";

        /// <summary>
        /// The white.
        /// </summary>
        public static string White = "White";

        /// <summary>
        /// The chinese.
        /// </summary>
        public static string Chinese = "Chinese";

        /// <summary>
        /// The other.
        /// </summary>
        public static string Other = "Other";

        /// <summary>
        /// The set ethnicity data.
        /// </summary>
        /// <param name="uow">
        /// The uow.
        /// </param>
        /// <param name="hasChanges">
        /// The has changes.
        /// </param>
        public static void SetEthnicityData(DurandalAuthDbContext uow, ref bool hasChanges)
        {
            if (uow.EthnicityLookups.Any())
            {
                return;
            }

            var african = GetEthnicityLookup(African);
            uow.EthnicityLookups.AddOrUpdate(african);

            var coloured = GetEthnicityLookup(Coloured);
            uow.EthnicityLookups.AddOrUpdate(coloured);

            var white = GetEthnicityLookup(White);
            uow.EthnicityLookups.AddOrUpdate(white);

            var indian = GetEthnicityLookup(Indian);
            uow.EthnicityLookups.AddOrUpdate(indian);

            var chinese = GetEthnicityLookup(Chinese);
            uow.EthnicityLookups.AddOrUpdate(chinese);

            var other = GetEthnicityLookup(Other);
            uow.EthnicityLookups.AddOrUpdate(other);

            hasChanges = true;
        }

        /// <summary>
        /// The get ethnicity lookup.
        /// </summary>
        /// <param name="ethniCity">
        /// The ethni city.
        /// </param>
        /// <returns>
        /// The <see cref="EthnicityLookup"/>.
        /// </returns>
        private static EthnicityLookup GetEthnicityLookup(string ethniCity)
        {
            return new EthnicityLookup
                       {
                           Name = ethniCity, 
                           CreatedBy = SystemAdminData.Username, 
                           UpdatedBy = SystemAdminData.Username, 
                           CreatedDate = SystemAdminData.CreationDateTime, 
                           UpdatedDate = SystemAdminData.CreationDateTime
                       };
        }
    }
}