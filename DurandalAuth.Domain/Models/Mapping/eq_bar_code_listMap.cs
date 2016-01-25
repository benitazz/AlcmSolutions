using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class eq_bar_code_listMap : EntityTypeConfiguration<eq_bar_code_list>
    {
        public eq_bar_code_listMap()
        {
            // Primary Key
            this.HasKey(t => t.eq_id);

            // Properties
            this.Property(t => t.eq_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("eq_bar_code_list", "afm");
            this.Property(t => t.eq_id).HasColumnName("eq_id");

            // Relationships
            this.HasRequired(t => t.eq)
                .WithOptional(t => t.eq_bar_code_list);

        }
    }
}
