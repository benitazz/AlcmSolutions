using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class gb_fp_refrig_dataMap : EntityTypeConfiguration<gb_fp_refrig_data>
    {
        public gb_fp_refrig_dataMap()
        {
            // Primary Key
            this.HasKey(t => new { t.version_type, t.version_name, t.refrig_ac_type });

            // Properties
            this.Property(t => t.eq_std)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.units)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.units_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.version_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.version_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.refrig_ac_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("gb_fp_refrig_data", "afm");
            this.Property(t => t.charge).HasColumnName("charge");
            this.Property(t => t.charge_entry).HasColumnName("charge_entry");
            this.Property(t => t.eq_std).HasColumnName("eq_std");
            this.Property(t => t.operation_emiss).HasColumnName("operation_emiss");
            this.Property(t => t.units).HasColumnName("units");
            this.Property(t => t.units_type).HasColumnName("units_type");
            this.Property(t => t.version_type).HasColumnName("version_type");
            this.Property(t => t.version_name).HasColumnName("version_name");
            this.Property(t => t.refrig_ac_type).HasColumnName("refrig_ac_type");

            // Relationships
            this.HasRequired(t => t.bill_type)
                .WithMany(t => t.gb_fp_refrig_data)
                .HasForeignKey(d => d.units_type);
            this.HasRequired(t => t.bill_unit)
                .WithMany(t => t.gb_fp_refrig_data)
                .HasForeignKey(d => new { d.units_type, d.units });
            this.HasOptional(t => t.eqstd)
                .WithMany(t => t.gb_fp_refrig_data)
                .HasForeignKey(d => d.eq_std);
            this.HasRequired(t => t.gb_fp_versions)
                .WithMany(t => t.gb_fp_refrig_data)
                .HasForeignKey(d => new { d.version_type, d.version_name });

        }
    }
}
