using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class waste_mgmt_methodsMap : EntityTypeConfiguration<waste_mgmt_methods>
    {
        public waste_mgmt_methodsMap()
        {
            // Primary Key
            this.HasKey(t => t.method_code);

            // Properties
            this.Property(t => t.method_group)
                .IsFixedLength()
                .HasMaxLength(65);

            this.Property(t => t.method_name)
                .HasMaxLength(200);

            this.Property(t => t.method_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("waste_mgmt_methods", "afm");
            this.Property(t => t.method_group).HasColumnName("method_group");
            this.Property(t => t.method_name).HasColumnName("method_name");
            this.Property(t => t.method_code).HasColumnName("method_code");

            // Relationships
            this.HasOptional(t => t.waste_mgmt_methods_groups)
                .WithMany(t => t.waste_mgmt_methods)
                .HasForeignKey(d => d.method_group);

        }
    }
}
