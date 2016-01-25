using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class surveymob_syncMap : EntityTypeConfiguration<surveymob_sync>
    {
        public surveymob_syncMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(200);

            this.Property(t => t.em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.mob_locked_by)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.status)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.survey_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.survey_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.transfer_status)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("surveymob_sync", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.mob_is_changed).HasColumnName("mob_is_changed");
            this.Property(t => t.mob_locked_by).HasColumnName("mob_locked_by");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.survey_date).HasColumnName("survey_date");
            this.Property(t => t.survey_id).HasColumnName("survey_id");
            this.Property(t => t.survey_type).HasColumnName("survey_type");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasOptional(t => t.em)
                .WithMany(t => t.surveymob_sync)
                .HasForeignKey(d => d.em_id);

        }
    }
}
