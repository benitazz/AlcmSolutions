#region

using Breeze.ContextProvider;

using DurandalAuth.Domain.Models;
using DurandalAuth.Domain.Repositories;

using Newtonsoft.Json.Linq;

#endregion

namespace DurandalAuth.Domain.UnitOfWork
{
    /// <summary>
    ///     Contract for the UnitOfWork
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Gets the article repository.
        /// </summary>
        IRepository<Article> ArticleRepository { get; }

        /// <summary>
        /// Gets the category repository.
        /// </summary>
        IRepository<Category> CategoryRepository { get; }

        /// <summary>
        /// Gets the tag repository.
        /// </summary>
        IRepository<Tag> TagRepository { get; }

        /// <summary>
        /// Gets the user profile repository.
        /// </summary>
        IRepository<UserProfile> UserProfileRepository { get; }

        /// <summary>
        /// Gets the profile repository.
        /// </summary>
        IRepository<Profile> ProfileRepository { get; }

        /// <summary>
        /// Gets the address repository.
        /// </summary>
        IRepository<Address> AddressRepository { get; }

        /// <summary>
        /// Gets the contact repository.
        /// </summary>
        IRepository<Contact> ContactRepository { get; }

        /// <summary>
        /// Gets the province repository.
        /// </summary>
        IRepository<ProvinceLookup> ProvinceRepository { get; }

        // IRepository<CityNameLookup> CityRepository { get; }

        /// <summary>
        /// Gets the ethnicity repository.
        /// </summary>
        IRepository<EthnicityLookup> EthnicityRepository { get; }

        /// <summary>
        /// Gets the gender repository.
        /// </summary>
        IRepository<GenderLookup> GenderRepository { get; }

        /*IRepository<PsiraGradeLookup> PsiraGradeRepository { get; }

        IRepository<PsiraCategoryLookup> PsiraCategoryRepository { get; }

        IRepository<SecurityTrainingLookup> SecurityTrainingRepository { get; }

        IRepository<EmploymentStatusLookup> EmploymentStatusRepository { get; }

        IRepository<NationalityLookup> NationalityRepository { get; }*/

        /// <summary>
        /// Gets the languange repository.
        /// </summary>
        IRepository<LanguageLookup> LanguangeRepository { get; }

        /// <summary>
        /// Gets the yes no repository.
        /// </summary>
        IRepository<YesNoLookup> YesNoRepository { get; }

        // IRepository<MaritalStatusLookup> MaritalStatusRepository { get; }

        /// <summary>
        /// Gets the address lookup repository.
        /// </summary>
        IRepository<AddressLookup> AddressLookupRepository { get; }

        /// <summary>
        /// Gets the entity lookup repository.
        /// </summary>
        IRepository<EntityTypeLookup> EntityLookupRepository { get; }

        /// <summary>
        /// Gets the title lookup repository.
        /// </summary>
        IRepository<TitleLookup> TitleLookupRepository { get; }

        /// <summary>
        /// Gets the individual repository.
        /// </summary>
        IRepository<Individual> IndividualRepository { get; }

        /// <summary>
        /// Gets the company repository.
        /// </summary>
        IRepository<Enterprise> CompanyRepository { get; }

        /*IRepository<em> EmRepository { get; }

        IRepository<bl> BlRepository { get; }

        IRepository<rm> RmRepository { get; }

        IRepository<fl> FlRepository { get; }*/

        /// <summary>
        /// The commit.
        /// </summary>
        void Commit();

        // Breeze specific
        /// <summary>
        /// The metadata.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        string Metadata();

        /// <summary>
        /// The commit.
        /// </summary>
        /// <param name="changeSet">
        /// The change set.
        /// </param>
        /// <returns>
        /// The <see cref="SaveResult"/>.
        /// </returns>
        SaveResult Commit(JObject changeSet);
    }
}