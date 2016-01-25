using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class bar_code_listMap : EntityTypeConfiguration<bar_code_list>
    {
        public bar_code_listMap()
        {
            // Primary Key
            this.HasKey(t => t.ta_id);

            // Properties
            this.Property(t => t.ta_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("bar_code_list", "afm");
            this.Property(t => t.ta_id).HasColumnName("ta_id");

            // Relationships
            this.HasRequired(t => t.ta)
                .WithOptional(t => t.bar_code_list);

        }
    }
}
