using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class sbperiodMap : EntityTypeConfiguration<sbperiod>
    {
        public sbperiodMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sb_name, t.p00_title });

            // Properties
            this.Property(t => t.p01_title)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.p02_title)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.p03_title)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.p04_title)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.p05_title)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.p06_title)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.p07_title)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.p08_title)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.p09_title)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.p10_title)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.p11_title)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.p12_title)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.sb_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.p00_title)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("sbperiods", "afm");
            this.Property(t => t.p01_title).HasColumnName("p01_title");
            this.Property(t => t.p02_title).HasColumnName("p02_title");
            this.Property(t => t.p03_title).HasColumnName("p03_title");
            this.Property(t => t.p04_title).HasColumnName("p04_title");
            this.Property(t => t.p05_title).HasColumnName("p05_title");
            this.Property(t => t.p06_title).HasColumnName("p06_title");
            this.Property(t => t.p07_title).HasColumnName("p07_title");
            this.Property(t => t.p08_title).HasColumnName("p08_title");
            this.Property(t => t.p09_title).HasColumnName("p09_title");
            this.Property(t => t.p10_title).HasColumnName("p10_title");
            this.Property(t => t.p11_title).HasColumnName("p11_title");
            this.Property(t => t.p12_title).HasColumnName("p12_title");
            this.Property(t => t.sb_name).HasColumnName("sb_name");
            this.Property(t => t.p00_title).HasColumnName("p00_title");

            // Relationships
            this.HasRequired(t => t.sb)
                .WithMany(t => t.sbperiods)
                .HasForeignKey(d => d.sb_name);

        }
    }
}
