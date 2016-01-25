using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_groupsMap : EntityTypeConfiguration<afm_groups>
    {
        public afm_groupsMap()
        {
            // Primary Key
            this.HasKey(t => t.group_name);

            // Properties
            this.Property(t => t.group_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.group_title)
                .HasMaxLength(128);

            this.Property(t => t.ww_preferences)
                .HasMaxLength(5000);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("afm_groups", "afm");
            this.Property(t => t.group_name).HasColumnName("group_name");
            this.Property(t => t.group_title).HasColumnName("group_title");
            this.Property(t => t.ww_preferences).HasColumnName("ww_preferences");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
        }
    }
}
