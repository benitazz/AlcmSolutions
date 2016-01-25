using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class docfolderMap : EntityTypeConfiguration<docfolder>
    {
        public docfolderMap()
        {
            // Primary Key
            this.HasKey(t => t.doc_folder);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.hierarchy_ids)
                .HasMaxLength(500);

            this.Property(t => t.summary)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.doc_folder)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("docfolder", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.hierarchy_ids).HasColumnName("hierarchy_ids");
            this.Property(t => t.summary).HasColumnName("summary");
            this.Property(t => t.doc_folder).HasColumnName("doc_folder");
        }
    }
}
