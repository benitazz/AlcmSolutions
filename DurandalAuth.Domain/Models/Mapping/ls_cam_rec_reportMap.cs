using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ls_cam_rec_reportMap : EntityTypeConfiguration<ls_cam_rec_report>
    {
        public ls_cam_rec_reportMap()
        {
            // Primary Key
            this.HasKey(t => t.ls_cam_rec_report_id);

            // Properties
            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(200);

            this.Property(t => t.ll_cam_report_doc)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.ll_invoice_doc)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.ll_invoice_no)
                .HasMaxLength(64);

            this.Property(t => t.ls_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.support_doc1_id)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.support_doc2_id)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.support_doc3_id)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.support_doc4_id)
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("ls_cam_rec_report", "afm");
            this.Property(t => t.cost_tran_id).HasColumnName("cost_tran_id");
            this.Property(t => t.cost_tran_sched_id).HasColumnName("cost_tran_sched_id");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.invoice_date_received).HasColumnName("invoice_date_received");
            this.Property(t => t.ll_cam_report_doc).HasColumnName("ll_cam_report_doc");
            this.Property(t => t.ll_invoice_doc).HasColumnName("ll_invoice_doc");
            this.Property(t => t.ll_invoice_no).HasColumnName("ll_invoice_no");
            this.Property(t => t.ls_id).HasColumnName("ls_id");
            this.Property(t => t.ls_rent_year).HasColumnName("ls_rent_year");
            this.Property(t => t.support_doc1_id).HasColumnName("support_doc1_id");
            this.Property(t => t.support_doc2_id).HasColumnName("support_doc2_id");
            this.Property(t => t.support_doc3_id).HasColumnName("support_doc3_id");
            this.Property(t => t.support_doc4_id).HasColumnName("support_doc4_id");
            this.Property(t => t.ls_cam_rec_report_id).HasColumnName("ls_cam_rec_report_id");

            // Relationships
            this.HasOptional(t => t.cost_tran)
                .WithMany(t => t.ls_cam_rec_report)
                .HasForeignKey(d => d.cost_tran_id);
            this.HasOptional(t => t.cost_tran_sched)
                .WithMany(t => t.ls_cam_rec_report)
                .HasForeignKey(d => d.cost_tran_sched_id);
            this.HasRequired(t => t.l)
                .WithMany(t => t.ls_cam_rec_report)
                .HasForeignKey(d => d.ls_id);

        }
    }
}
