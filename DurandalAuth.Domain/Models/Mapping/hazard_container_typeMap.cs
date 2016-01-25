using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class hazard_container_typeMap : EntityTypeConfiguration<hazard_container_type>
    {
        public hazard_container_typeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.container_cat, t.container_type });

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(512);

            this.Property(t => t.units)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.units_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.container_cat)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.container_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("hazard_container_type", "afm");
            this.Property(t => t.container_size).HasColumnName("container_size");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.units).HasColumnName("units");
            this.Property(t => t.units_type).HasColumnName("units_type");
            this.Property(t => t.container_cat).HasColumnName("container_cat");
            this.Property(t => t.container_type).HasColumnName("container_type");

            // Relationships
            this.HasOptional(t => t.bill_type)
                .WithMany(t => t.hazard_container_type)
                .HasForeignKey(d => d.units_type);
            this.HasOptional(t => t.bill_unit)
                .WithMany(t => t.hazard_container_type)
                .HasForeignKey(d => new { d.units_type, d.units });
            this.HasRequired(t => t.hazard_container_cat)
                .WithMany(t => t.hazard_container_type)
                .HasForeignKey(d => d.container_cat);

        }
    }
}
