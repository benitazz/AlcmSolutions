using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_wf_logMap : EntityTypeConfiguration<afm_wf_log>
    {
        public afm_wf_logMap()
        {
            // Primary Key
            this.HasKey(t => t.autonumbered_id);

            // Properties
            this.Property(t => t.category)
                .HasMaxLength(255);

            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.event_id)
                .HasMaxLength(255);

            this.Property(t => t.event_type)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.help_context)
                .HasMaxLength(255);

            this.Property(t => t.help_file)
                .HasMaxLength(255);

            this.Property(t => t.rule_id)
                .IsFixedLength()
                .HasMaxLength(255);

            this.Property(t => t.script)
                .HasMaxLength(255);

            this.Property(t => t.scripting_code)
                .HasMaxLength(500);

            this.Property(t => t.source)
                .HasMaxLength(255);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.user_name)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.activitydef_id)
                .IsFixedLength()
                .HasMaxLength(255);

            this.Property(t => t.attributes)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("afm_wf_log", "afm");
            this.Property(t => t.category).HasColumnName("category");
            this.Property(t => t.column_position).HasColumnName("column_position");
            this.Property(t => t.date_of_event).HasColumnName("date_of_event");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.event_id).HasColumnName("event_id");
            this.Property(t => t.event_type).HasColumnName("event_type");
            this.Property(t => t.help_context).HasColumnName("help_context");
            this.Property(t => t.help_file).HasColumnName("help_file");
            this.Property(t => t.line).HasColumnName("line");
            this.Property(t => t.rule_id).HasColumnName("rule_id");
            this.Property(t => t.script).HasColumnName("script");
            this.Property(t => t.scripting_code).HasColumnName("scripting_code");
            this.Property(t => t.source).HasColumnName("source");
            this.Property(t => t.time_of_event).HasColumnName("time_of_event");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.user_name).HasColumnName("user_name");
            this.Property(t => t.activity_id).HasColumnName("activity_id");
            this.Property(t => t.activitydef_id).HasColumnName("activitydef_id");
            this.Property(t => t.attributes).HasColumnName("attributes");
            this.Property(t => t.autonumbered_id).HasColumnName("autonumbered_id");
        }
    }
}
