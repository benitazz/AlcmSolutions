using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class work_teamMap : EntityTypeConfiguration<work_team>
    {
        public work_teamMap()
        {
            // Primary Key
            this.HasKey(t => t.work_team_id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.work_team_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("work_team", "afm");
            this.Property(t => t.cf_assign).HasColumnName("cf_assign");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.work_team_id).HasColumnName("work_team_id");
        }
    }
}
