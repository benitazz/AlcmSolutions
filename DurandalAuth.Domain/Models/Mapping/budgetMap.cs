using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class budgetMap : EntityTypeConfiguration<budget>
    {
        public budgetMap()
        {
            // Primary Key
            this.HasKey(t => t.budget_id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.budget_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("budget", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.budget_id).HasColumnName("budget_id");
        }
    }
}
