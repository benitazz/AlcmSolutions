using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_roleprocsMap : EntityTypeConfiguration<afm_roleprocs>
    {
        public afm_roleprocsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.role_name, t.activity_id, t.process_id });

            // Properties
            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.role_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.activity_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.process_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("afm_roleprocs", "afm");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.role_name).HasColumnName("role_name");
            this.Property(t => t.activity_id).HasColumnName("activity_id");
            this.Property(t => t.process_id).HasColumnName("process_id");

            // Relationships
            this.HasRequired(t => t.afm_activities)
                .WithMany(t => t.afm_roleprocs)
                .HasForeignKey(d => d.activity_id);
            this.HasRequired(t => t.afm_processes)
                .WithMany(t => t.afm_roleprocs)
                .HasForeignKey(d => new { d.activity_id, d.process_id });
            this.HasRequired(t => t.afm_roles)
                .WithMany(t => t.afm_roleprocs)
                .HasForeignKey(d => d.role_name);

        }
    }
}
