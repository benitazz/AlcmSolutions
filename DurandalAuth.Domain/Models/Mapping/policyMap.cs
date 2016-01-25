using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class policyMap : EntityTypeConfiguration<policy>
    {
        public policyMap()
        {
            // Primary Key
            this.HasKey(t => t.policy_id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(5000);

            this.Property(t => t.insurer_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.policy_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("policy", "afm");
            this.Property(t => t.date_end).HasColumnName("date_end");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.insurer_id).HasColumnName("insurer_id");
            this.Property(t => t.value).HasColumnName("value");
            this.Property(t => t.policy_id).HasColumnName("policy_id");

            // Relationships
            this.HasOptional(t => t.insurer)
                .WithMany(t => t.policies)
                .HasForeignKey(d => d.insurer_id);

        }
    }
}
