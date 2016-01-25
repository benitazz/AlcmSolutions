using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_groupsforrolesMap : EntityTypeConfiguration<afm_groupsforroles>
    {
        public afm_groupsforrolesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.role_name, t.group_name });

            // Properties
            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.role_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.group_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("afm_groupsforroles", "afm");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.role_name).HasColumnName("role_name");
            this.Property(t => t.group_name).HasColumnName("group_name");

            // Relationships
            this.HasRequired(t => t.afm_groups)
                .WithMany(t => t.afm_groupsforroles)
                .HasForeignKey(d => d.group_name);
            this.HasRequired(t => t.afm_roles)
                .WithMany(t => t.afm_groupsforroles)
                .HasForeignKey(d => d.role_name);

        }
    }
}
