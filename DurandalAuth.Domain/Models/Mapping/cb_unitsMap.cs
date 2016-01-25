using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class cb_unitsMap : EntityTypeConfiguration<cb_units>
    {
        public cb_unitsMap()
        {
            // Primary Key
            this.HasKey(t => t.cb_units_id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(512);

            this.Property(t => t.name)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.prob_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.cb_units_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("cb_units", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.prob_type).HasColumnName("prob_type");
            this.Property(t => t.cb_units_id).HasColumnName("cb_units_id");

            // Relationships
            this.HasOptional(t => t.probtype)
                .WithMany(t => t.cb_units)
                .HasForeignKey(d => d.prob_type);

        }
    }
}
