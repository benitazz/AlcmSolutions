#region

using Breeze.ContextProvider;
using Breeze.ContextProvider.EF6;

using DurandalAuth.Data.Repositories;
using DurandalAuth.Domain.Models;
using DurandalAuth.Domain.Repositories;
using DurandalAuth.Domain.UnitOfWork;
using DurandalAuth.Domain.Validators;

using Newtonsoft.Json.Linq;

#endregion

namespace DurandalAuth.Data.UnitOfWork
{
    /// <summary>
    ///     Implementation for the UnitOfWork in the current app
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// The _context provider.
        /// </summary>
        private readonly EFContextProvider<DurandalAuthDbContext> _contextProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitOfWork"/> class. 
        /// ctor
        /// </summary>
        /// <param name="breezevalidator">
        /// The breezevalidator.
        /// </param>
        public UnitOfWork(IBreezeValidator breezevalidator)
        {
            this._contextProvider = new EFContextProvider<DurandalAuthDbContext>
                                        {
                                            BeforeSaveEntitiesDelegate =
                                                breezevalidator
                                                .BeforeSaveEntities, 
                                            BeforeSaveEntityDelegate =
                                                breezevalidator
                                                .BeforeSaveEntity
                                        };

            this.ArticleRepository = new ArticleRepository(this._contextProvider.Context);
            this.CategoryRepository = new Repository<Category>(this._contextProvider.Context);
            this.TagRepository = new Repository<Tag>(this._contextProvider.Context);
            this.UserProfileRepository = new Repository<UserProfile>(this._contextProvider.Context);
            this.ProfileRepository = new Repository<Profile>(this._contextProvider.Context);
            this.ProvinceRepository = new Repository<ProvinceLookup>(this._contextProvider.Context);

            // this.CityRepository = new Repository<CityNameLookup>(this._contextProvider.Context);
            this.EthnicityRepository = new Repository<EthnicityLookup>(this._contextProvider.Context);
            this.GenderRepository = new Repository<GenderLookup>(this._contextProvider.Context);

            /*this.PsiraGradeRepository = new Repository<PsiraGradeLookup>(this._contextProvider.Context);
            this.PsiraCategoryRepository = new Repository<PsiraCategoryLookup>(this._contextProvider.Context);
            this.SecurityTrainingRepository = new Repository<SecurityTrainingLookup>(this._contextProvider.Context);
            this.EmploymentStatusRepository = new Repository<EmploymentStatusLookup>(this._contextProvider.Context);
            this.NationalityRepository = new Repository<NationalityLookup>(this._contextProvider.Context);
            this.LanguangeRepository = new Repository<LanguageLookup>(this._contextProvider.Context);*/
            this.YesNoRepository = new Repository<YesNoLookup>(this._contextProvider.Context);

            // this.MaritalStatusRepository = new Repository<MaritalStatusLookup>(this._contextProvider.Context);
            this.AddressLookupRepository = new Repository<AddressLookup>(this._contextProvider.Context);
            this.EntityLookupRepository = new Repository<EntityTypeLookup>(this._contextProvider.Context);
            this.TitleLookupRepository = new Repository<TitleLookup>(this._contextProvider.Context);
            this.AddressRepository = new Repository<Address>(this._contextProvider.Context);
            this.ContactRepository = new Repository<Contact>(this._contextProvider.Context);
            this.IndividualRepository = new Repository<Individual>(this._contextProvider.Context);
            this.CompanyRepository = new Repository<Enterprise>(this._contextProvider.Context);

            /*this.RmRepository = new Repository<rm>(this._contextProvider.Context);
            this.EmRepository = new Repository<em>(this._contextProvider.Context);
            this.BlRepository = new Repository<bl>(this._contextProvider.Context);
            this.FlRepository = new Repository<fl>(this._contextProvider.Context);*/
        }

        /// <summary>
        ///     Reporitories
        /// </summary>
        public IRepository<Article> ArticleRepository { get; private set; }

