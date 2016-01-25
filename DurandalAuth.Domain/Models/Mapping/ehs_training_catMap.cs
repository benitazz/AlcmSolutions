using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ehs_training_catMap : EntityTypeConfiguration<ehs_training_cat>
    {
        public ehs_training_catMap()
        {
            // Primary Key
            this.HasKey(t => t.training_category_id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(256);

            this.Property(t => t.training_category_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("ehs_training_cat", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.training_category_id).HasColumnName("training_category_id");
        }
    }
}
