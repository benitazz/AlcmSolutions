using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class prog_budget_itemsMap : EntityTypeConfiguration<prog_budget_items>
    {
        public prog_budget_itemsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.budget_id, t.program_id, t.fiscal_year });

            // Properties
            this.Property(t => t.source)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.budget_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.program_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.fiscal_year)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("prog_budget_items", "afm");
            this.Property(t => t.cost_budget_cap).HasColumnName("cost_budget_cap");
            this.Property(t => t.cost_budget_exp).HasColumnName("cost_budget_exp");
            this.Property(t => t.source).HasColumnName("source");
            this.Property(t => t.budget_id).HasColumnName("budget_id");
            this.Property(t => t.program_id).HasColumnName("program_id");
            this.Property(t => t.fiscal_year).HasColumnName("fiscal_year");

            // Relationships
            this.HasRequired(t => t.budget)
                .WithMany(t => t.prog_budget_items)
                .HasForeignKey(d => d.budget_id);
            this.HasRequired(t => t.program)
                .WithMany(t => t.prog_budget_items)
                .HasForeignKey(d => d.program_id);

        }
    }
}
