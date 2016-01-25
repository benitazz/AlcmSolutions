using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class acMap : EntityTypeConfiguration<ac>
    {
        public acMap()
        {
            // Primary Key
            this.HasKey(t => t.ac_id);

            // Properties
            this.Property(t => t.comments)
                .HasMaxLength(5000);

            this.Property(t => t.company)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.description)
                .HasMaxLength(250);

            this.Property(t => t.hierarchy_ids)
                .HasMaxLength(500);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.ac_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("ac", "afm");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.company).HasColumnName("company");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.hierarchy_ids).HasColumnName("hierarchy_ids");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.ac_id).HasColumnName("ac_id");

            // Relationships
            this.HasOptional(t => t.company1)
                .WithMany(t => t.Acs)
                .HasForeignKey(d => d.company);

        }
    }
}
