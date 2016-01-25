using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class pmressumMap : EntityTypeConfiguration<pmressum>
    {
        public pmressumMap()
        {
            // Primary Key
            this.HasKey(t => new { t.date_todo, t.resource_type, t.resource_id });

            // Properties
            this.Property(t => t.resource_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.resource_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("pmressum", "afm");
            this.Property(t => t.hours_or_quantity).HasColumnName("hours_or_quantity");
            this.Property(t => t.date_todo).HasColumnName("date_todo");
            this.Property(t => t.resource_type).HasColumnName("resource_type");
            this.Property(t => t.resource_id).HasColumnName("resource_id");
        }
    }
}
