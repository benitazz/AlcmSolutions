using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class regtypeMap : EntityTypeConfiguration<regtype>
    {
        public regtypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.reg_cat, t.reg_type });

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.summary)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.reg_cat)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.reg_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("regtype", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.summary).HasColumnName("summary");
            this.Property(t => t.reg_cat).HasColumnName("reg_cat");
            this.Property(t => t.reg_type).HasColumnName("reg_type");

            // Relationships
            this.HasRequired(t => t.regcat)
                .WithMany(t => t.regtypes)
                .HasForeignKey(d => d.reg_cat);

        }
    }
}
