using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_docsMap : EntityTypeConfiguration<afm_docs>
    {
        public afm_docsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.table_name, t.field_name, t.pkey_value });

            // Properties
            this.Property(t => t.locked_by)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.description)
                .HasMaxLength(2000);

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

            // Table & Column Mappings
            this.ToTable("afm_docs", "afm");
            this.Property(t => t.lock_date).HasColumnName("lock_date");
            this.Property(t => t.lock_time).HasColumnName("lock_time");
            this.Property(t => t.locked).HasColumnName("locked");
            this.Property(t => t.locked_by).HasColumnName("locked_by");
            this.Property(t => t.deleted).HasColumnName("deleted");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.table_name).HasColumnName("table_name");
            this.Property(t => t.field_name).HasColumnName("field_name");
            this.Property(t => t.pkey_value).HasColumnName("pkey_value");

            // Relationships
            this.HasRequired(t => t.afm_flds)
                .WithMany(t => t.afm_docs)
                .HasForeignKey(d => new { d.table_name, d.field_name });
            this.HasOptional(t => t.afm_users)
                .WithMany(t => t.afm_docs)
                .HasForeignKey(d => d.locked_by);
            this.HasRequired(t => t.afm_tbls)
                .WithMany(t => t.afm_docs)
                .HasForeignKey(d => d.table_name);

        }
    }
}
