using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class rmtypeMap : EntityTypeConfiguration<rmtype>
    {
        public rmtypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.rm_cat, t.rm_type });

            // Properties
            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.hpattern)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.hpattern_acad)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.rm_cat)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.rm_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("rmtype", "afm");
            this.Property(t => t.area).HasColumnName("area");
            this.Property(t => t.area_avg).HasColumnName("area_avg");
            this.Property(t => t.count_em).HasColumnName("count_em");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.hpattern).HasColumnName("hpattern");
            this.Property(t => t.hpattern_acad).HasColumnName("hpattern_acad");
            this.Property(t => t.tot_count).HasColumnName("tot_count");
            this.Property(t => t.rm_cat).HasColumnName("rm_cat");
            this.Property(t => t.rm_type).HasColumnName("rm_type");

            // Relationships
            this.HasRequired(t => t.rmcat)
                .WithMany(t => t.rmtypes)
                .HasForeignKey(d => d.rm_cat);

        }
    }
}
