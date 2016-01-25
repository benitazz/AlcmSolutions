using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class questionnaire_mapMap : EntityTypeConfiguration<questionnaire_map>
    {
        public questionnaire_mapMap()
        {
            // Primary Key
            this.HasKey(t => new { t.questionnaire_id, t.eq_std, t.project_type });

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(512);

            this.Property(t => t.questionnaire_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.eq_std)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.project_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("questionnaire_map", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.questionnaire_id).HasColumnName("questionnaire_id");
            this.Property(t => t.eq_std).HasColumnName("eq_std");
            this.Property(t => t.project_type).HasColumnName("project_type");

            // Relationships
            this.HasRequired(t => t.eqstd)
                .WithMany(t => t.questionnaire_map)
                .HasForeignKey(d => d.eq_std);
            this.HasRequired(t => t.projecttype)
                .WithMany(t => t.questionnaire_map)
                .HasForeignKey(d => d.project_type);
            this.HasRequired(t => t.questionnaire)
                .WithMany(t => t.questionnaire_map)
                .HasForeignKey(d => d.questionnaire_id);

        }
    }
}
