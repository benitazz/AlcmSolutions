using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_docversMap : EntityTypeConfiguration<afm_docvers>
    {
        public afm_docversMap()
        {
            // Primary Key
            this.HasKey(t => new { t.table_name, t.field_name, t.pkey_value, t.version });

            // Properties
            this.Property(t => t.author)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.comments)
                .HasMaxLength(2000);

            this.Property(t => t.doc_file)
                .IsFixedLength()
                .HasMaxLength(160);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.table_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.field_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.pkey_value)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.version)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("afm_docvers", "afm");
            this.Property(t => t.author).HasColumnName("author");
            this.Property(t => t.checkin_date).HasColumnName("checkin_date");
            this.Property(t => t.checkin_time).HasColumnName("checkin_time");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.doc_file).HasColumnName("doc_file");
            this.Property(t => t.doc_size).HasColumnName("doc_size");
            this.Property(t => t.file_contents).HasColumnName("file_contents");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.table_name).HasColumnName("table_name");
            this.Property(t => t.field_name).HasColumnName("field_name");
            this.Property(t => t.pkey_value).HasColumnName("pkey_value");
            this.Property(t => t.version).HasColumnName("version");

            // Relationships
            this.HasRequired(t => t.afm_docs)
                .WithMany(t => t.afm_docvers)
                .HasForeignKey(d => new { d.table_name, d.field_name, d.pkey_value });
            this.HasOptional(t => t.afm_users)
                .WithMany(t => t.afm_docvers)
                .HasForeignKey(d => d.author);
            this.HasRequired(t => t.afm_flds)
                .WithMany(t => t.afm_docvers)
                .HasForeignKey(d => new { d.table_name, d.field_name });
            this.HasRequired(t => t.afm_tbls)
                .WithMany(t => t.afm_docvers)
                .HasForeignKey(d => d.table_name);

        }
    }
}
