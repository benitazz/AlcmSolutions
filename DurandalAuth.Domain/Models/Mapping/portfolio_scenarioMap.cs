using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class portfolio_scenarioMap : EntityTypeConfiguration<portfolio_scenario>
    {
        public portfolio_scenarioMap()
        {
            // Primary Key
            this.HasKey(t => t.portfolio_scenario_id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(512);

            this.Property(t => t.portfolio_scenario_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("portfolio_scenario", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.portfolio_scenario_id).HasColumnName("portfolio_scenario_id");
        }
    }
}
