using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class workflow_substitutesMap : EntityTypeConfiguration<workflow_substitutes>
    {
        public workflow_substitutesMap()
        {
            // Primary Key
            this.HasKey(t => t.autonumber);

            // Properties
            this.Property(t => t.cf_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.comments)
                .HasMaxLength(512);

            this.Property(t => t.em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.steptype_or_role)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.substitute_cf_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.substitute_em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            // Table & Column Mappings
            this.ToTable("workflow_substitutes", "afm");
            this.Property(t => t.cf_id).HasColumnName("cf_id");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.end_date_unavailable).HasColumnName("end_date_unavailable");
            this.Property(t => t.start_date_unavailable).HasColumnName("start_date_unavailable");
            this.Property(t => t.steptype_or_role).HasColumnName("steptype_or_role");
            this.Property(t => t.substitute_cf_id).HasColumnName("substitute_cf_id");
            this.Property(t => t.substitute_em_id).HasColumnName("substitute_em_id");
            this.Property(t => t.autonumber).HasColumnName("autonumber");

            // Relationships
            this.HasOptional(t => t.cf)
                .WithMany(t => t.WorkflowSubstitutes)
                .HasForeignKey(d => d.cf_id);
            this.HasOptional(t => t.cf1)
                .WithMany(t => t.WorkflowSubstitutes1)
                .HasForeignKey(d => d.substitute_cf_id);
            this.HasOptional(t => t.em)
                .WithMany(t => t.workflow_substitutes)
                .HasForeignKey(d => d.em_id);
            this.HasOptional(t => t.em1)
                .WithMany(t => t.workflow_substitutes1)
                .HasForeignKey(d => d.substitute_em_id);

        }
    }
}
