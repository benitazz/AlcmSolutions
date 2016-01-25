using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class mo_churnMap : EntityTypeConfiguration<mo_churn>
    {
        public mo_churnMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("mo_churn", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.count_em).HasColumnName("count_em");
            this.Property(t => t.count_eq).HasColumnName("count_eq");
            this.Property(t => t.count_ta).HasColumnName("count_ta");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.month).HasColumnName("month");
            this.Property(t => t.num_em_moves).HasColumnName("num_em_moves");
            this.Property(t => t.num_eq_moves).HasColumnName("num_eq_moves");
            this.Property(t => t.num_ta_moves).HasColumnName("num_ta_moves");
            this.Property(t => t.rate_em_moves).HasColumnName("rate_em_moves");
            this.Property(t => t.rate_eq_moves).HasColumnName("rate_eq_moves");
            this.Property(t => t.rate_ta_moves).HasColumnName("rate_ta_moves");
            this.Property(t => t.year).HasColumnName("year");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasOptional(t => t.bl)
                .WithMany(t => t.mo_churn)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.dp)
                .WithMany(t => t.mo_churn)
                .HasForeignKey(d => new { d.dv_id, d.dp_id });
            this.HasOptional(t => t.dv)
                .WithMany(t => t.mo_churn)
                .HasForeignKey(d => d.dv_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.MoChurn)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });

        }
    }
}
