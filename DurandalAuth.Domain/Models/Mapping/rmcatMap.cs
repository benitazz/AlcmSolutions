using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class rmcatMap : EntityTypeConfiguration<rmcat>
    {
        public rmcatMap()
        {
            // Primary Key
            this.HasKey(t => t.rm_cat);

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

            this.Property(t => t.supercat)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.used_in_calcs)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.rm_cat)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("rmcat", "afm");
            this.Property(t => t.area).HasColumnName("area");
            this.Property(t => t.area_avg).HasColumnName("area_avg");
            this.Property(t => t.cost_sqft).HasColumnName("cost_sqft");
            this.Property(t => t.count_em).HasColumnName("count_em");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.hpattern).HasColumnName("hpattern");
            this.Property(t => t.hpattern_acad).HasColumnName("hpattern_acad");
            this.Property(t => t.occupiable).HasColumnName("occupiable");
            this.Property(t => t.supercat).HasColumnName("supercat");
            this.Property(t => t.tot_count).HasColumnName("tot_count");
            this.Property(t => t.used_in_calcs).HasColumnName("used_in_calcs");
            this.Property(t => t.rm_cat).HasColumnName("rm_cat");
        }
    }
}
