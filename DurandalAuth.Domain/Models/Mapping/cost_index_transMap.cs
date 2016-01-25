using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class cost_index_transMap : EntityTypeConfiguration<cost_index_trans>
    {
        public cost_index_transMap()
        {
            // Primary Key
            this.HasKey(t => t.cost_index_trans_id);

            // Properties
            this.Property(t => t.indexing_frequency)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ls_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.cost_index_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(24);

            // Table & Column Mappings
            this.ToTable("cost_index_trans", "afm");
            this.Property(t => t.cost_tran_recur_id).HasColumnName("cost_tran_recur_id");
            this.Property(t => t.date_index).HasColumnName("date_index");
            this.Property(t => t.date_index_last).HasColumnName("date_index_last");
            this.Property(t => t.date_index_next).HasColumnName("date_index_next");
            this.Property(t => t.date_index_value_new).HasColumnName("date_index_value_new");
            this.Property(t => t.index_pct_change).HasColumnName("index_pct_change");
            this.Property(t => t.index_value_initial).HasColumnName("index_value_initial");
            this.Property(t => t.index_value_new).HasColumnName("index_value_new");
            this.Property(t => t.indexing_frequency).HasColumnName("indexing_frequency");
            this.Property(t => t.ls_id).HasColumnName("ls_id");
            this.Property(t => t.pct_change_adjust).HasColumnName("pct_change_adjust");
            this.Property(t => t.rent_indexed).HasColumnName("rent_indexed");
            this.Property(t => t.rent_initial).HasColumnName("rent_initial");
            this.Property(t => t.rent_new).HasColumnName("rent_new");
            this.Property(t => t.rent_pct_change_act).HasColumnName("rent_pct_change_act");
            this.Property(t => t.rent_pct_change_calc).HasColumnName("rent_pct_change_calc");
            this.Property(t => t.rent_round_to).HasColumnName("rent_round_to");
            this.Property(t => t.reset_initial_values).HasColumnName("reset_initial_values");
            this.Property(t => t.cost_index_id).HasColumnName("cost_index_id");
            this.Property(t => t.cost_index_trans_id).HasColumnName("cost_index_trans_id");

            // Relationships
            this.HasRequired(t => t.cost_index)
                .WithMany(t => t.cost_index_trans)
                .HasForeignKey(d => d.cost_index_id);
            this.HasRequired(t => t.cost_tran_recur)
                .WithMany(t => t.cost_index_trans)
                .HasForeignKey(d => d.cost_tran_recur_id);
            this.HasRequired(t => t.l)
                .WithMany(t => t.cost_index_trans)
                .HasForeignKey(d => d.ls_id);

        }
    }
}
