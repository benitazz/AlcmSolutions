using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class pmpstrMap : EntityTypeConfiguration<pmpstr>
    {
        public pmpstrMap()
        {
            // Primary Key
            this.HasKey(t => new { t.pmp_id, t.pmps_id, t.tr_id });

            // Properties
            this.Property(t => t.pmp_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.pmps_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.tr_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("pmpstr", "afm");
            this.Property(t => t.hours_req).HasColumnName("hours_req");
            this.Property(t => t.pmp_id).HasColumnName("pmp_id");
            this.Property(t => t.pmps_id).HasColumnName("pmps_id");
            this.Property(t => t.tr_id).HasColumnName("tr_id");

            // Relationships
            this.HasRequired(t => t.pmp)
                .WithMany(t => t.pmpstrs)
                .HasForeignKey(d => d.pmp_id);
            this.HasRequired(t => t.pmp1)
                .WithMany(t => t.pmpstrs)
                .HasForeignKey(d => new { d.pmp_id, d.pmps_id });
            this.HasRequired(t => t.tr)
                .WithMany(t => t.pmpstrs)
                .HasForeignKey(d => d.tr_id);

        }
    }
}
