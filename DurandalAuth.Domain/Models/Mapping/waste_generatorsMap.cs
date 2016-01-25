using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class waste_generatorsMap : EntityTypeConfiguration<waste_generators>
    {
        public waste_generatorsMap()
        {
            // Primary Key
            this.HasKey(t => t.generator_id);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.contact_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.generator_name)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.pr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.site_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.generator_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("waste_generators", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.contact_id).HasColumnName("contact_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.generator_name).HasColumnName("generator_name");
            this.Property(t => t.pr_id).HasColumnName("pr_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.generator_id).HasColumnName("generator_id");

            // Relationships
            this.HasOptional(t => t.bl)
                .WithMany(t => t.waste_generators)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.contact)
                .WithMany(t => t.WasteGenerators)
                .HasForeignKey(d => d.contact_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.WasteGenerators)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.property)
                .WithMany(t => t.waste_generators)
                .HasForeignKey(d => d.pr_id);
            this.HasOptional(t => t.rm)
                .WithMany(t => t.waste_generators)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });
            this.HasRequired(t => t.site)
                .WithMany(t => t.waste_generators)
                .HasForeignKey(d => d.site_id);

        }
    }
}
