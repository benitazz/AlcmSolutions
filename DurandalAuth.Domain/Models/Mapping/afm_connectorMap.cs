using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_connectorMap : EntityTypeConfiguration<afm_connector>
    {
        public afm_connectorMap()
        {
            // Primary Key
            this.HasKey(t => t.connector_id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.destination_tbl)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.footer_connector)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.ftp_folder)
                .HasMaxLength(255);

            this.Property(t => t.ftp_password)
                .HasMaxLength(64);

            this.Property(t => t.ftp_string)
                .HasMaxLength(255);

            this.Property(t => t.ftp_user)
                .HasMaxLength(64);

            this.Property(t => t.header_connector)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.notify_email_address)
                .HasMaxLength(1000);

            this.Property(t => t.post_process)
                .HasMaxLength(1000);

            this.Property(t => t.pre_process)
                .HasMaxLength(1000);

            this.Property(t => t.source_tbl)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.assigned_connector)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.clause)
                .HasMaxLength(1000);

            this.Property(t => t.conn_params)
                .HasMaxLength(2000);

            this.Property(t => t.conn_password)
                .HasMaxLength(64);

            this.Property(t => t.conn_string)
                .HasMaxLength(255);

            this.Property(t => t.conn_user)
                .HasMaxLength(64);

            this.Property(t => t.connector_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("afm_connector", "afm");
            this.Property(t => t.delimeter).HasColumnName("delimeter");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.destination_tbl).HasColumnName("destination_tbl");
            this.Property(t => t.exec_flag).HasColumnName("exec_flag");
            this.Property(t => t.footer_connector).HasColumnName("footer_connector");
            this.Property(t => t.ftp_folder).HasColumnName("ftp_folder");
            this.Property(t => t.ftp_password).HasColumnName("ftp_password");
            this.Property(t => t.ftp_port).HasColumnName("ftp_port");
            this.Property(t => t.ftp_secure).HasColumnName("ftp_secure");
            this.Property(t => t.ftp_string).HasColumnName("ftp_string");
            this.Property(t => t.ftp_user).HasColumnName("ftp_user");
            this.Property(t => t.header_connector).HasColumnName("header_connector");
            this.Property(t => t.import).HasColumnName("import");
            this.Property(t => t.notify_email_address).HasColumnName("notify_email_address");
            this.Property(t => t.notify_user).HasColumnName("notify_user");
            this.Property(t => t.post_process).HasColumnName("post_process");
            this.Property(t => t.pre_process).HasColumnName("pre_process");
            this.Property(t => t.skip_first_row).HasColumnName("skip_first_row");
            this.Property(t => t.source_tbl).HasColumnName("source_tbl");
            this.Property(t => t.text_qualifier).HasColumnName("text_qualifier");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.assigned_connector).HasColumnName("assigned_connector");
            this.Property(t => t.clause).HasColumnName("clause");
            this.Property(t => t.conn_params).HasColumnName("conn_params");
            this.Property(t => t.conn_password).HasColumnName("conn_password");
            this.Property(t => t.conn_string).HasColumnName("conn_string");
            this.Property(t => t.conn_user).HasColumnName("conn_user");
            this.Property(t => t.connector_id).HasColumnName("connector_id");

            // Relationships
            this.HasOptional(t => t.afm_tbls)
                .WithMany(t => t.afm_connector)
                .HasForeignKey(d => d.destination_tbl);

        }
    }
}
