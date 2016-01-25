using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class gb_fp_gwp_dataMap : EntityTypeConfiguration<gb_fp_gwp_data>
    {
        public gb_fp_gwp_dataMap()
        {
            // Primary Key
            this.HasKey(t => new { t.version_type, t.version_name, t.gas_ref_name });

            // Properties
            this.Property(t => t.gas_ref_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.version_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.version_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.gas_ref_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("gb_fp_gwp_data", "afm");
            this.Property(t => t.gas_ref_type).HasColumnName("gas_ref_type");
            this.Property(t => t.gwp).HasColumnName("gwp");
            this.Property(t => t.version_type).HasColumnName("version_type");
            this.Property(t => t.version_name).HasColumnName("version_name");
            this.Property(t => t.gas_ref_name).HasColumnName("gas_ref_name");

            // Relationships
            this.HasRequired(t => t.gb_fp_versions)
                .WithMany(t => t.gb_fp_gwp_data)
                .HasForeignKey(d => new { d.version_type, d.version_name });

        }
    }
}
