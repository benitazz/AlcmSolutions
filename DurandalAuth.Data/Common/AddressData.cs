#region

using System.Data.Entity.Migrations;
using System.Linq;

using DurandalAuth.Domain.Models;

#endregion

namespace DurandalAuth.Data.Common
{
    /// <summary>
    /// The address data.
    /// </summary>
    public class AddressData
    {
        /// <summary>
        /// The physical address.
        /// </summary>
        public static string PhysicalAddress = "Physical Address";

        /// <summary>
        /// The postal address.
        /// </summary>
        public static string PostalAddress = "Postal Address";

        /// <summary>
        /// The set address data.
        /// </summary>
        /// <param name="uow">
        /// The uow.
        /// </param>
        /// <param name="hasChanges">
        /// The has changes.
        /// </param>
        public static void SetAddressData(DurandalAuthDbContext uow, ref bool hasChanges)
        {
            if (uow.AddressLookups.Any())
            {
                return;
            }

            var physicalAddress = GetAddress(PhysicalAddress);
            uow.AddressLookups.AddOrUpdate(physicalAddress);

            var postalAddress = GetAddress(PostalAddress);
            uow.AddressLookups.AddOrUpdate(postalAddress);

            hasChanges = true;
        }

        /// <summary>
        /// The get address.
        /// </summary>
        /// <param name="addressType">
        /// The address type.
        /// </param>
        /// <returns>
        /// The <see cref="AddressLookup"/>.
        /// </returns>
        private static AddressLookup GetAddress(string addressType)
        {
            return new AddressLookup
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