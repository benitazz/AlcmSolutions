using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class pmsdMap : EntityTypeConfiguration<pmsd>
    {
        public pmsdMap()
        {
            // Primary Key
            this.HasKey(t => new { t.pms_id, t.date_todo });

            // Properties
            this.Property(t => t.pms_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("pmsd", "afm");
            this.Property(t => t.pms_id).HasColumnName("pms_id");
            this.Property(t => t.date_todo).HasColumnName("date_todo");

            // Relationships
            this.HasRequired(t => t.pm)
                .WithMany(t => t.Pmsds)
                .HasForeignKey(d => d.pms_id);

        }
    }
}
