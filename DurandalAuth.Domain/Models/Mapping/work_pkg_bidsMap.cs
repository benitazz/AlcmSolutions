using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class work_pkg_bidsMap : EntityTypeConfiguration<work_pkg_bids>
    {
        public work_pkg_bidsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.project_id, t.work_pkg_id, t.vn_id });

            // Properties
            this.Property(t => t.approved_by)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.bid_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.comments)
                .HasMaxLength(2000);

            this.Property(t => t.contact_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.doc_contract)
                .IsFixedLength()
                .HasMaxLength(160);

            this.Property(t => t.doc_proposal)
                .IsFixedLength()
                .HasMaxLength(160);

            this.Property(t => t.payment_terms)
                .HasMaxLength(2000);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.unit_quantity)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.warranty_desc)
                .HasMaxLength(2000);

            this.Property(t => t.project_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.work_pkg_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.vn_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("work_pkg_bids", "afm");
            this.Property(t => t.approved_by).HasColumnName("approved_by");
            this.Property(t => t.bid_type).HasColumnName("bid_type");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.contact_id).HasColumnName("contact_id");
            this.Property(t => t.cost_bid).HasColumnName("cost_bid");
            this.Property(t => t.cost_contract).HasColumnName("cost_contract");
            this.Property(t => t.date_approved).HasColumnName("date_approved");
            this.Property(t => t.date_contract_end).HasColumnName("date_contract_end");
            this.Property(t => t.date_contract_start).HasColumnName("date_contract_start");
            this.Property(t => t.date_submitted).HasColumnName("date_submitted");
            this.Property(t => t.date_updated).HasColumnName("date_updated");
            this.Property(t => t.date_warranty_exp).HasColumnName("date_warranty_exp");
            this.Property(t => t.doc_contract).HasColumnName("doc_contract");
            this.Property(t => t.doc_proposal).HasColumnName("doc_proposal");
            this.Property(t => t.duration_bidded).HasColumnName("duration_bidded");
            this.Property(t => t.full_scope_bid).HasColumnName("full_scope_bid");
            this.Property(t => t.not_to_exceed).HasColumnName("not_to_exceed");
            this.Property(t => t.payment_terms).HasColumnName("payment_terms");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.time_updated).HasColumnName("time_updated");
            this.Property(t => t.unit_quantity).HasColumnName("unit_quantity");
            this.Property(t => t.warranty_desc).HasColumnName("warranty_desc");
            this.Property(t => t.project_id).HasColumnName("project_id");
            this.Property(t => t.work_pkg_id).HasColumnName("work_pkg_id");
            this.Property(t => t.vn_id).HasColumnName("vn_id");

            // Relationships
            this.HasOptional(t => t.contact)
                .WithMany(t => t.WorkPkgBids)
                .HasForeignKey(d => d.contact_id);
            this.HasOptional(t => t.em)
                .WithMany(t => t.work_pkg_bids)
                .HasForeignKey(d => d.approved_by);
            this.HasRequired(t => t.project)
                .WithMany(t => t.work_pkg_bids)
                .HasForeignKey(d => d.project_id);
            this.HasRequired(t => t.vn)
                .WithMany(t => t.work_pkg_bids)
                .HasForeignKey(d => d.vn_id);
            this.HasRequired(t => t.work_pkgs)
                .WithMany(t => t.work_pkg_bids)
                .HasForeignKey(d => new { d.project_id, d.work_pkg_id });

        }
    }
}
