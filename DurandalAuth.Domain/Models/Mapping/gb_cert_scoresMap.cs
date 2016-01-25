using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class gb_cert_scoresMap : EntityTypeConfiguration<gb_cert_scores>
    {
        public gb_cert_scoresMap()
        {
            // Primary Key
            this.HasKey(t => new { t.bl_id, t.cert_std, t.project_name, t.cert_cat, t.credit_num, t.subcredit_num, t.credit_type });

            // Properties
            this.Property(t => t.final_notes)
                .HasMaxLength(300);

            this.Property(t => t.score_note)
                .HasMaxLength(300);

            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.cert_std)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.project_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.cert_cat)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.credit_num)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.subcredit_num)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.credit_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("gb_cert_scores", "afm");
            this.Property(t => t.annual_savings).HasColumnName("annual_savings");
            this.Property(t => t.capital_cost).HasColumnName("capital_cost");
            this.Property(t => t.final_notes).HasColumnName("final_notes");
            this.Property(t => t.final_score).HasColumnName("final_score");
            this.Property(t => t.last_update).HasColumnName("last_update");
            this.Property(t => t.score_note).HasColumnName("score_note");
            this.Property(t => t.self_score).HasColumnName("self_score");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.cert_std).HasColumnName("cert_std");
            this.Property(t => t.project_name).HasColumnName("project_name");
            this.Property(t => t.cert_cat).HasColumnName("cert_cat");
            this.Property(t => t.credit_num).HasColumnName("credit_num");
            this.Property(t => t.subcredit_num).HasColumnName("subcredit_num");
            this.Property(t => t.credit_type).HasColumnName("credit_type");

            // Relationships
            this.HasRequired(t => t.bl)
                .WithMany(t => t.gb_cert_scores)
                .HasForeignKey(d => d.bl_id);
            this.HasRequired(t => t.gb_cert_cat)
                .WithMany(t => t.gb_cert_scores)
                .HasForeignKey(d => new { d.cert_std, d.cert_cat });
            this.HasRequired(t => t.gb_cert_credits)
                .WithMany(t => t.gb_cert_scores)
                .HasForeignKey(d => new { d.cert_std, d.cert_cat, d.credit_num, d.subcredit_num, d.credit_type });
            this.HasRequired(t => t.gb_cert_proj)
                .WithMany(t => t.gb_cert_scores)
                .HasForeignKey(d => new { d.bl_id, d.cert_std, d.project_name });
            this.HasRequired(t => t.gb_cert_std)
                .WithMany(t => t.gb_cert_scores)
                .HasForeignKey(d => d.cert_std);

        }
    }
}
