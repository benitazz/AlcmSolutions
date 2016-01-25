#region

using System.Data.Entity.ModelConfiguration;

#endregion

namespace DurandalAuth.Domain.Models.Mapping
{
    /// <summary>
    /// The cb_accredit_source map.
    /// </summary>
    public class cb_accredit_sourceMap : EntityTypeConfiguration<cb_accredit_source>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="cb_accredit_sourceMap"/> class.
        /// </summary>
        public cb_accredit_sourceMap()
        {
            // Primary Key
            this.HasKey(t => t.accredit_source_id);

            // Properties
            this.Property(t => t.description).HasMaxLength(512);

            this.Property(t => t.name).IsFixedLength().HasMaxLength(64);

            this.Property(t => t.prob_type).IsFixedLength().HasMaxLength(32);

            this.Property(t => t.state_id).IsFixedLength().HasMaxLength(4);

            this.Property(t => t.accredit_source_id).IsRequired().IsFixedLength().HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("cb_accredit_source", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.prob_type).HasColumnName("prob_type");
            this.Property(t => t.state_id).HasColumnName("state_id");
            this.Property(t => t.accredit_source_id).HasColumnName("accredit_source_id");

            // Relationships
            this.HasOptional(t => t.probtype).WithMany(t => t.cb_accredit_source).HasForeignKey(d => d.prob_type);
            this.HasOptional(t => t.state).WithMany(t => t.cb_accredit_source).HasForeignKey(d => d.state_id);
        }
    }
}