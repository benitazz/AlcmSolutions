using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class fnstdMap : EntityTypeConfiguration<fnstd>
    {
        public fnstdMap()
        {
            // Primary Key
            this.HasKey(t => t.fn_std);

            // Properties
            this.Property(t => t.catalog_id)
                .HasMaxLength(50);

            this.Property(t => t.category)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.color)
                .HasMaxLength(50);

            this.Property(t => t.description)
                .HasMaxLength(200);

            this.Property(t => t.doc_block)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.doc_graphic)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.finish)
                .HasMaxLength(50);

            this.Property(t => t.image_file)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.image_of_block)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.mfr_id)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.policy_id)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.product_line)
                .HasMaxLength(50);

            this.Property(t => t.symbol)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.ta_lease_id)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.warranty_id)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.fn_std)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("fnstd", "afm");
            this.Property(t => t.catalog_id).HasColumnName("catalog_id");
            this.Property(t => t.category).HasColumnName("category");
            this.Property(t => t.color).HasColumnName("color");
            this.Property(t => t.cost_moving).HasColumnName("cost_moving");
            this.Property(t => t.depth).HasColumnName("depth");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.doc_block).HasColumnName("doc_block");
            this.Property(t => t.doc_graphic).HasColumnName("doc_graphic");
            this.Property(t => t.finish).HasColumnName("finish");
            this.Property(t => t.height).HasColumnName("height");
            this.Property(t => t.image_file).HasColumnName("image_file");
            this.Property(t => t.image_of_block).HasColumnName("image_of_block");
            this.Property(t => t.is_ergo_comp).HasColumnName("is_ergo_comp");
            this.Property(t => t.mfr_id).HasColumnName("mfr_id");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.policy_id).HasColumnName("policy_id");
            this.Property(t => t.price).HasColumnName("price");
            this.Property(t => t.product_line).HasColumnName("product_line");
            this.Property(t => t.symbol).HasColumnName("symbol");
            this.Property(t => t.ta_lease_id).HasColumnName("ta_lease_id");
            this.Property(t => t.warranty_id).HasColumnName("warranty_id");
            this.Property(t => t.weight).HasColumnName("weight");
            this.Property(t => t.width).HasColumnName("width");
            this.Property(t => t.fn_std).HasColumnName("fn_std");

            // Relationships
            this.HasOptional(t => t.policy)
                .WithMany(t => t.fnstds)
                .HasForeignKey(d => d.policy_id);
            this.HasOptional(t => t.ta_lease)
                .WithMany(t => t.fnstds)
                .HasForeignKey(d => d.ta_lease_id);
            this.HasOptional(t => t.warranty)
                .WithMany(t => t.fnstds)
                .HasForeignKey(d => d.warranty_id);

        }
    }
}
