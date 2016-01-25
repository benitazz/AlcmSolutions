using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class regprogtypeMap : EntityTypeConfiguration<regprogtype>
    {
        public regprogtypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.regprog_cat, t.regprog_type });

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.summary)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.regprog_cat)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.regprog_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("regprogtype", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.summary).HasColumnName("summary");
            this.Property(t => t.regprog_cat).HasColumnName("regprog_cat");
            this.Property(t => t.regprog_type).HasColumnName("regprog_type");

            // Relationships
            this.HasRequired(t => t.regprogcat)
                .WithMany(t => t.regprogtypes)
                .HasForeignKey(d => d.regprog_cat);

        }
    }
}
