using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class emstdMap : EntityTypeConfiguration<emstd>
    {
        public emstdMap()
        {
            // Primary Key
            this.HasKey(t => t.em_std);

            // Properties
            this.Property(t => t.grade)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.hpattern)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.hpattern_acad)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.status)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.tc_contained_tbls)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.em_std)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("emstd", "afm");
            this.Property(t => t.grade).HasColumnName("grade");
            this.Property(t => t.hpattern).HasColumnName("hpattern");
            this.Property(t => t.hpattern_acad).HasColumnName("hpattern_acad");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.std_area).HasColumnName("std_area");
            this.Property(t => t.tc_contained_tbls).HasColumnName("tc_contained_tbls");
            this.Property(t => t.count_em).HasColumnName("count_em");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.em_std).HasColumnName("em_std");

            // Relationships
            this.HasMany(t => t.rmstds)
                .WithMany(t => t.emstds)
                .Map(m =>
                    {
                        m.ToTable("rmstd_emstd", "afm");
                        m.MapLeftKey("em_std");
                        m.MapRightKey("rm_std");
                    });


        }
    }
}
