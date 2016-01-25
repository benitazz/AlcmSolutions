using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class gb_cert_docsMap : EntityTypeConfiguration<gb_cert_docs>
    {
        public gb_cert_docsMap()
        {
            // Primary Key
            this.HasKey(t => t.cert_doc_id);

            // Properties
            this.Property(t => t.cert_std)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.description)
                .HasMaxLength(200);

            this.Property(t => t.doc)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.project_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.submitted_by)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.title)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.author)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("gb_cert_docs", "afm");
            this.Property(t => t.cert_std).HasColumnName("cert_std");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.doc).HasColumnName("doc");
            this.Property(t => t.doc_date).HasColumnName("doc_date");
            this.Property(t => t.project_name).HasColumnName("project_name");
            this.Property(t => t.submitted_by).HasColumnName("submitted_by");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.author).HasColumnName("author");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.cert_doc_id).HasColumnName("cert_doc_id");

            // Relationships
            this.HasRequired(t => t.bl)
                .WithMany(t => t.gb_cert_docs)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.em)
                .WithMany(t => t.GbCertDocs)
                .HasForeignKey(d => d.submitted_by);
            this.HasRequired(t => t.gb_cert_std)
                .WithMany(t => t.gb_cert_docs)
                .HasForeignKey(d => d.cert_std);
            this.HasRequired(t => t.gb_cert_proj)
                .WithMany(t => t.gb_cert_docs)
                .HasForeignKey(d => new { d.bl_id, d.cert_std, d.project_name });

        }
    }
}
