using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class alrmpctcMap : EntityTypeConfiguration<alrmpctc>
    {
        public alrmpctcMap()
        {
            // Primary Key
            this.HasKey(t => new { t.pct_id, t.stcomocup, t.stcomnocup });

            // Properties
            this.Property(t => t.pct_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.stcomocup)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.stcomnocup)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("alrmpctc", "afm");
            this.Property(t => t.pct_id).HasColumnName("pct_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.flcomocup).HasColumnName("flcomocup");
            this.Property(t => t.blcomocup).HasColumnName("blcomocup");
            this.Property(t => t.stcomocup).HasColumnName("stcomocup");
            this.Property(t => t.flcomnocup).HasColumnName("flcomnocup");
            this.Property(t => t.blcomnocup).HasColumnName("blcomnocup");
            this.Property(t => t.stcomnocup).HasColumnName("stcomnocup");
        }
    }
}
