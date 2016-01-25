using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_conn_fldsMap : EntityTypeConfiguration<afm_conn_flds>
    {
        public afm_conn_fldsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.connector_id, t.position });

            // Properties
            this.Property(t => t.destination_fld)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.field_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.parameter)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.result)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.rule_id)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.validate_tbl)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.connector_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.position)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("afm_conn_flds", "afm");
            this.Property(t => t.destination_fld).HasColumnName("destination_fld");
            this.Property(t => t.field_id).HasColumnName("field_id");
            this.Property(t => t.ignore_nulls).HasColumnName("ignore_nulls");
            this.Property(t => t.is_schema_field).HasColumnName("is_schema_field");
            this.Property(t => t.parameter).HasColumnName("parameter");
            this.Property(t => t.cache).HasColumnName("cache");
            this.Property(t => t.result).HasColumnName("result");
            this.Property(t => t.rule_id).HasColumnName("rule_id");
            this.Property(t => t.validate_tbl).HasColumnName("validate_tbl");
            this.Property(t => t.connector_id).HasColumnName("connector_id");
            this.Property(t => t.position).HasColumnName("position");

            // Relationships
            this.HasRequired(t => t.afm_connector)
                .WithMany(t => t.afm_conn_flds)
                .HasForeignKey(d => d.connector_id);
            this.HasOptional(t => t.afm_conn_rule_cat)
                .WithMany(t => t.afm_conn_flds)
                .HasForeignKey(d => d.rule_id);
            this.HasOptional(t => t.afm_tbls)
                .WithMany(t => t.afm_conn_flds)
                .HasForeignKey(d => d.validate_tbl);

        }
    }
}
