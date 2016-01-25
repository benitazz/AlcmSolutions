using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class docs_assigned_syncMap : EntityTypeConfiguration<docs_assigned_sync>
    {
        public docs_assigned_syncMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(512);

            this.Property(t => t.doc)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.doc_author)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.mob_locked_by)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            // Table & Column Mappings
            this.ToTable("docs_assigned_sync", "afm");
            this.Property(t => t.date_doc).HasColumnName("date_doc");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.doc).HasColumnName("doc");
            this.Property(t => t.doc_author).HasColumnName("doc_author");
            this.Property(t => t.mob_doc_id).HasColumnName("mob_doc_id");
            this.Property(t => t.mob_incident_id).HasColumnName("mob_incident_id");
            this.Property(t => t.mob_is_changed).HasColumnName("mob_is_changed");
            this.Property(t => t.mob_locked_by).HasColumnName("mob_locked_by");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.auto_number).HasColumnName("auto_number");
        }
    }
}
