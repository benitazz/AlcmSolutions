using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_fldsMap : EntityTypeConfiguration<afm_flds>
    {
        public afm_fldsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.table_name, t.field_name });

            // Properties
            this.Property(t => t.table_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.field_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.comments)
                .IsFixedLength()
                .HasMaxLength(200);

            this.Property(t => t.dep_cols)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.dflt_val)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.edit_group)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.edit_mask)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.enum_list)
                .HasMaxLength(850);

            this.Property(t => t.max_val)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.min_val)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.ml_heading)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.ref_table)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.review_group)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.sl_heading)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.field_grouping)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.attributes)
                .HasMaxLength(2000);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("afm_flds", "afm");
            this.Property(t => t.table_name).HasColumnName("table_name");
            this.Property(t => t.field_name).HasColumnName("field_name");
            this.Property(t => t.afm_type).HasColumnName("afm_type");
            this.Property(t => t.allow_null).HasColumnName("allow_null");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.data_type).HasColumnName("data_type");
            this.Property(t => t.decimals).HasColumnName("decimals");
            this.Property(t => t.dep_cols).HasColumnName("dep_cols");
            this.Property(t => t.dflt_val).HasColumnName("dflt_val");
            this.Property(t => t.edit_group).HasColumnName("edit_group");
            this.Property(t => t.edit_mask).HasColumnName("edit_mask");
            this.Property(t => t.enum_list).HasColumnName("enum_list");
            this.Property(t => t.is_atxt).HasColumnName("is_atxt");
            this.Property(t => t.max_val).HasColumnName("max_val");
            this.Property(t => t.min_val).HasColumnName("min_val");
            this.Property(t => t.ml_heading).HasColumnName("ml_heading");
            this.Property(t => t.afm_module).HasColumnName("afm_module");
            this.Property(t => t.num_format).HasColumnName("num_format");
            this.Property(t => t.primary_key).HasColumnName("primary_key");
            this.Property(t => t.ref_table).HasColumnName("ref_table");
            this.Property(t => t.review_group).HasColumnName("review_group");
            this.Property(t => t.afm_size).HasColumnName("afm_size");
            this.Property(t => t.sl_heading).HasColumnName("sl_heading");
            this.Property(t => t.string_format).HasColumnName("string_format");
            this.Property(t => t.is_tc_traceable).HasColumnName("is_tc_traceable");
            this.Property(t => t.field_grouping).HasColumnName("field_grouping");
            this.Property(t => t.attributes).HasColumnName("attributes");
            this.Property(t => t.validate_data).HasColumnName("validate_data");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");

            // Relationships
            this.HasOptional(t => t.afm_groups)
                .WithMany(t => t.afm_flds)
                .HasForeignKey(d => d.edit_group);
            this.HasOptional(t => t.afm_tbls)
                .WithMany(t => t.afm_flds)
                .HasForeignKey(d => d.ref_table);
            this.HasOptional(t => t.afm_groups1)
                .WithMany(t => t.afm_flds1)
                .HasForeignKey(d => d.review_group);
            this.HasRequired(t => t.afm_tbls1)
                .WithMany(t => t.afm_flds1)
                .HasForeignKey(d => d.table_name);

        }
    }
}
