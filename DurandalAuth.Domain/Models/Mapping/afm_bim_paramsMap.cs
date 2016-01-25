using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_bim_paramsMap : EntityTypeConfiguration<afm_bim_params>
    {
        public afm_bim_paramsMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.field_name)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.guid)
                .HasMaxLength(64);

            this.Property(t => t.language)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.parameter_name)
                .HasMaxLength(64);

            this.Property(t => t.parameter_name_01)
                .HasMaxLength(96);

            this.Property(t => t.parameter_name_02)
                .HasMaxLength(96);

            this.Property(t => t.parameter_name_03)
                .HasMaxLength(96);

            this.Property(t => t.parameter_name_ch)
                .HasMaxLength(96);

            this.Property(t => t.parameter_name_de)
                .HasMaxLength(96);

            this.Property(t => t.parameter_name_es)
                .HasMaxLength(96);

            this.Property(t => t.parameter_name_fr)
                .HasMaxLength(96);

            this.Property(t => t.parameter_name_it)
                .HasMaxLength(96);

            this.Property(t => t.parameter_name_jp)
                .HasMaxLength(96);

            this.Property(t => t.parameter_name_ko)
                .HasMaxLength(96);

            this.Property(t => t.parameter_name_nl)
                .HasMaxLength(96);

            this.Property(t => t.parameter_name_no)
                .HasMaxLength(96);

            this.Property(t => t.parameter_name_zh)
                .HasMaxLength(96);

            this.Property(t => t.table_name)
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("afm_bim_params", "afm");
            this.Property(t => t.field_name).HasColumnName("field_name");
            this.Property(t => t.guid).HasColumnName("guid");
            this.Property(t => t.is_active).HasColumnName("is_active");
            this.Property(t => t.language).HasColumnName("language");
            this.Property(t => t.parameter_id).HasColumnName("parameter_id");
            this.Property(t => t.parameter_name).HasColumnName("parameter_name");
            this.Property(t => t.parameter_name_01).HasColumnName("parameter_name_01");
            this.Property(t => t.parameter_name_02).HasColumnName("parameter_name_02");
            this.Property(t => t.parameter_name_03).HasColumnName("parameter_name_03");
            this.Property(t => t.parameter_name_ch).HasColumnName("parameter_name_ch");
            this.Property(t => t.parameter_name_de).HasColumnName("parameter_name_de");
            this.Property(t => t.parameter_name_es).HasColumnName("parameter_name_es");
            this.Property(t => t.parameter_name_fr).HasColumnName("parameter_name_fr");
            this.Property(t => t.parameter_name_it).HasColumnName("parameter_name_it");
            this.Property(t => t.parameter_name_jp).HasColumnName("parameter_name_jp");
            this.Property(t => t.parameter_name_ko).HasColumnName("parameter_name_ko");
            this.Property(t => t.parameter_name_nl).HasColumnName("parameter_name_nl");
            this.Property(t => t.parameter_name_no).HasColumnName("parameter_name_no");
            this.Property(t => t.parameter_name_zh).HasColumnName("parameter_name_zh");
            this.Property(t => t.parameter_type).HasColumnName("parameter_type");
            this.Property(t => t.record_source).HasColumnName("record_source");
            this.Property(t => t.required_by_ai).HasColumnName("required_by_ai");
            this.Property(t => t.table_name).HasColumnName("table_name");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasOptional(t => t.afm_flds)
                .WithMany(t => t.afm_bim_params)
                .HasForeignKey(d => new { d.table_name, d.field_name });
            this.HasOptional(t => t.afm_tbls)
                .WithMany(t => t.afm_bim_params)
                .HasForeignKey(d => d.table_name);

        }
    }
}
