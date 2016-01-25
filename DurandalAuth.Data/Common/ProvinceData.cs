#region

using System.Data.Entity.Migrations;
using System.Linq;

using DurandalAuth.Domain.Models;

#endregion

namespace DurandalAuth.Data.Common
{
    /// <summary>
    /// The province data.
    /// </summary>
    public static class ProvinceData
    {
        // Province Names
        /// <summary>
        /// The gauteng.
        /// </summary>
        public static string Gauteng = "Gauteng";

        /// <summary>
        /// The north west.
        /// </summary>
        public static string NorthWest = "North West";

        /// <summary>
        /// The mpumalanga.
        /// </summary>
        public static string Mpumalanga = "Mpumalanga";

        /// <summary>
        /// The kwa zulu natal.
        /// </summary>
        public static string KwaZuluNatal = "KwaZulu-Natal";

        /// <summary>
        /// The freestate.
        /// </summary>
        public static string Freestate = "Free State";

        /// <summary>
        /// The western cape.
        /// </summary>
        public static string WesternCape = "Western Cape";

        /// <summary>
        /// The eastern cape.
        /// </summary>
        public static string EasternCape = "Eastern Cape";

        /// <summary>
        /// The northern cape.
        /// </summary>
        public static string NorthernCape = "Northern Cape";

        /// <summary>
        /// The limpopo.
        /// </summary>
        public static string Limpopo = "Limpopo";

        /// <summary>
        /// The set province data.
        /// </summary>
        /// <param name="uow">
        /// The uow.
        /// </param>
        /// <param name="hasChanges">
        /// The has changes.
        /// </param>
        public static void SetProvinceData(DurandalAuthDbContext uow, ref bool hasChanges)
        {
            if (uow.ProvinceLookups.Any())
            {
                return;
            }

            var gauteng = GetProvinceLookup(Gauteng);
            uow.ProvinceLookups.AddOrUpdate(gauteng);

            var mpumalanga = GetProvinceLookup(Mpumalanga);
            uow.ProvinceLookups.AddOrUpdate(mpumalanga);

            var freestate = GetProvinceLookup(Freestate);
            uow.ProvinceLookups.AddOrUpdate(freestate);

            var northWest = GetProvinceLookup(NorthWest);
            uow.ProvinceLookups.AddOrUpdate(northWest);

            var westernCape = GetProvinceLookup(WesternCape);
            uow.ProvinceLookups.AddOrUpdate(westernCape);

            var easternCape = GetProvinceLookup(EasternCape);
            uow.ProvinceLookups.AddOrUpdate(easternCape);

            var limpopo = GetProvinceLookup(Limpopo);
            uow.ProvinceLookups.AddOrUpdate(limpopo);

            var kzn = GetProvinceLookup(KwaZuluNatal);
            uow.ProvinceLookups.AddOrUpdate(kzn);

            var northernCape = GetProvinceLookup(NorthernCape);
            uow.ProvinceLookups.AddOrUpdate(northernCape);

            hasChanges = true;
        }

        /// <summary>
        /// The get province lookup.
        /// </summary>
        /// <param name="province">
        /// The province.
        /// </param>
        /// <returns>
        /// The <see cref="ProvinceLookup"/>.
        /// </returns>
        private static ProvinceLookup GetProvinceLookup(string province)
        {
            return new ProvinceLookup
                       {
                           Name = province, 
                           CreatedBy = SystemAdminData.Username, 
                           UpdatedBy = SystemAdminData.Username, 
                           CreatedDate = SystemAdminData.CreationDateTime, 
                           UpdatedDate = SystemAdminData.CreationDateTime
                       };
        }
    }
}