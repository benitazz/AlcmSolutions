using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class gb_fp_mobile_dataMap : EntityTypeConfiguration<gb_fp_mobile_data>
    {
        public gb_fp_mobile_dataMap()
        {
            // Primary Key
            this.HasKey(t => new { t.version_type, t.version_name, t.vehicle_type });

            // Properties
            this.Property(t => t.ch4_n2o_units)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.ch4_n2o_units_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.co2_units)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.co2_units_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.transp_type)
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

            this.Property(t => t.vehicle_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("gb_fp_mobile_data", "afm");
            this.Property(t => t.ch4).HasColumnName("ch4");
            this.Property(t => t.ch4_entry).HasColumnName("ch4_entry");
            this.Property(t => t.ch4_n2o_units).HasColumnName("ch4_n2o_units");
            this.Property(t => t.ch4_n2o_units_type).HasColumnName("ch4_n2o_units_type");
            this.Property(t => t.co2).HasColumnName("co2");
            this.Property(t => t.co2_entry).HasColumnName("co2_entry");
            this.Property(t => t.co2_units).HasColumnName("co2_units");
            this.Property(t => t.co2_units_type).HasColumnName("co2_units_type");
            this.Property(t => t.n2o).HasColumnName("n2o");
            this.Property(t => t.n2o_entry).HasColumnName("n2o_entry");
            this.Property(t => t.transp_type).HasColumnName("transp_type");
            this.Property(t => t.version_type).HasColumnName("version_type");
            this.Property(t => t.version_name).HasColumnName("version_name");
            this.Property(t => t.vehicle_type).HasColumnName("vehicle_type");

            // Relationships
            this.HasRequired(t => t.bill_type)
                .WithMany(t => t.gb_fp_mobile_data)
                .HasForeignKey(d => d.ch4_n2o_units_type);
            this.HasRequired(t => t.bill_type1)
                .WithMany(t => t.gb_fp_mobile_data1)
                .HasForeignKey(d => d.co2_units_type);
            this.HasRequired(t => t.bill_unit)
                .WithMany(t => t.gb_fp_mobile_data)
                .HasForeignKey(d => new { d.ch4_n2o_units_type, d.ch4_n2o_units });
            this.HasRequired(t => t.bill_unit1)
                .WithMany(t => t.gb_fp_mobile_data1)
                .HasForeignKey(d => new { d.co2_units_type, d.co2_units });
            this.HasRequired(t => t.gb_fp_versions)
                .WithMany(t => t.gb_fp_mobile_data)
                .HasForeignKey(d => new { d.version_type, d.version_name });

        }
    }
}
