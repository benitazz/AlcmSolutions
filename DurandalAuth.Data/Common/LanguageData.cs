#region

using System.Data.Entity.Migrations;
using System.Linq;

using DurandalAuth.Domain.Models;

#endregion

namespace DurandalAuth.Data.Common
{
    /// <summary>
    /// The language data.
    /// </summary>
    public class LanguageData
    {
        /// <summary>
        /// The english.
        /// </summary>
        public static string English = "English";

        /// <summary>
        /// The afrikaans.
        /// </summary>
        public static string Afrikaans = "Afrikaans";

        /// <summary>
        /// The zulu.
        /// </summary>
        public static string Zulu = "Zulu";

        /// <summary>
        /// The ndebele.
        /// </summary>
        public static string Ndebele = "Ndebele";

        /// <summary>
        /// The xhosa.
        /// </summary>
        public static string Xhosa = "Xhosa";

        /// <summary>
        /// The tswana.
        /// </summary>
        public static string Tswana = "Tswana";

        /// <summary>
        /// The sotho.
        /// </summary>
        public static string Sotho = "Sotho";

        /// <summary>
        /// The nothern sotho.
        /// </summary>
        public static string NothernSotho = "Nothern Sotho";

        /// <summary>
        /// The swati.
        /// </summary>
        public static string Swati = "Swati";

        /// <summary>
        /// The tsonga.
        /// </summary>
        public static string Tsonga = "Tsonga";

        /// <summary>
        /// The venda.
        /// </summary>
        public static string Venda = "Venda";

        /// <summary>
        /// The other.
        /// </summary>
        public static string Other = "Other";

        /// <summary>
        /// The set language data.
        /// </summary>
        /// <param name="uow">
        /// The uow.
        /// </param>
        /// <param name="hasChanges">
        /// The has changes.
        /// </param>
        public static void SetLanguageData(DurandalAuthDbContext uow, ref bool hasChanges)
        {
            if (uow.LanguageLookups.Any())
            {
                return;
            }

            var english = GetLanguageLookup(English);
            uow.LanguageLookups.AddOrUpdate(english);

            var afrikaans = GetLanguageLookup(Afrikaans);
            uow.LanguageLookups.AddOrUpdate(afrikaans);

            var tswana = GetLanguageLookup(Tswana);
            uow.LanguageLookups.AddOrUpdate(tswana);

            var northenSotho = GetLanguageLookup(NothernSotho);
            uow.LanguageLookups.AddOrUpdate(northenSotho);

            var sotho = GetLanguageLookup(Sotho);
            uow.LanguageLookups.AddOrUpdate(sotho);

            var tsonga = GetLanguageLookup(Tsonga);
            uow.LanguageLookups.AddOrUpdate(tsonga);

            var venda = GetLanguageLookup(Venda);
            uow.LanguageLookups.AddOrUpdate(venda);

            var swati = GetLanguageLookup(Swati);
            uow.LanguageLookups.AddOrUpdate(swati);

            var ndebele = GetLanguageLookup(Ndebele);
            uow.LanguageLookups.AddOrUpdate(ndebele);

            var xhosa = GetLanguageLookup(Xhosa);
            uow.LanguageLookups.AddOrUpdate(xhosa);

            var zulu = GetLanguageLookup(Zulu);
            uow.LanguageLookups.AddOrUpdate(zulu);

            var other = GetLanguageLookup(Other);
            uow.LanguageLookups.AddOrUpdate(other);

            hasChanges = true;
        }

        /// <summary>
        /// The get language lookup.
        /// </summary>
        /// <param name="language">
        /// The language.
        /// </param>
        /// <returns>
        /// The <see cref="LanguageLookup"/>.
        /// </returns>
        private static LanguageLookup GetLanguageLookup(string language)
        {
            return new LanguageLookup
                       {
                           Name = language, 
                           CreatedBy = SystemAdminData.Username, 
                           UpdatedBy = SystemAdminData.Username, 
                           CreatedDate = SystemAdminData.CreationDateTime, 
                           UpdatedDate = SystemAdminData.CreationDateTime
                       };
        }
    }
}