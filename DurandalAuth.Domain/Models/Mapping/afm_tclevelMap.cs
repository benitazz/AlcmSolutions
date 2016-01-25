using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_tclevelMap : EntityTypeConfiguration<afm_tclevel>
    {
        public afm_tclevelMap()
        {
            // Primary Key
            this.HasKey(t => t.tc_level);

            // Properties
            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.eia_level)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.tc_service)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.tc_level)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("afm_tclevel", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.eia_level).HasColumnName("eia_level");
            this.Property(t => t.tc_service).HasColumnName("tc_service");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.tc_level).HasColumnName("tc_level");
        }
    }
}
