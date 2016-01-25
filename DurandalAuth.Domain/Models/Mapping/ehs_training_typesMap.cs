using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ehs_training_typesMap : EntityTypeConfiguration<ehs_training_types>
    {
        public ehs_training_typesMap()
        {
            // Primary Key
            this.HasKey(t => t.training_type_id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(256);

            this.Property(t => t.training_type_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("ehs_training_types", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.training_type_id).HasColumnName("training_type_id");
        }
    }
}
