using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_rolesMap : EntityTypeConfiguration<afm_roles>
    {
        public afm_rolesMap()
        {
            // Primary Key
            this.HasKey(t => t.role_name);

            // Properties
            this.Property(t => t.role_title)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.sql_pwd)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.sql_uid)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.vpa_restriction)
                .HasMaxLength(5000);

            this.Property(t => t.ww_preferences)
                .HasMaxLength(5000);

            this.Property(t => t.license_level)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.preferences)
                .HasMaxLength(1000);

            this.Property(t => t.role_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("afm_roles", "afm");
            this.Property(t => t.role_title).HasColumnName("role_title");
            this.Property(t => t.sql_pwd).HasColumnName("sql_pwd");
            this.Property(t => t.sql_uid).HasColumnName("sql_uid");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.vpa_restriction).HasColumnName("vpa_restriction");
            this.Property(t => t.ww_preferences).HasColumnName("ww_preferences");
            this.Property(t => t.license_level).HasColumnName("license_level");
            this.Property(t => t.preferences).HasColumnName("preferences");
            this.Property(t => t.role_name).HasColumnName("role_name");
        }
    }
}
