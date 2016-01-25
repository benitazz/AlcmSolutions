using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ls_chrgbck_agreeMap : EntityTypeConfiguration<ls_chrgbck_agree>
    {
        public ls_chrgbck_agreeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ls_id, t.cost_cat_id });

            // Properties
            this.Property(t => t.charge_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.comments)
                .HasMaxLength(2000);

            this.Property(t => t.ls_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.cost_cat_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("ls_chrgbck_agree", "afm");
            this.Property(t => t.amount_cap_lower).HasColumnName("amount_cap_lower");
            this.Property(t => t.amount_fixed).HasColumnName("amount_fixed");
            this.Property(t => t.charge_type).HasColumnName("charge_type");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.pct_factor).HasColumnName("pct_factor");
            this.Property(t => t.ls_id).HasColumnName("ls_id");
            this.Property(t => t.cost_cat_id).HasColumnName("cost_cat_id");

            // Relationships
            this.HasRequired(t => t.cost_cat)
                .WithMany(t => t.ls_chrgbck_agree)
                .HasForeignKey(d => d.cost_cat_id);
            this.HasRequired(t => t.l)
                .WithMany(t => t.ls_chrgbck_agree)
                .HasForeignKey(d => d.ls_id);

        }
    }
}
