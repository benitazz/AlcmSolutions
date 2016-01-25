#region

using DurandalAuth.Domain.Models;

#endregion

namespace DurandalAuth.Data.Common
{
    /// <summary>
    /// The city data.
    /// </summary>
    public class CityData
    {
        /// <summary>
        /// The pretoria.
        /// </summary>
        public static string Pretoria = "Pretoria";

        /// <summary>
        /// The johanneburg.
        /// </summary>
        public static string Johanneburg = "Johannesburg";

        /// <summary>
        /// The set city name data.
        /// </summary>
        /// <param name="uow">
        /// The uow.
        /// </param>
        /// <param name="hasChanges">
        /// The has changes.
        /// </param>
        public static void SetCityNameData(DurandalAuthDbContext uow, ref bool hasChanges)
        {
            /* if (uow.CityNameLookups.Any())
            {
                return;
            }

            var gauteng = uow.ProvinceLookups.First(p => p.Name == ProvinceData.Gauteng);

            var pretoria = GetCityNameLookup(gauteng, Pretoria);
            uow.CityNameLookups.AddOrUpdate(pretoria);

            var johanneburg = GetCityNameLookup(gauteng, Johanneburg);
            uow.CityNameLookups.AddOrUpdate(johanneburg);

            hasChanges = true;*/
        }

        /// <summary>
        /// The get city name lookup.
        /// </summary>
        /// <param name="province">
        /// The province.
        /// </param>
        /// <param name="cityName">
        /// The city name.
        /// </param>
        /// <returns>
        /// The <see cref="CityNameLookup"/>.
        /// </returns>
        private static CityNameLookup GetCityNameLookup(ProvinceLookup province, string cityName)
        {
            return new CityNameLookup
                       {
                           Name = cityName, 
                           ProvinceLookup = province, 
                           CreatedBy = SystemAdminData.Username, 
                           UpdatedBy = SystemAdminData.Username, 
                           CreatedDate = SystemAdminData.CreationDateTime, 
                           UpdatedDate = SystemAdminData.CreationDateTime
                       };
        }
    }
}