using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class helpdesk_rolesMap : EntityTypeConfiguration<helpdesk_roles>
    {
        public helpdesk_rolesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.role, t.step_type });

            /*// Properties
            this.Property(t => t.class)
                .IsFixedLength()
                .HasMaxLength(64);*/

            this.Property(t => t.method)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.role)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.step_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("helpdesk_roles", "afm");
            /*this.Property(t => t.class).HasColumnName("class");*/
            this.Property(t => t.method).HasColumnName("method");
            this.Property(t => t.role).HasColumnName("role");
            this.Property(t => t.step_type).HasColumnName("step_type");
        }
    }
}
