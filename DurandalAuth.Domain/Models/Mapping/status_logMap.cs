using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class status_logMap : EntityTypeConfiguration<status_log>
    {
        public status_logMap()
        {
            // Primary Key
            this.HasKey(t => new { t.table_name, t.field_name, t.record_id, t.date_changed, t.time_changed });

            // Properties
            this.Property(t => t.status_new)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.status_old)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.em_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.table_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.field_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.record_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(80);

            // Table & Column Mappings
            this.ToTable("status_log", "afm");
            this.Property(t => t.status_new).HasColumnName("status_new");
            this.Property(t => t.status_old).HasColumnName("status_old");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.table_name).HasColumnName("table_name");
            this.Property(t => t.field_name).HasColumnName("field_name");
            this.Property(t => t.record_id).HasColumnName("record_id");
            this.Property(t => t.date_changed).HasColumnName("date_changed");
            this.Property(t => t.time_changed).HasColumnName("time_changed");

            // Relationships
            this.HasRequired(t => t.afm_flds)
                .WithMany(t => t.status_log)
                .HasForeignKey(d => new { d.table_name, d.field_name });
            this.HasRequired(t => t.afm_tbls)
                .WithMany(t => t.status_log)
                .HasForeignKey(d => d.table_name);
            this.HasRequired(t => t.em)
                .WithMany(t => t.status_log)
                .HasForeignKey(d => d.em_id);

        }
    }
}
