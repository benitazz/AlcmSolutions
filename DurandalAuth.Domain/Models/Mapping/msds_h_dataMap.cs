using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class msds_h_dataMap : EntityTypeConfiguration<msds_h_data>
    {
        public msds_h_dataMap()
        {
            // Primary Key
            this.HasKey(t => new { t.msds_id, t.date_archived, t.time_archived });

            // Properties
            this.Property(t => t.density_operator)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.density_units)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.density_units_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.distributor_id)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.doc)
                .HasMaxLength(64);

            this.Property(t => t.evacuation_radius_units)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.evacuation_radius_units_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.flashpoint_operator)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.flashpoint_units)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.ghs_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.manufacturer_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.physical_state)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.preparer_id)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.product_code)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.product_name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.provider_msds_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.specific_gravity_operator)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.url)
                .HasMaxLength(512);

            this.Property(t => t.vapor_density_operator)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.vapor_density_units)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.vapor_density_units_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.voc_operator)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.voc_units)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.voc_units_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.chemical_name)
                .HasMaxLength(100);

            this.Property(t => t.msds_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("msds_h_data", "afm");
            this.Property(t => t.date_issued).HasColumnName("date_issued");
            this.Property(t => t.date_replaced).HasColumnName("date_replaced");
            this.Property(t => t.date_supersedes).HasColumnName("date_supersedes");
            this.Property(t => t.density_high).HasColumnName("density_high");
            this.Property(t => t.density_low).HasColumnName("density_low");
            this.Property(t => t.density_operator).HasColumnName("density_operator");
            this.Property(t => t.density_units).HasColumnName("density_units");
            this.Property(t => t.density_units_type).HasColumnName("density_units_type");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.distributor_id).HasColumnName("distributor_id");
            this.Property(t => t.doc).HasColumnName("doc");
            this.Property(t => t.evacuation_radius).HasColumnName("evacuation_radius");
            this.Property(t => t.evacuation_radius_units).HasColumnName("evacuation_radius_units");
            this.Property(t => t.evacuation_radius_units_type).HasColumnName("evacuation_radius_units_type");
            this.Property(t => t.flashpoint_operator).HasColumnName("flashpoint_operator");
            this.Property(t => t.flashpoint_units).HasColumnName("flashpoint_units");
            this.Property(t => t.flashpont).HasColumnName("flashpont");
            this.Property(t => t.ghs_id).HasColumnName("ghs_id");
            this.Property(t => t.manufacturer_id).HasColumnName("manufacturer_id");
            this.Property(t => t.physical_state).HasColumnName("physical_state");
            this.Property(t => t.preparer_id).HasColumnName("preparer_id");
            this.Property(t => t.product_code).HasColumnName("product_code");
            this.Property(t => t.product_name).HasColumnName("product_name");
            this.Property(t => t.provider_msds_id).HasColumnName("provider_msds_id");
            this.Property(t => t.specific_gravity_high).HasColumnName("specific_gravity_high");
            this.Property(t => t.specific_gravity_low).HasColumnName("specific_gravity_low");
            this.Property(t => t.specific_gravity_operator).HasColumnName("specific_gravity_operator");
            this.Property(t => t.url).HasColumnName("url");
            this.Property(t => t.vapor_density_high).HasColumnName("vapor_density_high");
            this.Property(t => t.vapor_density_low).HasColumnName("vapor_density_low");
            this.Property(t => t.vapor_density_operator).HasColumnName("vapor_density_operator");
            this.Property(t => t.vapor_density_units).HasColumnName("vapor_density_units");
            this.Property(t => t.vapor_density_units_type).HasColumnName("vapor_density_units_type");
            this.Property(t => t.voc_high).HasColumnName("voc_high");
            this.Property(t => t.voc_low).HasColumnName("voc_low");
            this.Property(t => t.voc_operator).HasColumnName("voc_operator");
            this.Property(t => t.voc_units).HasColumnName("voc_units");
            this.Property(t => t.voc_units_type).HasColumnName("voc_units_type");
            this.Property(t => t.chemical_name).HasColumnName("chemical_name");
            this.Property(t => t.msds_id).HasColumnName("msds_id");
            this.Property(t => t.date_archived).HasColumnName("date_archived");
            this.Property(t => t.time_archived).HasColumnName("time_archived");
        }
    }
}
