#region

using System.Linq;

using DurandalAuth.Domain.Models;

#endregion

namespace DurandalAuth.Web.Helpers
{
    /// <summary>
    /// The lookup bundle.
    /// </summary>
    public class LookupBundle
    {
        /// <summary>
        /// Gets or sets the categories.
        /// </summary>
        public IQueryable<Category> Categories { get; set; }

        /// <summary>
        /// Gets or sets the title lookups.
        /// </summary>
        public IQueryable<TitleLookup> TitleLookups { get; set; }

        // public IQueryable<NationalityLookup> NationalityLookups { get; set; }

        /// <summary>
        /// Gets or sets the province lookups.
        /// </summary>
        public IQueryable<ProvinceLookup> ProvinceLookups { get; set; }

        // public IQueryable<CityNameLookup> CityNameLookups { get; set; }

        /// <summary>
        /// Gets or sets the address type lookups.
        /// </summary>
        public IQueryable<AddressLookup> AddressTypeLookups { get; set; }

        // public IQueryable<MaritalStatusLookup> MaritalStatusLookups { get; set; }

        /// <summary>
        /// Gets or sets the yes no lookups.
        /// </summary>
        public IQueryable<YesNoLookup> YesNoLookups { get; set; }

        /// <summary>
        /// Gets or sets the entity type lookups.
        /// </summary>
        public IQueryable<EntityTypeLookup> EntityTypeLookups { get; set; }

        /// <summary>
        /// Gets or sets the ethnicity lookups.
        /// </summary>
        public IQueryable<EthnicityLookup> EthnicityLookups { get; set; }
    }
}