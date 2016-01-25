using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class csiMap : EntityTypeConfiguration<csi>
    {
        public csiMap()
        {
            // Primary Key
            this.HasKey(t => t.csi_id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(96);

            this.Property(t => t.hierarchy_ids)
                .HasMaxLength(500);

            this.Property(t => t.csi_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("csi", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.hierarchy_ids).HasColumnName("hierarchy_ids");
            this.Property(t => t.csi_id).HasColumnName("csi_id");
        }
    }
}
