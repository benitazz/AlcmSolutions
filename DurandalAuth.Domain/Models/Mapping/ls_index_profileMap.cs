using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ls_index_profileMap : EntityTypeConfiguration<ls_index_profile>
    {
        public ls_index_profileMap()
        {
            // Primary Key
            this.HasKey(t => t.ls_id);

            // Properties
            this.Property(t => t.comments)
                .HasMaxLength(256);

            this.Property(t => t.cost_index_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.indexing_frequency)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ls_page)
                .HasMaxLength(12);

            this.Property(t => t.ls_section)
                .HasMaxLength(24);

            this.Property(t => t.ls_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("ls_index_profile", "afm");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.cost_index_id).HasColumnName("cost_index_id");
            this.Property(t => t.date_index_end).HasColumnName("date_index_end");
            this.Property(t => t.date_index_next).HasColumnName("date_index_next");
            this.Property(t => t.date_index_start).HasColumnName("date_index_start");
            this.Property(t => t.index_value_initial).HasColumnName("index_value_initial");
            this.Property(t => t.indexing_frequency).HasColumnName("indexing_frequency");
            this.Property(t => t.limit_max).HasColumnName("limit_max");
            this.Property(t => t.limit_min).HasColumnName("limit_min");
            this.Property(t => t.ls_page).HasColumnName("ls_page");
            this.Property(t => t.ls_section).HasColumnName("ls_section");
            this.Property(t => t.max_rent).HasColumnName("max_rent");
            this.Property(t => t.min_rent).HasColumnName("min_rent");
            this.Property(t => t.pct_change_adjust).HasColumnName("pct_change_adjust");
            this.Property(t => t.rent_initial).HasColumnName("rent_initial");
            this.Property(t => t.rent_round_to).HasColumnName("rent_round_to");
            this.Property(t => t.reset_initial_values).HasColumnName("reset_initial_values");
            this.Property(t => t.ls_id).HasColumnName("ls_id");

            // Relationships
            this.HasRequired(t => t.cost_index)
                .WithMany(t => t.ls_index_profile)
                .HasForeignKey(d => d.cost_index_id);
            this.HasRequired(t => t.l)
                .WithOptional(t => t.ls_index_profile);

        }
    }
}
