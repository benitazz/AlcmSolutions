using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class regreqcatMap : EntityTypeConfiguration<regreqcat>
    {
        public regreqcatMap()
        {
            // Primary Key
            this.HasKey(t => t.regreq_cat);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.summary)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.regreq_cat)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("regreqcat", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.summary).HasColumnName("summary");
            this.Property(t => t.regreq_cat).HasColumnName("regreq_cat");
        }
    }
}
