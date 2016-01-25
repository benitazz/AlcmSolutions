using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class system_blMap : EntityTypeConfiguration<system_bl>
    {
        public system_blMap()
        {
            // Primary Key
            this.HasKey(t => t.system_id);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.comments)
                .HasMaxLength(2000);

            this.Property(t => t.contact_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.recovery_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.system_type)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.system_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("system_bl", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.contact_id).HasColumnName("contact_id");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.recovery_status).HasColumnName("recovery_status");
            this.Property(t => t.system_type).HasColumnName("system_type");
            this.Property(t => t.system_id).HasColumnName("system_id");

            // Relationships
            this.HasOptional(t => t.bl)
                .WithMany(t => t.system_bl)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.contact)
                .WithMany(t => t.SystemBl)
                .HasForeignKey(d => d.contact_id);
            this.HasOptional(t => t.system_type1)
                .WithMany(t => t.system_bl)
                .HasForeignKey(d => d.system_type);

        }
    }
}
