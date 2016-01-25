using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_bim_familiesMap : EntityTypeConfiguration<afm_bim_families>
    {
        public afm_bim_familiesMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.category_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.family)
                .HasMaxLength(64);

            this.Property(t => t.language)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.parameter_group)
                .HasMaxLength(128);

            this.Property(t => t.phase_name_contains)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.super_category)
                .HasMaxLength(64);

            this.Property(t => t.table_name)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.type)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.view_name_contains)
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("afm_bim_families", "afm");
            this.Property(t => t.category_id).HasColumnName("category_id");
            this.Property(t => t.family).HasColumnName("family");
            this.Property(t => t.language).HasColumnName("language");
            this.Property(t => t.parameter_group).HasColumnName("parameter_group");
            this.Property(t => t.phase_name_contains).HasColumnName("phase_name_contains");
            this.Property(t => t.super_category).HasColumnName("super_category");
            this.Property(t => t.table_name).HasColumnName("table_name");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.view_name_contains).HasColumnName("view_name_contains");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasRequired(t => t.afm_bim_categories)
                .WithMany(t => t.afm_bim_families)
                .HasForeignKey(d => d.category_id);
            this.HasOptional(t => t.afm_tbls)
                .WithMany(t => t.afm_bim_families)
                .HasForeignKey(d => d.table_name);

        }
    }
}
