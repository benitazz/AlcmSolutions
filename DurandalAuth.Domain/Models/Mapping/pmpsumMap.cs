using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class pmpsumMap : EntityTypeConfiguration<pmpsum>
    {
        public pmpsumMap()
        {
            // Primary Key
            this.HasKey(t => new { t.date_todo, t.eq_id, t.pmp_id, t.tr_id });

            // Properties
            this.Property(t => t.eq_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.pmp_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.tr_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("pmpsum", "afm");
            this.Property(t => t.hours).HasColumnName("hours");
            this.Property(t => t.date_todo).HasColumnName("date_todo");
            this.Property(t => t.eq_id).HasColumnName("eq_id");
            this.Property(t => t.pmp_id).HasColumnName("pmp_id");
            this.Property(t => t.tr_id).HasColumnName("tr_id");
        }
    }
}
