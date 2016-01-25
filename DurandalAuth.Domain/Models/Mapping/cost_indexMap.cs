using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class cost_indexMap : EntityTypeConfiguration<cost_index>
    {
        public cost_indexMap()
        {
            // Primary Key
            this.HasKey(t => t.cost_index_id);

            // Properties
            this.Property(t => t.cost_index_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.description)
                .HasMaxLength(240);

            this.Property(t => t.cost_index_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(24);

            // Table & Column Mappings
            this.ToTable("cost_index", "afm");
            this.Property(t => t.cost_index_name).HasColumnName("cost_index_name");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.cost_index_id).HasColumnName("cost_index_id");
        }
    }
}
