using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class wohwostatMap : EntityTypeConfiguration<wohwostat>
    {
        public wohwostatMap()
        {
            // Primary Key
            this.HasKey(t => t.is_complete);

            // Properties
            this.Property(t => t.perform_date)
                .HasMaxLength(7);

            this.Property(t => t.wo_type)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.tr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.is_complete)
                .IsRequired()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("wohwostat", "afm");
            this.Property(t => t.perform_date).HasColumnName("perform_date");
            this.Property(t => t.wo_type).HasColumnName("wo_type");
            this.Property(t => t.tr_id).HasColumnName("tr_id");
            this.Property(t => t.is_complete).HasColumnName("is_complete");
            this.Property(t => t.count_wo).HasColumnName("count_wo");
            this.Property(t => t.est_cost_sum).HasColumnName("est_cost_sum");
            this.Property(t => t.act_cost_sum).HasColumnName("act_cost_sum");
            this.Property(t => t.avg_cost_dif).HasColumnName("avg_cost_dif");
        }
    }
}
