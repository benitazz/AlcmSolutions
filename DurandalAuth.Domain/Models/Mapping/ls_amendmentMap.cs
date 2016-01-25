using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ls_amendmentMap : EntityTypeConfiguration<ls_amendment>
    {
        public ls_amendmentMap()
        {
            // Primary Key
            this.HasKey(t => t.ls_amend_id);

            // Properties
            this.Property(t => t.comments)
                .HasMaxLength(2000);

            this.Property(t => t.description)
                .HasMaxLength(512);

            this.Property(t => t.doc)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.exercised_by)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.ls_id)
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("ls_amendment", "afm");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.date_effective).HasColumnName("date_effective");
            this.Property(t => t.date_requested).HasColumnName("date_requested");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.doc).HasColumnName("doc");
            this.Property(t => t.exercised_by).HasColumnName("exercised_by");
            this.Property(t => t.ls_id).HasColumnName("ls_id");
            this.Property(t => t.ls_amend_id).HasColumnName("ls_amend_id");

            // Relationships
            this.HasOptional(t => t.em)
                .WithMany(t => t.ls_amendment)
                .HasForeignKey(d => d.exercised_by);
            this.HasOptional(t => t.l)
                .WithMany(t => t.ls_amendment)
                .HasForeignKey(d => d.ls_id);

        }
    }
}
