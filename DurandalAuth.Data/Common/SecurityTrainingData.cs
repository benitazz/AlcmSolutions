namespace DurandalAuth.Data.Common
{
    /// <summary>
    /// The security training data.
    /// </summary>
    public class SecurityTrainingData
    {
        /// <summary>
        /// The cit name.
        /// </summary>
        public static string CitName = "CIT";

        /// <summary>
        /// The vip name.
        /// </summary>
        public static string VipName = "VIP";

        /// <summary>
        /// The k 9 name.
        /// </summary>
        public static string K9Name = "K9";

        /// <summary>
        /// The fire arm.
        /// </summary>
        public static string FireArm = "FIREARM";

        /// <summary>
        /// The other.
        /// </summary>
        public static string Other = "Other";

        /// <summary>
        /// The set security training data.
        /// </summary>
        /// <param name="uow">
        /// The uow.
        /// </param>
        /// <param name="hasChanges">
        /// The has changes.
        /// </param>
        public static void SetSecurityTrainingData(DurandalAuthDbContext uow, ref bool hasChanges)
        {
            /*if (uow.SecurityTrainingLookups.Any())
            {
                return;
            }

            var cit = GetSecurityTrainingLookup(CitName);
            uow.SecurityTrainingLookups.AddOrUpdate(cit);

            var vip = GetSecurityTrainingLookup(VipName);
            uow.SecurityTrainingLookups.AddOrUpdate(vip);

            var k9 = GetSecurityTrainingLookup(K9Name);
            uow.SecurityTrainingLookups.AddOrUpdate(k9);

            var arm = GetSecurityTrainingLookup(FireArm);
            uow.SecurityTrainingLookups.AddOrUpdate(arm);

            var other = GetSecurityTrainingLookup(Other);
            uow.SecurityTrainingLookups.AddOrUpdate(other);

            hasChanges = true;*/
        }

        /* private static SecurityTrainingLookup GetSecurityTrainingLookup(string trainingType)
        {
            return new SecurityTrainingLookup
                       {
                           Name = trainingType,
                           CreatedBy = SystemAdminData.Username,
                           UpdatedBy = SystemAdminData.Username,
                           CreatedDate = SystemAdminData.CreationDateTime,
                           UpdatedDate = SystemAdminData.CreationDateTime
                       };
        }*/
    }
}