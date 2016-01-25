using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_conn_logMap : EntityTypeConfiguration<afm_conn_log>
    {
        public afm_conn_logMap()
        {
            // Primary Key
            this.HasKey(t => t.conn_log_id);

            // Properties
            this.Property(t => t.connector_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.msg)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("afm_conn_log", "afm");
            this.Property(t => t.connector_id).HasColumnName("connector_id");
            this.Property(t => t.date_log).HasColumnName("date_log");
            this.Property(t => t.msg).HasColumnName("msg");
            this.Property(t => t.time_log).HasColumnName("time_log");
            this.Property(t => t.conn_log_id).HasColumnName("conn_log_id");

            // Relationships
            this.HasRequired(t => t.afm_connector)
                .WithMany(t => t.afm_conn_log)
                .HasForeignKey(d => d.connector_id);

        }
    }
}