        /// <summary>
        /// Gets the category repository.
        /// </summary>
        public IRepository<Category> CategoryRepository { get; private set; }

        /// <summary>
        /// Gets the tag repository.
        /// </summary>
        public IRepository<Tag> TagRepository { get; private set; }

        /// <summary>
        /// Gets the user profile repository.
        /// </summary>
        public IRepository<UserProfile> UserProfileRepository { get; private set; }

        /// <summary>
        /// Gets the profile repository.
        /// </summary>
        public IRepository<Profile> ProfileRepository { get; private set; }

        /// <summary>
        /// Gets the province repository.
        /// </summary>
        public IRepository<ProvinceLookup> ProvinceRepository { get; private set; }

        // public IRepository<CityNameLookup> CityRepository { get; private set; }

        /// <summary>
        /// Gets the ethnicity repository.
        /// </summary>
        public IRepository<EthnicityLookup> EthnicityRepository { get; private set; }

        /// <summary>
        /// Gets the gender repository.
        /// </summary>
        public IRepository<GenderLookup> GenderRepository { get; private set; }

        /*public IRepository<PsiraGradeLookup> PsiraGradeRepository { get; private set; }

        public IRepository<PsiraCategoryLookup> PsiraCategoryRepository { get; private set; }

        public IRepository<SecurityTrainingLookup> SecurityTrainingRepository { get; private set; }

        public IRepository<EmploymentStatusLookup> EmploymentStatusRepository { get; private set; }

        public IRepository<NationalityLookup> NationalityRepository { get; private set; }*/

        /// <summary>
        /// Gets the languange repository.
        /// </summary>
        public IRepository<LanguageLookup> LanguangeRepository { get; private set; }

        /// <summary>
        /// Gets the yes no repository.
        /// </summary>
        public IRepository<YesNoLookup> YesNoRepository { get; private set; }

        // public IRepository<MaritalStatusLookup> MaritalStatusRepository { get; private set; }

        /// <summary>
        /// Gets the address lookup repository.
        /// </summary>
        public IRepository<AddressLookup> AddressLookupRepository { get; private set; }

        /// <summary>
        /// Gets the entity lookup repository.
        /// </summary>
        public IRepository<EntityTypeLookup> EntityLookupRepository { get; private set; }

        /// <summary>
        /// Gets the title lookup repository.
        /// </summary>
        public IRepository<TitleLookup> TitleLookupRepository { get; private set; }

        /// <summary>
        /// Gets the address repository.
        /// </summary>
        public IRepository<Address> AddressRepository { get; private set; }

        /// <summary>
        /// Gets the contact repository.
        /// </summary>
        public IRepository<Contact> ContactRepository { get; private set; }

        /// <summary>
        /// Gets the individual repository.
        /// </summary>
        public IRepository<Individual> IndividualRepository { get; private set; }

        /// <summary>
        /// Gets the company repository.
        /// </summary>
        public IRepository<Enterprise> CompanyRepository { get; private set; }

        /*public IRepository<em> EmRepository { get; private set; }

        public IRepository<bl> BlRepository { get; private set; }

        public IRepository<fl> FlRepository { get; private set; }

        public IRepository<rm> RmRepository { get; private set; } */

        /// <summary>
        ///     Get breeze Metadata
        /// </summary>
        /// <returns>String containing Breeze metadata</returns>
        public string Metadata()
        {
            return this._contextProvider.Metadata();
        }

        /// <summary>
        /// Save a changeset using Breeze
        /// </summary>
        /// <param name="changeSet">
        /// </param>
        /// <returns>
        /// The <see cref="SaveResult"/>.
        /// </returns>
        public SaveResult Commit(JObject changeSet)
        {
            return this._contextProvider.SaveChanges(changeSet);
        }

        /// <summary>
        ///     Save Context using traditional Entity Framework operation
        /// </summary>
        public void Commit()
        {
            this._contextProvider.Context.SaveChanges();
        }
    }
}