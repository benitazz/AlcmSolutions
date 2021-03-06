using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class gb_fp_s3_servMap : EntityTypeConfiguration<gb_fp_s3_serv>
    {
        public gb_fp_s3_servMap()
        {
            // Primary Key
            this.HasKey(t => t.source_id);

            // Properties
            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.description)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.scenario_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.units)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.units_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("gb_fp_s3_serv", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.calc_year).HasColumnName("calc_year");
            this.Property(t => t.consumption).HasColumnName("consumption");
            this.Property(t => t.consumption_entry).HasColumnName("consumption_entry");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.kg_co2).HasColumnName("kg_co2");
            this.Property(t => t.scenario_id).HasColumnName("scenario_id");
            this.Property(t => t.units).HasColumnName("units");
            this.Property(t => t.units_type).HasColumnName("units_type");
            this.Property(t => t.source_id).HasColumnName("source_id");

            // Relationships
            this.HasRequired(t => t.bill_type)
                .WithMany(t => t.gb_fp_s3_serv)
                .HasForeignKey(d => d.units_type);
            this.HasRequired(t => t.bill_unit)
                .WithMany(t => t.gb_fp_s3_serv)
                .HasForeignKey(d => new { d.units_type, d.units });
            this.HasRequired(t => t.gb_fp_setup)
                .WithMany(t => t.gb_fp_s3_serv)
                .HasForeignKey(d => new { d.bl_id, d.calc_year, d.scenario_id });

        }
    }
}
