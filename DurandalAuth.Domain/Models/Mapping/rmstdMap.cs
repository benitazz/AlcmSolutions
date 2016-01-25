using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class rmstdMap : EntityTypeConfiguration<rmstd>
    {
        public rmstdMap()
        {
            // Primary Key
            this.HasKey(t => t.rm_std);

            // Properties
            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.doc_block)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.doc_graphic)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.hpattern)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.hpattern_acad)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.image_file)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.image_of_block)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.symbol)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.tc_contained_tbls)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.rm_std)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("rmstd", "afm");
            this.Property(t => t.area).HasColumnName("area");
            this.Property(t => t.area_avg).HasColumnName("area_avg");
            this.Property(t => t.cost_of_em).HasColumnName("cost_of_em");
            this.Property(t => t.cost_of_furn).HasColumnName("cost_of_furn");
            this.Property(t => t.cost_of_move).HasColumnName("cost_of_move");
            this.Property(t => t.cost_of_space).HasColumnName("cost_of_space");
            this.Property(t => t.count_em).HasColumnName("count_em");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.doc_block).HasColumnName("doc_block");
            this.Property(t => t.doc_graphic).HasColumnName("doc_graphic");
            this.Property(t => t.hpattern).HasColumnName("hpattern");
            this.Property(t => t.hpattern_acad).HasColumnName("hpattern_acad");
            this.Property(t => t.image_file).HasColumnName("image_file");
            this.Property(t => t.image_of_block).HasColumnName("image_of_block");
            this.Property(t => t.length).HasColumnName("length");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.std_area).HasColumnName("std_area");
            this.Property(t => t.std_em).HasColumnName("std_em");
            this.Property(t => t.support).HasColumnName("support");
            this.Property(t => t.symbol).HasColumnName("symbol");
            this.Property(t => t.tc_contained_tbls).HasColumnName("tc_contained_tbls");
            this.Property(t => t.tot_count).HasColumnName("tot_count");
            this.Property(t => t.width).HasColumnName("width");
            this.Property(t => t.rm_std).HasColumnName("rm_std");
        }
    }
}
