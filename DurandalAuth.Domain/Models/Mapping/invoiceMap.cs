using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class invoiceMap : EntityTypeConfiguration<invoice>
    {
        public invoiceMap()
        {
            // Primary Key
            this.HasKey(t => t.invoice_id);

            // Properties
            this.Property(t => t.ac_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.contact_id_remit_to)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.contact_id_send_to)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.currency_invoice)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.doc)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.fac_org_level_01)
                .HasMaxLength(16);

            this.Property(t => t.fac_org_level_02)
                .HasMaxLength(16);

            this.Property(t => t.fac_org_level_03)
                .HasMaxLength(16);

            this.Property(t => t.fac_org_level_04)
                .HasMaxLength(16);

            this.Property(t => t.fac_org_level_05)
                .HasMaxLength(16);

            this.Property(t => t.fac_org_level_06)
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

            this.Property(t => t.pr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.project_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.terms)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.vn_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.vn_invoice_num)
                .HasMaxLength(32);

            this.Property(t => t.work_pkg_id)
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("invoice", "afm");
            this.Property(t => t.ac_id).HasColumnName("ac_id");
            this.Property(t => t.amount_approved).HasColumnName("amount_approved");
            this.Property(t => t.amount_base_invoice).HasColumnName("amount_base_invoice");
            this.Property(t => t.amount_billed).HasColumnName("amount_billed");
            this.Property(t => t.amount_billed_total).HasColumnName("amount_billed_total");
            this.Property(t => t.amount_closed).HasColumnName("amount_closed");
            this.Property(t => t.amount_deficiency).HasColumnName("amount_deficiency");
            this.Property(t => t.amount_deficiency_tax).HasColumnName("amount_deficiency_tax");
            this.Property(t => t.amount_lien).HasColumnName("amount_lien");
            this.Property(t => t.amount_lien_tax).HasColumnName("amount_lien_tax");
            this.Property(t => t.amount_reimbursable).HasColumnName("amount_reimbursable");
            this.Property(t => t.amount_tax).HasColumnName("amount_tax");
            this.Property(t => t.amount_tot_invoice).HasColumnName("amount_tot_invoice");
            this.Property(t => t.amount_vat_invoice).HasColumnName("amount_vat_invoice");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.contact_id_remit_to).HasColumnName("contact_id_remit_to");
            this.Property(t => t.contact_id_send_to).HasColumnName("contact_id_send_to");
            this.Property(t => t.currency_invoice).HasColumnName("currency_invoice");
            this.Property(t => t.date_expected_rec).HasColumnName("date_expected_rec");
            this.Property(t => t.date_sent).HasColumnName("date_sent");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.doc).HasColumnName("doc");
            this.Property(t => t.fac_org_level_01).HasColumnName("fac_org_level_01");
            this.Property(t => t.fac_org_level_02).HasColumnName("fac_org_level_02");
            this.Property(t => t.fac_org_level_03).HasColumnName("fac_org_level_03");
            this.Property(t => t.fac_org_level_04).HasColumnName("fac_org_level_04");
            this.Property(t => t.fac_org_level_05).HasColumnName("fac_org_level_05");
            this.Property(t => t.fac_org_level_06).HasColumnName("fac_org_level_06");
            this.Property(t => t.ls_id).HasColumnName("ls_id");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.pr_id).HasColumnName("pr_id");
            this.Property(t => t.project_id).HasColumnName("project_id");
            this.Property(t => t.qty_accepted).HasColumnName("qty_accepted");
            this.Property(t => t.qty_invoiced).HasColumnName("qty_invoiced");
            this.Property(t => t.qty_received).HasColumnName("qty_received");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.tax_rate).HasColumnName("tax_rate");
            this.Property(t => t.terms).HasColumnName("terms");
            this.Property(t => t.vn_id).HasColumnName("vn_id");
            this.Property(t => t.vn_invoice_num).HasColumnName("vn_invoice_num");
            this.Property(t => t.work_pkg_id).HasColumnName("work_pkg_id");
            this.Property(t => t.invoice_id).HasColumnName("invoice_id");

            // Relationships
            this.HasOptional(t => t.ac)
                .WithMany(t => t.invoices)
                .HasForeignKey(d => d.ac_id);
            this.HasOptional(t => t.afm_currencies)
                .WithMany(t => t.invoices)
                .HasForeignKey(d => d.currency_invoice);
            this.HasOptional(t => t.bl)
                .WithMany(t => t.invoices)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.contact)
                .WithMany(t => t.Invoices)
                .HasForeignKey(d => d.contact_id_remit_to);
            this.HasOptional(t => t.contact1)
                .WithMany(t => t.Invoices1)
                .HasForeignKey(d => d.contact_id_send_to);
            this.HasOptional(t => t.l)
                .WithMany(t => t.invoices)
                .HasForeignKey(d => d.ls_id);
            this.HasOptional(t => t.property)
                .WithMany(t => t.invoices)
                .HasForeignKey(d => d.pr_id);
            this.HasOptional(t => t.project)
                .WithMany(t => t.invoices)
                .HasForeignKey(d => d.project_id);
            this.HasOptional(t => t.vn)
                .WithMany(t => t.invoices)
                .HasForeignKey(d => d.vn_id);
            this.HasOptional(t => t.work_pkgs)
                .WithMany(t => t.invoices)
                .HasForeignKey(d => new { d.project_id, d.work_pkg_id });

        }
    }
}
