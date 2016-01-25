using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class regnotifyMap : EntityTypeConfiguration<regnotify>
    {
        public regnotifyMap()
        {
            // Primary Key
            this.HasKey(t => t.regnotify_id);

            // Properties
            this.Property(t => t.reg_program)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.reg_requirement)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.regulation)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.template_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("regnotify", "afm");
            this.Property(t => t.is_active).HasColumnName("is_active");
            this.Property(t => t.reg_program).HasColumnName("reg_program");
            this.Property(t => t.reg_requirement).HasColumnName("reg_requirement");
            this.Property(t => t.regulation).HasColumnName("regulation");
            this.Property(t => t.template_id).HasColumnName("template_id");
            this.Property(t => t.regnotify_id).HasColumnName("regnotify_id");

            // Relationships
            this.HasRequired(t => t.notify_templates)
                .WithMany(t => t.regnotifies)
                .HasForeignKey(d => d.template_id);
            this.HasOptional(t => t.regprogram)
                .WithMany(t => t.regnotifies)
                .HasForeignKey(d => new { d.regulation, d.reg_program });
            this.HasOptional(t => t.regrequirement)
                .WithMany(t => t.regnotifies)
                .HasForeignKey(d => new { d.regulation, d.reg_program, d.reg_requirement });
            this.HasOptional(t => t.regulation1)
                .WithMany(t => t.regnotifies)
                .HasForeignKey(d => d.regulation);

        }
    }
}
