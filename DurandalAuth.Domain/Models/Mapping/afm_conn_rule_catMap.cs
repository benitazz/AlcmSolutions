using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_conn_rule_catMap : EntityTypeConfiguration<afm_conn_rule_cat>
    {
        public afm_conn_rule_catMap()
        {
            // Primary Key
            this.HasKey(t => t.rule_id);

            // Properties
            this.Property(t => t.class_name)
                .IsFixedLength()
                .HasMaxLength(256);

            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(2000);

            this.Property(t => t.method_name)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.parameter)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.rule_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("afm_conn_rule_cat", "afm");
            this.Property(t => t.class_name).HasColumnName("class_name");
            this.Property(t => t.data_type).HasColumnName("data_type");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.is_schema_field).HasColumnName("is_schema_field");
            this.Property(t => t.method_name).HasColumnName("method_name");
            this.Property(t => t.parameter).HasColumnName("parameter");
            this.Property(t => t.rule_id).HasColumnName("rule_id");
        }
    }
}
