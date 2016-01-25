using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class pbstdMap : EntityTypeConfiguration<pbstd>
    {
        public pbstdMap()
        {
            // Primary Key
            this.HasKey(t => t.pb_std);

            // Properties
            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.doc_image)
                .IsFixedLength()
                .HasMaxLength(64);

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

            this.Property(t => t.vn_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.pb_std)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("pbstd", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.doc_image).HasColumnName("doc_image");
            this.Property(t => t.image_file).HasColumnName("image_file");
            this.Property(t => t.symbol).HasColumnName("symbol");
            this.Property(t => t.tc_contained_tbls).HasColumnName("tc_contained_tbls");
            this.Property(t => t.tc_level).HasColumnName("tc_level");
            this.Property(t => t.tc_npositions).HasColumnName("tc_npositions");
            this.Property(t => t.vn_id).HasColumnName("vn_id");
            this.Property(t => t.pb_std).HasColumnName("pb_std");

            // Relationships
            this.HasOptional(t => t.afm_tclevel)
                .WithMany(t => t.pbstds)
                .HasForeignKey(d => d.tc_level);
            this.HasOptional(t => t.vn)
                .WithMany(t => t.pbstds)
                .HasForeignKey(d => d.vn_id);

        }
    }
}
