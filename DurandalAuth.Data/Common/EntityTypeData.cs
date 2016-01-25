#region

using System.Data.Entity.Migrations;
using System.Linq;

using DurandalAuth.Domain.Models;

#endregion

namespace DurandalAuth.Data.Common
{
    /// <summary>
    /// The entity type data.
    /// </summary>
    public class EntityTypeData
    {
        /// <summary>
        /// The vendor.
        /// </summary>
        public static string Vendor = "Vendor";

        /// <summary>
        /// The individual.
        /// </summary>
        public static string Individual = "Individual";

        /// <summary>
        /// The set entity data.
        /// </summary>
        /// <param name="uow">
        /// The uow.
        /// </param>
        /// <param name="hasChanges">
        /// The has changes.
        /// </param>
        public static void SetEntityData(DurandalAuthDbContext uow, ref bool hasChanges)
        {
            if (uow.EntityTypeLookups.Any())
            {
                return;
            }

            var vendor = GetEntityType(Vendor);
            uow.EntityTypeLookups.AddOrUpdate(vendor);

            var individual = GetEntityType(Individual);
            uow.EntityTypeLookups.AddOrUpdate(individual);

            hasChanges = true;
        }

        /// <summary>
        /// The get entity type.
        /// </summary>
        /// <param name="decision">
        /// The decision.
        /// </param>
        /// <returns>
        /// The <see cref="EntityTypeLookup"/>.
        /// </returns>
        private static EntityTypeLookup GetEntityType(string decision)
        {
            return new EntityTypeLookup
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