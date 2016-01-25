namespace DurandalAuth.Domain.Models.Mapping
{
    #region

    using System.Data.Entity.ModelConfiguration;

    #endregion

    /// <summary>
    /// </summary>
    public class PmgpMap : EntityTypeConfiguration<pmgp>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PmgpMap"/> class.
        /// </summary>
        public PmgpMap()
        {
            // Primary Key
            this.HasKey(t => t.pm_group);

            // Properties
            this.Property(t => t.description).HasMaxLength(100);

            this.Property(t => t.pm_group).IsRequired().IsFixedLength().HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("pmgp", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.pm_group).HasColumnName("pm_group");
        }
    }
}