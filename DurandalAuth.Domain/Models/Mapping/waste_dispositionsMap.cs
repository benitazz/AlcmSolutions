using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class waste_dispositionsMap : EntityTypeConfiguration<waste_dispositions>
    {
        public waste_dispositionsMap()
        {
            // Primary Key
            this.HasKey(t => t.waste_disposition);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(1000);

            this.Property(t => t.disposition_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.waste_disposition)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("waste_dispositions", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.disposition_type).HasColumnName("disposition_type");
            this.Property(t => t.waste_disposition).HasColumnName("waste_disposition");
        }
    }
}
