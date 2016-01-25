using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_activity_paramsMap : EntityTypeConfiguration<afm_activity_params>
    {
        public afm_activity_paramsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.activity_id, t.param_id });

            // Properties
            this.Property(t => t.applies_to)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.param_value)
                .IsRequired()
                .HasMaxLength(512);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.activity_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.param_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("afm_activity_params", "afm");
            this.Property(t => t.applies_to).HasColumnName("applies_to");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.param_value).HasColumnName("param_value");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.activity_id).HasColumnName("activity_id");
            this.Property(t => t.param_id).HasColumnName("param_id");

            // Relationships
            this.HasRequired(t => t.afm_activities)
                .WithMany(t => t.afm_activity_params)
                .HasForeignKey(d => d.activity_id);

        }
    }
}
