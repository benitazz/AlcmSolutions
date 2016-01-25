using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class sbMap : EntityTypeConfiguration<sb>
    {
        public sbMap()
        {
            // Primary Key
            this.HasKey(t => t.sb_name);

            // Properties
            this.Property(t => t.sb_as)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.sb_desc)
                .HasMaxLength(2000);

            this.Property(t => t.sb_from)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.sb_level)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.sb_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("sb", "afm");
            this.Property(t => t.alloc_period).HasColumnName("alloc_period");
            this.Property(t => t.alloc_score).HasColumnName("alloc_score");
            this.Property(t => t.alloc_score_ext).HasColumnName("alloc_score_ext");
            this.Property(t => t.sb_as).HasColumnName("sb_as");
            this.Property(t => t.sb_desc).HasColumnName("sb_desc");
            this.Property(t => t.sb_from).HasColumnName("sb_from");
            this.Property(t => t.sb_level).HasColumnName("sb_level");
            this.Property(t => t.sb_name).HasColumnName("sb_name");
        }
    }
}
