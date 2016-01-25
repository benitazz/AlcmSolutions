using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class eqstdMap : EntityTypeConfiguration<eqstd>
    {
        public eqstdMap()
        {
            // Primary Key
            this.HasKey(t => t.eq_std);

            // Properties
            this.Property(t => t.hpattern_acad)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.image_file)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.image_of_block)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.mfr)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.modelno)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.symbol)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.tc_area_level)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.tc_contained_tbls)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.tc_eq_type)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.tc_level)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.tc_service)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.category)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.csi_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.doc_block)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.doc_graphic)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.eq_std)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("eqstd", "afm");
            this.Property(t => t.hpattern_acad).HasColumnName("hpattern_acad");
            this.Property(t => t.image_file).HasColumnName("image_file");
            this.Property(t => t.image_of_block).HasColumnName("image_of_block");
            this.Property(t => t.is_multiplexing).HasColumnName("is_multiplexing");
            this.Property(t => t.mfr).HasColumnName("mfr");
            this.Property(t => t.modelno).HasColumnName("modelno");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.price).HasColumnName("price");
            this.Property(t => t.qty_life_expct).HasColumnName("qty_life_expct");
            this.Property(t => t.spec_amperage).HasColumnName("spec_amperage");
            this.Property(t => t.spec_btu).HasColumnName("spec_btu");
            this.Property(t => t.spec_capacity).HasColumnName("spec_capacity");
            this.Property(t => t.spec_depth).HasColumnName("spec_depth");
            this.Property(t => t.spec_height).HasColumnName("spec_height");
            this.Property(t => t.spec_phase).HasColumnName("spec_phase");
            this.Property(t => t.spec_power).HasColumnName("spec_power");
            this.Property(t => t.spec_voltage).HasColumnName("spec_voltage");
            this.Property(t => t.spec_width).HasColumnName("spec_width");
            this.Property(t => t.symbol).HasColumnName("symbol");
            this.Property(t => t.tc_area_level).HasColumnName("tc_area_level");
            this.Property(t => t.tc_contained_tbls).HasColumnName("tc_contained_tbls");
            this.Property(t => t.tc_eq_type).HasColumnName("tc_eq_type");
            this.Property(t => t.tc_level).HasColumnName("tc_level");
            this.Property(t => t.tc_npositions).HasColumnName("tc_npositions");
            this.Property(t => t.tc_service).HasColumnName("tc_service");
            this.Property(t => t.area).HasColumnName("area");
            this.Property(t => t.category).HasColumnName("category");
            this.Property(t => t.cost_moving).HasColumnName("cost_moving");
            this.Property(t => t.csi_id).HasColumnName("csi_id");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.doc_block).HasColumnName("doc_block");
            this.Property(t => t.doc_graphic).HasColumnName("doc_graphic");
            this.Property(t => t.eq_std).HasColumnName("eq_std");

            // Relationships
            this.HasOptional(t => t.afm_tclevel)
                .WithMany(t => t.eqstds)
                .HasForeignKey(d => d.tc_level);
            this.HasOptional(t => t.csi)
                .WithMany(t => t.eqstds)
                .HasForeignKey(d => d.csi_id);

        }
    }
}
