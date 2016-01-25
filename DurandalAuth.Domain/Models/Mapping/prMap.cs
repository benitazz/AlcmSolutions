using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class prMap : EntityTypeConfiguration<pr>
    {
        public prMap()
        {
            // Primary Key
            this.HasKey(t => t.pr_id);

            // Properties
            this.Property(t => t.pr_description)
                .HasMaxLength(2000);

            this.Property(t => t.pr_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("pr", "afm");
            this.Property(t => t.pr_description).HasColumnName("pr_description");
            this.Property(t => t.pr_id).HasColumnName("pr_id");
        }
    }
}
