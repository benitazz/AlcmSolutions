namespace DurandalAuth.Data.Common
{
    /// <summary>
    /// The marital status data.
    /// </summary>
    public class MaritalStatusData
    {
        /// <summary>
        /// The married.
        /// </summary>
        public static string Married = "Married";

        /// <summary>
        /// The single.
        /// </summary>
        public static string Single = "Single";

        /// <summary>
        /// The divorced.
        /// </summary>
        public static string Divorced = "Divorced";

        /// <summary>
        /// The living together.
        /// </summary>
        public static string LivingTogether = "Living together With Partner";

        /// <summary>
        /// The widow.
        /// </summary>
        public static string Widow = "Widow";

        /// <summary>
        /// The widower.
        /// </summary>
        public static string Widower = "Widower";

        /// <summary>
        /// The other.
        /// </summary>
        public static string Other = "Other";

        /// <summary>
        /// The set marital status data.
        /// </summary>
        /// <param name="uow">
        /// The uow.
        /// </param>
        /// <param name="hasChanges">
        /// The has changes.
        /// </param>
        public static void SetMaritalStatusData(DurandalAuthDbContext uow, ref bool hasChanges)
        {
            /*if (uow.MaritalStatusLookups.Any())
            {
                return;
            }

            var married = GetMaritalStatusLookup(Married);
            uow.MaritalStatusLookups.AddOrUpdate(married);

            var single = GetMaritalStatusLookup(Single);
            uow.MaritalStatusLookups.AddOrUpdate(single);

            var divorced = GetMaritalStatusLookup(Divorced);
            uow.MaritalStatusLookups.AddOrUpdate(divorced);

            var livingTogether = GetMaritalStatusLookup(LivingTogether);
            uow.MaritalStatusLookups.AddOrUpdate(livingTogether);

            var widow = GetMaritalStatusLookup(Widow);
            uow.MaritalStatusLookups.AddOrUpdate(widow);

            var widower = GetMaritalStatusLookup(Widower);
            uow.MaritalStatusLookups.AddOrUpdate(widower);

            var other = GetMaritalStatusLookup(Other);
            uow.MaritalStatusLookups.AddOrUpdate(other);

            hasChanges = true;*/
        }

        /*private static MaritalStatusLookup GetMaritalStatusLookup(string maritalStatus)
        {
            return new MaritalStatusLookup
                       {
                           Name = maritalStatus,
                           CreatedBy = SystemAdminData.Username,
                           UpdatedBy = SystemAdminData.Username,
                           CreatedDate = SystemAdminData.CreationDateTime,
                           UpdatedDate = SystemAdminData.CreationDateTime
                       };
        }*/
    }
}