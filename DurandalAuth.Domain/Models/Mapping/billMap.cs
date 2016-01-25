using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class billMap : EntityTypeConfiguration<bill>
    {
        public billMap()
        {
            // Primary Key
            this.HasKey(t => new { t.vn_id, t.bill_id });

            // Properties
            this.Property(t => t.bill_type_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.description)
                .HasMaxLength(5000);

            this.Property(t => t.doc)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.site_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.time_period)
                .IsFixedLength()
                .HasMaxLength(7);

            this.Property(t => t.vn_ac_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.vn_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.bill_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("bill", "afm");
            this.Property(t => t.bill_type_id).HasColumnName("bill_type_id");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.cost_kwh).HasColumnName("cost_kwh");
            this.Property(t => t.cost_mmbtu).HasColumnName("cost_mmbtu");
            this.Property(t => t.cost_tran_sched_id).HasColumnName("cost_tran_sched_id");
            this.Property(t => t.count_lines).HasColumnName("count_lines");
            this.Property(t => t.date_approved).HasColumnName("date_approved");
            this.Property(t => t.date_due).HasColumnName("date_due");
            this.Property(t => t.date_exported).HasColumnName("date_exported");
            this.Property(t => t.date_issued).HasColumnName("date_issued");
            this.Property(t => t.date_paid).HasColumnName("date_paid");
            this.Property(t => t.date_service_end).HasColumnName("date_service_end");
            this.Property(t => t.date_service_start).HasColumnName("date_service_start");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.doc).HasColumnName("doc");
            this.Property(t => t.expense_variance_avg).HasColumnName("expense_variance_avg");
            this.Property(t => t.expense_variance_month).HasColumnName("expense_variance_month");
            this.Property(t => t.expense_variance_year).HasColumnName("expense_variance_year");
            this.Property(t => t.income_variance_avg).HasColumnName("income_variance_avg");
            this.Property(t => t.income_variance_month).HasColumnName("income_variance_month");
            this.Property(t => t.income_variance_year).HasColumnName("income_variance_year");
            this.Property(t => t.qty_energy).HasColumnName("qty_energy");
            this.Property(t => t.qty_kwh).HasColumnName("qty_kwh");
            this.Property(t => t.qty_power).HasColumnName("qty_power");
            this.Property(t => t.qty_volume).HasColumnName("qty_volume");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.time_period).HasColumnName("time_period");
            this.Property(t => t.vn_ac_id).HasColumnName("vn_ac_id");
            this.Property(t => t.amount_expense).HasColumnName("amount_expense");
            this.Property(t => t.amount_income).HasColumnName("amount_income");
            this.Property(t => t.vn_id).HasColumnName("vn_id");
            this.Property(t => t.bill_id).HasColumnName("bill_id");

            // Relationships
            this.HasRequired(t => t.bill_type)
                .WithMany(t => t.bills)
                .HasForeignKey(d => d.bill_type_id);
            this.HasRequired(t => t.bl)
                .WithMany(t => t.bills)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.cost_tran_sched)
                .WithMany(t => t.bills)
                .HasForeignKey(d => d.cost_tran_sched_id);
            this.HasRequired(t => t.site)
                .WithMany(t => t.bills)
                .HasForeignKey(d => d.site_id);
            this.HasOptional(t => t.energy_time_period)
                .WithMany(t => t.bills)
                .HasForeignKey(d => d.time_period);
            this.HasRequired(t => t.vn_ac)
                .WithMany(t => t.bills)
                .HasForeignKey(d => new { d.vn_id, d.vn_ac_id });
            this.HasRequired(t => t.vn)
                .WithMany(t => t.bills)
                .HasForeignKey(d => d.vn_id);

        }
    }
}
