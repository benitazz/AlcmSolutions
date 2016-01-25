using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class doctypeMap : EntityTypeConfiguration<doctype>
    {
        public doctypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.doc_cat, t.doc_type });

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.summary)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.doc_cat)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.doc_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("doctype", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.summary).HasColumnName("summary");
            this.Property(t => t.doc_cat).HasColumnName("doc_cat");
            this.Property(t => t.doc_type).HasColumnName("doc_type");

            // Relationships
            this.HasRequired(t => t.doccat)
                .WithMany(t => t.doctypes)
                .HasForeignKey(d => d.doc_cat);

        }
    }
}
