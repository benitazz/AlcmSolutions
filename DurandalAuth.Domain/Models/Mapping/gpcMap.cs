using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class gpcMap : EntityTypeConfiguration<gpc>
    {
        public gpcMap()
        {
            // Primary Key
            this.HasKey(t => new { t.gp_id, t.fl_id, t.bl_id, t.stcomgp, t.stcomsrv });

            // Properties
            this.Property(t => t.gp_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.fl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.stcomgp)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.stcomsrv)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("gpc", "afm");
            this.Property(t => t.gp_id).HasColumnName("gp_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.flcomgp).HasColumnName("flcomgp");
            this.Property(t => t.blcomgp).HasColumnName("blcomgp");
            this.Property(t => t.stcomgp).HasColumnName("stcomgp");
            this.Property(t => t.flcomsrv).HasColumnName("flcomsrv");
            this.Property(t => t.blcomsrv).HasColumnName("blcomsrv");
            this.Property(t => t.stcomsrv).HasColumnName("stcomsrv");
        }
    }
}
