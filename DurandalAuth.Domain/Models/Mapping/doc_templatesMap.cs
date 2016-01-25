using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class doc_templatesMap : EntityTypeConfiguration<doc_templates>
    {
        public doc_templatesMap()
        {
            // Primary Key
            this.HasKey(t => t.template_id);

            // Properties
            this.Property(t => t.classification)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.description)
                .HasMaxLength(512);

            this.Property(t => t.doc_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.template)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.template_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("doc_templates", "afm");
            this.Property(t => t.classification).HasColumnName("classification");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.doc_type).HasColumnName("doc_type");
            this.Property(t => t.template).HasColumnName("template");
            this.Property(t => t.template_id).HasColumnName("template_id");
        }
    }
}
