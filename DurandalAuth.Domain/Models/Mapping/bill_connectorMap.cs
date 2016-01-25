using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class bill_connectorMap : EntityTypeConfiguration<bill_connector>
    {
        public bill_connectorMap()
        {
            // Primary Key
            this.HasKey(t => new { t.vn_id, t.vn_ac_id, t.bill_connector_id });

            // Properties
            this.Property(t => t.bill_file_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.bill_line_connector_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.bill_type_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.connector_version)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.default_file)
                .HasMaxLength(255);

            this.Property(t => t.description)
                .HasMaxLength(5000);

            this.Property(t => t.vn_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.vn_ac_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.bill_connector_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("bill_connector", "afm");
            this.Property(t => t.bill_file_type).HasColumnName("bill_file_type");
            this.Property(t => t.bill_line_connector_id).HasColumnName("bill_line_connector_id");
            this.Property(t => t.bill_type_id).HasColumnName("bill_type_id");
            this.Property(t => t.connector_version).HasColumnName("connector_version");
            this.Property(t => t.date_effective_end).HasColumnName("date_effective_end");
            this.Property(t => t.date_effective_start).HasColumnName("date_effective_start");
            this.Property(t => t.default_file).HasColumnName("default_file");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.auto_approve).HasColumnName("auto_approve");
            this.Property(t => t.vn_id).HasColumnName("vn_id");
            this.Property(t => t.vn_ac_id).HasColumnName("vn_ac_id");
            this.Property(t => t.bill_connector_id).HasColumnName("bill_connector_id");

            // Relationships
            this.HasRequired(t => t.afm_connector)
                .WithMany(t => t.bill_connector)
                .HasForeignKey(d => d.bill_connector_id);
            this.HasOptional(t => t.afm_connector1)
                .WithMany(t => t.bill_connector1)
                .HasForeignKey(d => d.bill_line_connector_id);
            this.HasRequired(t => t.bill_type)
                .WithMany(t => t.bill_connector)
                .HasForeignKey(d => d.bill_type_id);
            this.HasRequired(t => t.vn_ac)
                .WithMany(t => t.bill_connector)
                .HasForeignKey(d => new { d.vn_id, d.vn_ac_id });

        }
    }
}
