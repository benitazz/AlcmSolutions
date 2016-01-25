using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class programMap : EntityTypeConfiguration<program>
    {
        public programMap()
        {
            // Primary Key
            this.HasKey(t => t.program_id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.entered_by)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.objectives)
                .HasMaxLength(1000);

            this.Property(t => t.program_num)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.program_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.scope)
                .HasMaxLength(1000);

            this.Property(t => t.site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.summary)
                .HasMaxLength(500);

            this.Property(t => t.program_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("program", "afm");
            this.Property(t => t.date_init).HasColumnName("date_init");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.entered_by).HasColumnName("entered_by");
            this.Property(t => t.objectives).HasColumnName("objectives");
            this.Property(t => t.program_num).HasColumnName("program_num");
            this.Property(t => t.program_type).HasColumnName("program_type");
            this.Property(t => t.scope).HasColumnName("scope");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.summary).HasColumnName("summary");
            this.Property(t => t.program_id).HasColumnName("program_id");

            // Relationships
            this.HasRequired(t => t.em)
                .WithMany(t => t.programs)
                .HasForeignKey(d => d.entered_by);
            this.HasOptional(t => t.programtype)
                .WithMany(t => t.programs)
                .HasForeignKey(d => d.program_type);
            this.HasOptional(t => t.site)
                .WithMany(t => t.programs)
                .HasForeignKey(d => d.site_id);

        }
    }
}
