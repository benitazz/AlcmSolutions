using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class rmpctcMap : EntityTypeConfiguration<rmpctc>
    {
        public rmpctcMap()
        {
            // Primary Key
            this.HasKey(t => new { t.pct_id, t.fl_id, t.bl_id, t.stcomrm, t.stcomsrv });

            // Properties
            this.Property(t => t.pct_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

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

            this.Property(t => t.stcomrm)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.stcomsrv)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("rmpctc", "afm");
            this.Property(t => t.pct_id).HasColumnName("pct_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.flcomrm).HasColumnName("flcomrm");
            this.Property(t => t.blcomrm).HasColumnName("blcomrm");
            this.Property(t => t.stcomrm).HasColumnName("stcomrm");
            this.Property(t => t.flcomsrv).HasColumnName("flcomsrv");
            this.Property(t => t.blcomsrv).HasColumnName("blcomsrv");
            this.Property(t => t.stcomsrv).HasColumnName("stcomsrv");
        }
    }
}
