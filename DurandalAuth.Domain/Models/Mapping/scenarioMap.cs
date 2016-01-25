using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class scenarioMap : EntityTypeConfiguration<scenario>
    {
        public scenarioMap()
        {
            // Primary Key
            this.HasKey(t => t.proj_scenario_id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.scenario_type)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.proj_scenario_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("scenario", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.scenario_type).HasColumnName("scenario_type");
            this.Property(t => t.proj_scenario_id).HasColumnName("proj_scenario_id");
        }
    }
}
