using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class regcomplevelMap : EntityTypeConfiguration<regcomplevel>
    {
        public regcomplevelMap()
        {
            // Primary Key
            this.HasKey(t => t.comp_level);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.summary)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.comp_level)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("regcomplevel", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.level_number).HasColumnName("level_number");
            this.Property(t => t.summary).HasColumnName("summary");
            this.Property(t => t.comp_level).HasColumnName("comp_level");
        }
    }
}
