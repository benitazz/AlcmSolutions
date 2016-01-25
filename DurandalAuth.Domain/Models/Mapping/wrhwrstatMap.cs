using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class wrhwrstatMap : EntityTypeConfiguration<wrhwrstat>
    {
        public wrhwrstatMap()
        {
            // Primary Key
            this.HasKey(t => new { t.status, t.status_sort });

            // Properties
            this.Property(t => t.perform_date)
                .HasMaxLength(7);

            this.Property(t => t.prob_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.status_sort)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("wrhwrstat", "afm");
            this.Property(t => t.perform_date).HasColumnName("perform_date");
            this.Property(t => t.prob_type).HasColumnName("prob_type");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.status_sort).HasColumnName("status_sort");
            this.Property(t => t.count_wr).HasColumnName("count_wr");
            this.Property(t => t.est_labor_sum).HasColumnName("est_labor_sum");
            this.Property(t => t.act_labor_sum).HasColumnName("act_labor_sum");
            this.Property(t => t.avg_labor_dif).HasColumnName("avg_labor_dif");
            this.Property(t => t.est_cost_sum).HasColumnName("est_cost_sum");
            this.Property(t => t.act_cost_sum).HasColumnName("act_cost_sum");
            this.Property(t => t.avg_cost_dif).HasColumnName("avg_cost_dif");
        }
    }
}
