using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class rmstd_fnMap : EntityTypeConfiguration<rmstd_fn>
    {
        public rmstd_fnMap()
        {
            // Primary Key
            this.HasKey(t => new { t.rm_std, t.fn_std });

            // Properties
            this.Property(t => t.rm_std)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.fn_std)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("rmstd_fn", "afm");
            this.Property(t => t.fnstd_count).HasColumnName("fnstd_count");
            this.Property(t => t.rm_std).HasColumnName("rm_std");
            this.Property(t => t.fn_std).HasColumnName("fn_std");

            // Relationships
            this.HasRequired(t => t.fnstd)
                .WithMany(t => t.rmstd_fn)
                .HasForeignKey(d => d.fn_std);
            this.HasRequired(t => t.rmstd)
                .WithMany(t => t.rmstd_fn)
                .HasForeignKey(d => d.rm_std);

        }
    }
}
