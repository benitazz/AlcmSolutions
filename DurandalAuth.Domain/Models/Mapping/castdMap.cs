using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class castdMap : EntityTypeConfiguration<castd>
    {
        public castdMap()
        {
            // Primary Key
            this.HasKey(t => t.ca_std);

            // Properties
            this.Property(t => t.ca_type)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(100);

            this.Property(t => t.layer_name)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.mfr)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.num_serial)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.tc_cabling_level)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.tc_contained_tbls)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.tc_level)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.tc_service)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.vn_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.ca_std)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("castd", "afm");
            this.Property(t => t.ca_type).HasColumnName("ca_type");
            this.Property(t => t.color).HasColumnName("color");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.diameter).HasColumnName("diameter");
            this.Property(t => t.diameter_core).HasColumnName("diameter_core");
            this.Property(t => t.is_multiplexing).HasColumnName("is_multiplexing");
            this.Property(t => t.layer_name).HasColumnName("layer_name");
            this.Property(t => t.length_max).HasColumnName("length_max");
            this.Property(t => t.mfr).HasColumnName("mfr");
            this.Property(t => t.num_pairs).HasColumnName("num_pairs");
            this.Property(t => t.num_serial).HasColumnName("num_serial");
            this.Property(t => t.tc_cabling_level).HasColumnName("tc_cabling_level");
            this.Property(t => t.tc_contained_tbls).HasColumnName("tc_contained_tbls");
            this.Property(t => t.tc_level).HasColumnName("tc_level");
            this.Property(t => t.tc_npositions).HasColumnName("tc_npositions");
            this.Property(t => t.tc_service).HasColumnName("tc_service");
            this.Property(t => t.unit_cost).HasColumnName("unit_cost");
            this.Property(t => t.unit_weight).HasColumnName("unit_weight");
            this.Property(t => t.vn_id).HasColumnName("vn_id");
            this.Property(t => t.bandwidth).HasColumnName("bandwidth");
            this.Property(t => t.ca_std).HasColumnName("ca_std");

            // Relationships
            this.HasOptional(t => t.afm_tclevel)
                .WithMany(t => t.castds)
                .HasForeignKey(d => d.tc_level);
            this.HasOptional(t => t.catype)
                .WithMany(t => t.castds)
                .HasForeignKey(d => d.ca_type);
            this.HasOptional(t => t.vn)
                .WithMany(t => t.castds)
                .HasForeignKey(d => d.vn_id);

        }
    }
}
