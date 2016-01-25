using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class acbuMap : EntityTypeConfiguration<acbu>
    {
        public acbuMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ac_id, t.year, t.month, t.is_pm });

            // Properties
            this.Property(t => t.ac_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.year)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.month)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.is_pm)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("acbu", "afm");
            this.Property(t => t.budget).HasColumnName("budget");
            this.Property(t => t.ac_id).HasColumnName("ac_id");
            this.Property(t => t.year).HasColumnName("year");
            this.Property(t => t.month).HasColumnName("month");
            this.Property(t => t.is_pm).HasColumnName("is_pm");

            // Relationships
            this.HasRequired(t => t.ac)
                .WithMany(t => t.acbus)
                .HasForeignKey(d => d.ac_id);

        }
    }
}
