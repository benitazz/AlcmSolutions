using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_data_event_logMap : EntityTypeConfiguration<afm_data_event_log>
    {
        public afm_data_event_logMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.change_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.event_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(22);

            this.Property(t => t.field_list)
                .HasMaxLength(900);

            this.Property(t => t.sql_statement)
                .HasMaxLength(3000);

            this.Property(t => t.table_name)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.user_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.values_new)
                .HasMaxLength(2000);

            this.Property(t => t.values_old)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("afm_data_event_log", "afm");
            this.Property(t => t.change_type).HasColumnName("change_type");
            this.Property(t => t.date_occurred).HasColumnName("date_occurred");
            this.Property(t => t.event_type).HasColumnName("event_type");
            this.Property(t => t.field_list).HasColumnName("field_list");
            this.Property(t => t.sql_statement).HasColumnName("sql_statement");
            this.Property(t => t.table_name).HasColumnName("table_name");
            this.Property(t => t.time_occurred).HasColumnName("time_occurred");
            this.Property(t => t.user_name).HasColumnName("user_name");
            this.Property(t => t.values_new).HasColumnName("values_new");
            this.Property(t => t.values_old).HasColumnName("values_old");
            this.Property(t => t.auto_number).HasColumnName("auto_number");
        }
    }
}
