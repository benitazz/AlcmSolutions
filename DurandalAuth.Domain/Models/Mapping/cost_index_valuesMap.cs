using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class cost_index_valuesMap : EntityTypeConfiguration<cost_index_values>
    {
        public cost_index_valuesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.cost_index_id, t.date_index_value });

            // Properties
            this.Property(t => t.cost_index_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(24);

            // Table & Column Mappings
            this.ToTable("cost_index_values", "afm");
            this.Property(t => t.index_value).HasColumnName("index_value");
            this.Property(t => t.cost_index_id).HasColumnName("cost_index_id");
            this.Property(t => t.date_index_value).HasColumnName("date_index_value");

            // Relationships
            this.HasRequired(t => t.cost_index)
                .WithMany(t => t.cost_index_values)
                .HasForeignKey(d => d.cost_index_id);

        }
    }
}
