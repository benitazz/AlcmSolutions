#region

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

using DurandalAuth.Data.Migrations;
using DurandalAuth.Domain.Models;

using Microsoft.AspNet.Identity.EntityFramework;

#endregion

namespace DurandalAuth.Data
{
    /// <summary>
    /// The durandal auth db context.
    /// </summary>
    public class _DurandalAuthDbContext : IdentityDbContext<UserProfile>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="_DurandalAuthDbContext"/> class.
        /// </summary>
        public _DurandalAuthDbContext()
            : base("DurandalAuthConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<_DurandalAuthDbContext, Configuration>());
        }

        /// <summary>
        /// Gets or sets the articles.
        /// </summary>
        public DbSet<Article> Articles { get; set; }

        /// <summary>
        /// Gets or sets the categories.
        /// </summary>
        public DbSet<Category> Categories { get; set; }

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        public DbSet<Tag> Tags { get; set; }

        /// <summary>
        /// Gets or sets the profiles.
        /// </summary>
        public DbSet<Profile> Profiles { get; set; }

        /// <summary>
        /// Gets or sets the addresses.
        /// </summary>
        public DbSet<Address> Addresses { get; set; }

        /// <summary>
        /// Gets or sets the contacts.
        /// </summary>
        public DbSet<Contact> Contacts { get; set; }

        /// <summary>
        /// Gets or sets the province lookups.
        /// </summary>
        public DbSet<ProvinceLookup> ProvinceLookups { get; set; }

        // public DbSet<CityNameLookup> CityNameLookups { get; set; }

        // public DbSet<NationalityLookup> NationalityLookups { get; set; }

        // public DbSet<PsiraGradeLookup> PsiraGradeLookups { get; set; }

        // public DbSet<PsiraCategoryLookup> PsiraStatusLookups { get; set; }

        // public DbSet<SecurityTrainingLookup> SecurityTrainingLookups { get; set; }

        /// <summary>
        /// Gets or sets the ethnicity lookups.
        /// </summary>
        public DbSet<EthnicityLookup> EthnicityLookups { get; set; }

        /// <summary>
        /// Gets or sets the gender lookups.
        /// </summary>
        public DbSet<GenderLookup> GenderLookups { get; set; }

        // ;public DbSet<EmploymentStatusLookup> EmploymentStatusLookups { get; set; }

        /// <summary>
        /// Gets or sets the language lookups.
        /// </summary>
        public DbSet<LanguageLookup> LanguageLookups { get; set; }

        /// <summary>
        /// Gets or sets the yes no lookups.
        /// </summary>
        public DbSet<YesNoLookup> YesNoLookups { get; set; }

        // public DbSet<MaritalStatusLookup> MaritalStatusLookups { get; set; }

        /// <summary>
        /// Gets or sets the address lookups.
        /// </summary>
        public DbSet<AddressLookup> AddressLookups { get; set; }

        /// <summary>
        /// Gets or sets the entity type lookups.
        /// </summary>
        public DbSet<EntityTypeLookup> EntityTypeLookups { get; set; }

        /// <summary>
        /// Gets or sets the title lookups.
        /// </summary>
        public DbSet<TitleLookup> TitleLookups { get; set; }

        /// <summary>
        /// Gets or sets the individuals.
        /// </summary>
        public DbSet<Individual> Individuals { get; set; }

        /// <summary>
        /// Gets or sets the companies.
        /// </summary>
        public DbSet<Enterprise> Companies { get; set; }

        // public DbSet<em> Ems { get; set; }

        /* public DbSet<bl> Bls { get; set; }

        public DbSet<fl> Fls { get; set; }

        public DbSet<rm> Rms { get; set; }*/

        /// <summary>
        /// The on model creating.
        /// </summary>
        /// <param name="modelBuilder">
        /// The model builder.
        /// </param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            this.Configuration.LazyLoadingEnabled = false;
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            // modelBuilder.Configurations.Add(new emMap());

            // Very bad idea not doing this :)
            // http://stackoverflow.com/questions/19474662/map-tables-using-fluent-api-in-asp-net-mvc5-ef6
            base.OnModelCreating(modelBuilder);
        }
    }
}