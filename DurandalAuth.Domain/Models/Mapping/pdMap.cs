using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class pdMap : EntityTypeConfiguration<pd>
    {
        public pdMap()
        {
            // Primary Key
            this.HasKey(t => t.pd_id);

            // Properties
            this.Property(t => t.pd_description)
                .HasMaxLength(2000);

            this.Property(t => t.pd_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("pd", "afm");
            this.Property(t => t.pd_description).HasColumnName("pd_description");
            this.Property(t => t.pd_id).HasColumnName("pd_id");
        }
    }
}
