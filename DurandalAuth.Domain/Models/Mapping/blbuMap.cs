using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class blbuMap : EntityTypeConfiguration<blbu>
    {
        public blbuMap()
        {
            // Primary Key
            this.HasKey(t => new { t.bl_id, t.year, t.month, t.is_pm });

            // Properties
            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.year)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.month)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.is_pm)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("blbu", "afm");
            this.Property(t => t.budget).HasColumnName("budget");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.year).HasColumnName("year");
            this.Property(t => t.month).HasColumnName("month");
            this.Property(t => t.is_pm).HasColumnName("is_pm");

            // Relationships
            this.HasRequired(t => t.bl)
                .WithMany(t => t.blbus)
                .HasForeignKey(d => d.bl_id);

        }
    }
}
