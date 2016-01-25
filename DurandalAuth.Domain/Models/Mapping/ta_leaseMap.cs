using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ta_leaseMap : EntityTypeConfiguration<ta_lease>
    {
        public ta_leaseMap()
        {
            // Primary Key
            this.HasKey(t => t.ta_lease_id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(5000);

            this.Property(t => t.lessor_id)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.ta_lease_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("ta_lease", "afm");
            this.Property(t => t.cancel_option).HasColumnName("cancel_option");
            this.Property(t => t.date_end).HasColumnName("date_end");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.lessor_id).HasColumnName("lessor_id");
            this.Property(t => t.renew_option).HasColumnName("renew_option");
            this.Property(t => t.retain_option).HasColumnName("retain_option");
            this.Property(t => t.ta_lease_id).HasColumnName("ta_lease_id");

            // Relationships
            this.HasOptional(t => t.lessor)
                .WithMany(t => t.ta_lease)
                .HasForeignKey(d => d.lessor_id);

        }
    }
}
