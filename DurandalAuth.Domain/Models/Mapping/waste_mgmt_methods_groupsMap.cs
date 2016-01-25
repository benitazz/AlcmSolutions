using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class waste_mgmt_methods_groupsMap : EntityTypeConfiguration<waste_mgmt_methods_groups>
    {
        public waste_mgmt_methods_groupsMap()
        {
            // Primary Key
            this.HasKey(t => t.method_group);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(1000);

            this.Property(t => t.method_group)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(65);

            // Table & Column Mappings
            this.ToTable("waste_mgmt_methods_groups", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.method_group).HasColumnName("method_group");
        }
    }
}
