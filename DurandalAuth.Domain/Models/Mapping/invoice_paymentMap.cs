using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class invoice_paymentMap : EntityTypeConfiguration<invoice_payment>
    {
        public invoice_paymentMap()
        {
            // Primary Key
            this.HasKey(t => t.payment_id);

            // Properties
            this.Property(t => t.check_number)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.contact_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.currency_invoice)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.payment_method)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("invoice_payment", "afm");
            this.Property(t => t.amount_expense).HasColumnName("amount_expense");
            this.Property(t => t.amount_income).HasColumnName("amount_income");
            this.Property(t => t.check_number).HasColumnName("check_number");
            this.Property(t => t.contact_id).HasColumnName("contact_id");
            this.Property(t => t.currency_invoice).HasColumnName("currency_invoice");
            this.Property(t => t.date_paid).HasColumnName("date_paid");
            this.Property(t => t.date_trans_created).HasColumnName("date_trans_created");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.invoice_id).HasColumnName("invoice_id");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.payment_method).HasColumnName("payment_method");
            this.Property(t => t.payment_id).HasColumnName("payment_id");

            // Relationships
            this.HasOptional(t => t.afm_currencies)
                .WithMany(t => t.invoice_payment)
                .HasForeignKey(d => d.currency_invoice);
            this.HasOptional(t => t.contact)
                .WithMany(t => t.InvoicePayment)
                .HasForeignKey(d => d.contact_id);
            this.HasOptional(t => t.invoice)
                .WithMany(t => t.invoice_payment)
                .HasForeignKey(d => d.invoice_id);

        }
    }
}
