using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_dwgversMap : EntityTypeConfiguration<afm_dwgvers>
    {
        public afm_dwgversMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.comments)
                .HasMaxLength(1000);

            this.Property(t => t.dwg_name)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.performed_by)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.action)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("afm_dwgvers", "afm");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.date_occurred).HasColumnName("date_occurred");
            this.Property(t => t.dwg_name).HasColumnName("dwg_name");
            this.Property(t => t.performed_by).HasColumnName("performed_by");
            this.Property(t => t.time_occurred).HasColumnName("time_occurred");
            this.Property(t => t.action).HasColumnName("action");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasRequired(t => t.afm_dwgs)
                .WithMany(t => t.afm_dwgvers)
                .HasForeignKey(d => d.dwg_name);

        }
    }
}
