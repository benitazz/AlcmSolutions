namespace DurandalAuth.Data.Common
{
    /// <summary>
    /// The psira grade data.
    /// </summary>
    public class PsiraGradeData
    {
        /// <summary>
        /// The grade a.
        /// </summary>
        public static string GradeA = "Grade A";

        /// <summary>
        /// The grade b.
        /// </summary>
        public static string GradeB = "Grade B";

        /// <summary>
        /// The grade c.
        /// </summary>
        public static string GradeC = "Grade C";

        /// <summary>
        /// The grade d.
        /// </summary>
        public static string GradeD = "Grade D";

        /// <summary>
        /// The grade e.
        /// </summary>
        public static string GradeE = "Grade E";

        /// <summary>
        /// The other.
        /// </summary>
        public static string Other = "Other";

        /// <summary>
        /// The set psira grade data.
        /// </summary>
        /// <param name="uow">
        /// The uow.
        /// </param>
        /// <param name="hasChanges">
        /// The has changes.
        /// </param>
        public static void SetPsiraGradeData(DurandalAuthDbContext uow, ref bool hasChanges)
        {
            /*if (uow.PsiraGradeLookups.Any())
            {
                return;
            }

            var gradeA = GetPsiraGradeLookup(GradeA);
            uow.PsiraGradeLookups.AddOrUpdate(gradeA);

            var gradeB = GetPsiraGradeLookup(GradeB);
            uow.PsiraGradeLookups.AddOrUpdate(gradeB);

            var gradeC = GetPsiraGradeLookup(GradeC);
            uow.PsiraGradeLookups.AddOrUpdate(gradeC);

            var gradeD = GetPsiraGradeLookup(GradeD);
            uow.PsiraGradeLookups.AddOrUpdate(gradeD);

            var gradeE = GetPsiraGradeLookup(GradeE);
            uow.PsiraGradeLookups.AddOrUpdate(gradeE);

            var other = GetPsiraGradeLookup(Other);
            uow.PsiraGradeLookups.AddOrUpdate(other);*/
            hasChanges = true;
        }

        /*private static PsiraGradeLookup GetPsiraGradeLookup(string grade)
        {
            return new PsiraGradeLookup
                       {
                           Name = grade,
                           CreatedBy = SystemAdminData.Username,
                           UpdatedBy = SystemAdminData.Username,
                           CreatedDate = SystemAdminData.CreationDateTime,
                           UpdatedDate = SystemAdminData.CreationDateTime
                       };
        }*/
    }
}