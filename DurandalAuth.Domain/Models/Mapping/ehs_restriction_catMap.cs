using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ehs_restriction_catMap : EntityTypeConfiguration<ehs_restriction_cat>
    {
        public ehs_restriction_catMap()
        {
            // Primary Key
            this.HasKey(t => t.restriction_category_id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(256);

            this.Property(t => t.restriction_category_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("ehs_restriction_cat", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.restriction_category_id).HasColumnName("restriction_category_id");
        }
    }
}
