using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class waste_regulated_codesMap : EntityTypeConfiguration<waste_regulated_codes>
    {
        public waste_regulated_codesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.regulated_code_type, t.regulated_code });

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(1500);

            this.Property(t => t.regulated_code_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.regulated_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(18);

            // Table & Column Mappings
            this.ToTable("waste_regulated_codes", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.regulated_code_type).HasColumnName("regulated_code_type");
            this.Property(t => t.regulated_code).HasColumnName("regulated_code");

            // Relationships
            this.HasMany(t => t.waste_profiles)
                .WithMany(t => t.waste_regulated_codes)
                .Map(m =>
                    {
                        m.ToTable("waste_profile_reg_codes", "afm");
                        m.MapLeftKey("regulated_code_type", "regulated_code");
                        m.MapRightKey("waste_profile");
                    });


        }
    }
}
