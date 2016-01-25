using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ehs_ppe_typesMap : EntityTypeConfiguration<ehs_ppe_types>
    {
        public ehs_ppe_typesMap()
        {
            // Primary Key
            this.HasKey(t => t.ppe_type_id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(500);

            this.Property(t => t.eq_std)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.recurring_rule)
                .HasMaxLength(5000);

            this.Property(t => t.ppe_type_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("ehs_ppe_types", "afm");
            this.Property(t => t.date_recurrence_end).HasColumnName("date_recurrence_end");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.eq_std).HasColumnName("eq_std");
            this.Property(t => t.needs_renewal).HasColumnName("needs_renewal");
            this.Property(t => t.recurring_rule).HasColumnName("recurring_rule");
            this.Property(t => t.ppe_type_id).HasColumnName("ppe_type_id");

            // Relationships
            this.HasMany(t => t.work_categories)
                .WithMany(t => t.ehs_ppe_types)
                .Map(m =>
                    {
                        m.ToTable("ehs_work_cat_ppe_types", "afm");
                        m.MapLeftKey("ppe_type_id");
                        m.MapRightKey("work_category_id");
                    });

            this.HasOptional(t => t.eqstd)
                .WithMany(t => t.ehs_ppe_types)
                .HasForeignKey(d => d.eq_std);

        }
    }
}
