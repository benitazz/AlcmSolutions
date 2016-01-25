using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ccost_sumMap : EntityTypeConfiguration<ccost_sum>
    {
        public ccost_sumMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.ls_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.pr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.report_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.user_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("ccost_sum", "afm");
            this.Property(t => t.amount_base_rent).HasColumnName("amount_base_rent");
            this.Property(t => t.amount_operating).HasColumnName("amount_operating");
            this.Property(t => t.amount_other).HasColumnName("amount_other");
            this.Property(t => t.amount_pct_rent).HasColumnName("amount_pct_rent");
            this.Property(t => t.amount_security).HasColumnName("amount_security");
            this.Property(t => t.amount_taxes).HasColumnName("amount_taxes");
            this.Property(t => t.amount_tot_rent_exp).HasColumnName("amount_tot_rent_exp");
            this.Property(t => t.amount_tot_rent_inc).HasColumnName("amount_tot_rent_inc");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.cost_operating_total).HasColumnName("cost_operating_total");
            this.Property(t => t.cost_other_total).HasColumnName("cost_other_total");
            this.Property(t => t.cost_tax_total).HasColumnName("cost_tax_total");
            this.Property(t => t.cost_utility_total).HasColumnName("cost_utility_total");
            this.Property(t => t.date_costs_last_calcd).HasColumnName("date_costs_last_calcd");
            this.Property(t => t.income_total).HasColumnName("income_total");
            this.Property(t => t.ls_id).HasColumnName("ls_id");
            this.Property(t => t.pr_id).HasColumnName("pr_id");
            this.Property(t => t.report_name).HasColumnName("report_name");
            this.Property(t => t.user_name).HasColumnName("user_name");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasRequired(t => t.afm_users)
                .WithMany(t => t.ccost_sum)
                .HasForeignKey(d => d.user_name);
            this.HasOptional(t => t.bl)
                .WithMany(t => t.ccost_sum)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.l)
                .WithMany(t => t.ccost_sum)
                .HasForeignKey(d => d.ls_id);
            this.HasOptional(t => t.property)
                .WithMany(t => t.ccost_sum)
                .HasForeignKey(d => d.pr_id);

        }
    }
}
