using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class fpstdMap : EntityTypeConfiguration<fpstd>
    {
        public fpstdMap()
        {
            // Primary Key
            this.HasKey(t => t.fp_std);

            // Properties
            this.Property(t => t.fp_type)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.image_file)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.symbol)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.tc_contained_tbls)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.tc_level)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.doc_image)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.fp_std)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("fpstd", "afm");
            this.Property(t => t.fp_type).HasColumnName("fp_type");
            this.Property(t => t.image_file).HasColumnName("image_file");
            this.Property(t => t.symbol).HasColumnName("symbol");
            this.Property(t => t.tc_contained_tbls).HasColumnName("tc_contained_tbls");
            this.Property(t => t.tc_level).HasColumnName("tc_level");
            this.Property(t => t.tc_npositions).HasColumnName("tc_npositions");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.doc_image).HasColumnName("doc_image");
            this.Property(t => t.fp_std).HasColumnName("fp_std");

            // Relationships
            this.HasOptional(t => t.afm_tclevel)
                .WithMany(t => t.fpstds)
                .HasForeignKey(d => d.tc_level);

        }
    }
}
