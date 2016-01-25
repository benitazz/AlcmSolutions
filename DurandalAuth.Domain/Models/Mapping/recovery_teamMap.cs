using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class recovery_teamMap : EntityTypeConfiguration<recovery_team>
    {
        public recovery_teamMap()
        {
            // Primary Key
            this.HasKey(t => new { t.dv_id, t.role });

            // Properties
            this.Property(t => t.em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.dv_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.role)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("recovery_team", "afm");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.role).HasColumnName("role");

            // Relationships
            this.HasRequired(t => t.dv)
                .WithMany(t => t.recovery_team)
                .HasForeignKey(d => d.dv_id);
            this.HasOptional(t => t.em)
                .WithMany(t => t.recovery_team)
                .HasForeignKey(d => d.em_id);

        }
    }
}
