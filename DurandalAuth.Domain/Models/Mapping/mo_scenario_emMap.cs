#region

using System.Data.Entity.ModelConfiguration;

#endregion

namespace DurandalAuth.Domain.Models.Mapping
{
    /// <summary>
    /// The mo scenario em map.
    /// </summary>
    public class MoScenarioEmMap : EntityTypeConfiguration<MoScenarioEm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MoScenarioEmMap"/> class.
        /// </summary>
        public MoScenarioEmMap()
        {
            // Primary Key
            this.HasKey(t => new { t.project_id, t.scenario_id, t.em_id });

            // Properties
            this.Property(t => t.to_bl_id).IsFixedLength().HasMaxLength(8);

            this.Property(t => t.to_fl_id).IsFixedLength().HasMaxLength(4);

            this.Property(t => t.to_rm_id).IsFixedLength().HasMaxLength(8);

            this.Property(t => t.project_id).IsRequired().IsFixedLength().HasMaxLength(32);

            this.Property(t => t.scenario_id).IsRequired().IsFixedLength().HasMaxLength(32);

            this.Property(t => t.em_id).IsRequired().IsFixedLength().HasMaxLength(35);

            // Table & Column Mappings
            this.ToTable("mo_scenario_em", "afm");
            this.Property(t => t.date_end).HasColumnName("date_end");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.to_bl_id).HasColumnName("to_bl_id");
            this.Property(t => t.to_fl_id).HasColumnName("to_fl_id");
            this.Property(t => t.to_rm_id).HasColumnName("to_rm_id");
            this.Property(t => t.project_id).HasColumnName("project_id");
            this.Property(t => t.scenario_id).HasColumnName("scenario_id");
            this.Property(t => t.em_id).HasColumnName("em_id");

            // Relationships
            // this.HasRequired(t => t.em).WithMany(t => t.mo_scenario_em).HasForeignKey(d => d.em_id);
            /*this.HasRequired(t => t.mo_scenario)
                .WithMany(t => t.mo_scenario_em)
                .HasForeignKey(d => new { d.project_id, d.scenario_id });
            this.HasRequired(t => t.project).WithMany(t => t.mo_scenario_em).HasForeignKey(d => d.project_id);*/
        }
    }
}