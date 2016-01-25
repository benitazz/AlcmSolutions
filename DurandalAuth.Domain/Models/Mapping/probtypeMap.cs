using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class probtypeMap : EntityTypeConfiguration<probtype>
    {
        public probtypeMap()
        {
            // Primary Key
            this.HasKey(t => t.prob_type);

            // Properties
            this.Property(t => t.cas_num)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.comments)
                .HasMaxLength(2000);

            this.Property(t => t.description)
                .HasMaxLength(100);

            this.Property(t => t.hierarchy_ids)
                .HasMaxLength(500);

            this.Property(t => t.prob_class)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.prob_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("probtype", "afm");
            this.Property(t => t.cas_num).HasColumnName("cas_num");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.hierarchy_ids).HasColumnName("hierarchy_ids");
            this.Property(t => t.prob_class).HasColumnName("prob_class");
            this.Property(t => t.prob_type).HasColumnName("prob_type");
        }
    }
}
