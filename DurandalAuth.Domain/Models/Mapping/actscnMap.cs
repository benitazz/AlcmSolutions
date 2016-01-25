using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class actscnMap : EntityTypeConfiguration<actscn>
    {
        public actscnMap()
        {
            // Primary Key
            this.HasKey(t => new { t.proj_scenario_id, t.activity_log_id });

            // Properties
            this.Property(t => t.proj_scenario_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.activity_log_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("actscns", "afm");
            this.Property(t => t.fiscal_year).HasColumnName("fiscal_year");
            this.Property(t => t.proj_scenario_id).HasColumnName("proj_scenario_id");
            this.Property(t => t.activity_log_id).HasColumnName("activity_log_id");

            // Relationships
            this.HasRequired(t => t.activity_log)
                .WithMany(t => t.actscns)
                .HasForeignKey(d => d.activity_log_id);

        }
    }
}
