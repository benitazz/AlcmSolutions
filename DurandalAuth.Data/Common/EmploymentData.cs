namespace DurandalAuth.Data.Common
{
    /// <summary>
    /// The employment data.
    /// </summary>
    public class EmploymentData
    {
        /// <summary>
        /// The permanent employement.
        /// </summary>
        public static string PermanentEmployement = "Permanet Employed";

        /// <summary>
        /// The temporary employed.
        /// </summary>
        public static string TemporaryEmployed = "Temporary Employed";

        /// <summary>
        /// The unemployed.
        /// </summary>
        public static string Unemployed = "Unemployed";

        /// <summary>
        /// The set employment status.
        /// </summary>
        /// <param name="uow">
        /// The uow.
        /// </param>
        /// <param name="hasChanges">
        /// The has changes.
        /// </param>
        public static void SetEmploymentStatus(DurandalAuthDbContext uow, ref bool hasChanges)
        {
            /*if (uow.EmploymentStatusLookups.Any())
            {
                return;
            }

            var permanent = GetEmploymentData(PermanentEmployement);
            uow.EmploymentStatusLookups.AddOrUpdate(permanent);

            var temporary = GetEmploymentData(TemporaryEmployed);
            uow.EmploymentStatusLookups.AddOrUpdate(temporary);

            var unemployed = GetEmploymentData(Unemployed);
            uow.EmploymentStatusLookups.AddOrUpdate(unemployed);*/
            hasChanges = true;
        }

        /* private static EmploymentStatusLookup GetEmploymentData(string employerType)
        {
            return new EmploymentStatusLookup
                       {
                           Name = employerType,
                           CreatedBy = SystemAdminData.Username,
                           UpdatedBy = SystemAdminData.Username,
                           CreatedDate = SystemAdminData.CreationDateTime,
                           UpdatedDate = SystemAdminData.CreationDateTime
                       };
        }*/
    }
}