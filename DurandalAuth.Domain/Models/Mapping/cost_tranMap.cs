using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class cost_tranMap : EntityTypeConfiguration<cost_tran>
    {
        public cost_tranMap()
        {
            // Primary Key
            this.HasKey(t => t.cost_tran_id);

            // Properties
            this.Property(t => t.ctry_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.currency_budget)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.currency_payment)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.ls_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.pa_name)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.parcel_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.pr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.status)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.tax_authority_contact)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.tax_bill_num)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.tax_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.ac_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.cam_cost)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.chrgbck_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.cost_cat_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("cost_tran", "afm");
            this.Property(t => t.cost_tran_recur_id).HasColumnName("cost_tran_recur_id");
            this.Property(t => t.ctry_id).HasColumnName("ctry_id");
            this.Property(t => t.currency_budget).HasColumnName("currency_budget");
            this.Property(t => t.currency_payment).HasColumnName("currency_payment");
            this.Property(t => t.date_assessed).HasColumnName("date_assessed");
            this.Property(t => t.date_due).HasColumnName("date_due");
            this.Property(t => t.date_paid).HasColumnName("date_paid");
            this.Property(t => t.date_tax_late1).HasColumnName("date_tax_late1");
            this.Property(t => t.date_tax_late2).HasColumnName("date_tax_late2");
            this.Property(t => t.date_tax_late3).HasColumnName("date_tax_late3");
            this.Property(t => t.date_trans_created).HasColumnName("date_trans_created");
            this.Property(t => t.date_used_for_mc_budget).HasColumnName("date_used_for_mc_budget");
            this.Property(t => t.date_used_for_mc_payment).HasColumnName("date_used_for_mc_payment");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.exchange_rate_budget).HasColumnName("exchange_rate_budget");
            this.Property(t => t.exchange_rate_override).HasColumnName("exchange_rate_override");
            this.Property(t => t.exchange_rate_payment).HasColumnName("exchange_rate_payment");
            this.Property(t => t.invoice_id).HasColumnName("invoice_id");
            this.Property(t => t.ls_id).HasColumnName("ls_id");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.pa_name).HasColumnName("pa_name");
            this.Property(t => t.parcel_id).HasColumnName("parcel_id");
            this.Property(t => t.pr_id).HasColumnName("pr_id");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.tax_authority_contact).HasColumnName("tax_authority_contact");
            this.Property(t => t.tax_bill_num).HasColumnName("tax_bill_num");
            this.Property(t => t.tax_clr).HasColumnName("tax_clr");
            this.Property(t => t.tax_milage_rate).HasColumnName("tax_milage_rate");
            this.Property(t => t.tax_period_in_months).HasColumnName("tax_period_in_months");
            this.Property(t => t.tax_type).HasColumnName("tax_type");
            this.Property(t => t.tax_value_assessed).HasColumnName("tax_value_assessed");
            this.Property(t => t.vat_amount_override).HasColumnName("vat_amount_override");
            this.Property(t => t.vat_percent_override).HasColumnName("vat_percent_override");
            this.Property(t => t.vat_percent_value).HasColumnName("vat_percent_value");
            this.Property(t => t.ac_id).HasColumnName("ac_id");
            this.Property(t => t.activity_log_id).HasColumnName("activity_log_id");
            this.Property(t => t.amount_expense).HasColumnName("amount_expense");
            this.Property(t => t.amount_expense_base_budget).HasColumnName("amount_expense_base_budget");
            this.Property(t => t.amount_expense_base_payment).HasColumnName("amount_expense_base_payment");
            this.Property(t => t.amount_expense_total_payment).HasColumnName("amount_expense_total_payment");
            this.Property(t => t.amount_expense_vat_budget).HasColumnName("amount_expense_vat_budget");
            this.Property(t => t.amount_expense_vat_payment).HasColumnName("amount_expense_vat_payment");
            this.Property(t => t.amount_income).HasColumnName("amount_income");
            this.Property(t => t.amount_income_base_budget).HasColumnName("amount_income_base_budget");
            this.Property(t => t.amount_income_base_payment).HasColumnName("amount_income_base_payment");
            this.Property(t => t.amount_income_total_payment).HasColumnName("amount_income_total_payment");
            this.Property(t => t.amount_income_vat_budget).HasColumnName("amount_income_vat_budget");
            this.Property(t => t.amount_income_vat_payment).HasColumnName("amount_income_vat_payment");
            this.Property(t => t.amount_tax_late1).HasColumnName("amount_tax_late1");
            this.Property(t => t.amount_tax_late2).HasColumnName("amount_tax_late2");
            this.Property(t => t.amount_tax_late3).HasColumnName("amount_tax_late3");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.cam_cost).HasColumnName("cam_cost");
            this.Property(t => t.chrgbck_status).HasColumnName("chrgbck_status");
            this.Property(t => t.cost_cat_id).HasColumnName("cost_cat_id");
            this.Property(t => t.cost_tran_id).HasColumnName("cost_tran_id");

            // Relationships
            this.HasOptional(t => t.afm_currencies)
                .WithMany(t => t.cost_tran)
                .HasForeignKey(d => d.currency_budget);
            this.HasOptional(t => t.afm_currencies1)
                .WithMany(t => t.cost_tran1)
                .HasForeignKey(d => d.currency_payment);
            this.HasRequired(t => t.cost_cat)
                .WithMany(t => t.cost_tran)
                .HasForeignKey(d => d.cost_cat_id);
            this.HasOptional(t => t.ctry)
                .WithMany(t => t.cost_tran)
                .HasForeignKey(d => d.ctry_id);

        }
    }
}
