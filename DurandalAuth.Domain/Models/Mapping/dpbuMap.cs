using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class dpbuMap : EntityTypeConfiguration<dpbu>
    {
        public dpbuMap()
        {
            // Primary Key
            this.HasKey(t => new { t.dv_id, t.dp_id, t.year, t.month, t.is_pm });

            // Properties
            this.Property(t => t.dv_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dp_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.year)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.month)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.is_pm)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("dpbu", "afm");
            this.Property(t => t.budget).HasColumnName("budget");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.year).HasColumnName("year");
            this.Property(t => t.month).HasColumnName("month");
            this.Property(t => t.is_pm).HasColumnName("is_pm");

            // Relationships
            this.HasRequired(t => t.dp)
                .WithMany(t => t.dpbus)
                .HasForeignKey(d => new { d.dv_id, d.dp_id });
            this.HasRequired(t => t.dv)
                .WithMany(t => t.dpbus)
                .HasForeignKey(d => d.dv_id);

        }
    }
}
