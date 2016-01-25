using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class cbudcmprMap : EntityTypeConfiguration<cbudcmpr>
    {
        public cbudcmprMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.budget_id1)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.budget_id2)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.cost_cat_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("cbudcmpr", "afm");
            this.Property(t => t.amount_expense_bud1).HasColumnName("amount_expense_bud1");
            this.Property(t => t.amount_expense_bud2).HasColumnName("amount_expense_bud2");
            this.Property(t => t.amount_income_bud1).HasColumnName("amount_income_bud1");
            this.Property(t => t.amount_income_bud2).HasColumnName("amount_income_bud2");
            this.Property(t => t.budget_id1).HasColumnName("budget_id1");
            this.Property(t => t.budget_id2).HasColumnName("budget_id2");
            this.Property(t => t.cost_cat_id).HasColumnName("cost_cat_id");
            this.Property(t => t.diff_expense).HasColumnName("diff_expense");
            this.Property(t => t.diff_income).HasColumnName("diff_income");
            this.Property(t => t.diff_total).HasColumnName("diff_total");
            this.Property(t => t.auto_number).HasColumnName("auto_number");
        }
    }
}
