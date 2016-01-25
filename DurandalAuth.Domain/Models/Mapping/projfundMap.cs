using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class projfundMap : EntityTypeConfiguration<projfund>
    {
        public projfundMap()
        {
            // Primary Key
            this.HasKey(t => new { t.project_id, t.fund_id, t.fiscal_year });

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(4000);

            this.Property(t => t.project_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.fund_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.fiscal_year)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("projfunds", "afm");
            this.Property(t => t.amount_cap).HasColumnName("amount_cap");
            this.Property(t => t.amount_exp).HasColumnName("amount_exp");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.project_id).HasColumnName("project_id");
            this.Property(t => t.fund_id).HasColumnName("fund_id");
            this.Property(t => t.fiscal_year).HasColumnName("fiscal_year");

            // Relationships
            this.HasRequired(t => t.funding)
                .WithMany(t => t.projfunds)
                .HasForeignKey(d => d.fund_id);
            this.HasRequired(t => t.project)
                .WithMany(t => t.projfunds)
                .HasForeignKey(d => d.project_id);

        }
    }
}
