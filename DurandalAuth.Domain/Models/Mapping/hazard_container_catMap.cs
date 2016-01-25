using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class hazard_container_catMap : EntityTypeConfiguration<hazard_container_cat>
    {
        public hazard_container_catMap()
        {
            // Primary Key
            this.HasKey(t => t.container_cat);

            // Properties
            this.Property(t => t.activity_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.description)
                .HasMaxLength(512);

            this.Property(t => t.container_cat)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("hazard_container_cat", "afm");
            this.Property(t => t.activity_id).HasColumnName("activity_id");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.container_cat).HasColumnName("container_cat");

            // Relationships
            this.HasRequired(t => t.afm_activities)
                .WithMany(t => t.hazard_container_cat)
                .HasForeignKey(d => d.activity_id);

        }
    }
}
