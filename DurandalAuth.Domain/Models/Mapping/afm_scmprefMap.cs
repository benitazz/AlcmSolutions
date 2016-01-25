using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_scmprefMap : EntityTypeConfiguration<afm_scmpref>
    {
        public afm_scmprefMap()
        {
            // Primary Key
            this.HasKey(t => t.afm_scmpref1);

            // Properties
            this.Property(t => t.afm_scmpref1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.autocommit_tables)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.cable_std_table)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.connectable_table_names)
                .IsFixedLength()
                .HasMaxLength(100);

            this.Property(t => t.inferrable_field_names)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.lease_area_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.lease_proration_method)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.linetype_file)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.space_area_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.space_hier_field_names)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.doc_cluster_internal_use)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.hierarchy_delim)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.preferences)
                .HasMaxLength(4000);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("afm_scmpref", "afm");
            this.Property(t => t.afm_scmpref1).HasColumnName("afm_scmpref");
            this.Property(t => t.afm_db_version_num).HasColumnName("afm_db_version_num");
            this.Property(t => t.afm_exe_release_num).HasColumnName("afm_exe_release_num");
            this.Property(t => t.afm_exe_version_num).HasColumnName("afm_exe_version_num");
            this.Property(t => t.autocommit_all).HasColumnName("autocommit_all");
            this.Property(t => t.autocommit_tables).HasColumnName("autocommit_tables");
            this.Property(t => t.cable_std_table).HasColumnName("cable_std_table");
            this.Property(t => t.connectable_table_names).HasColumnName("connectable_table_names");
            this.Property(t => t.fiscalyear_startday).HasColumnName("fiscalyear_startday");
            this.Property(t => t.fiscalyear_startmonth).HasColumnName("fiscalyear_startmonth");
            this.Property(t => t.inferrable_field_names).HasColumnName("inferrable_field_names");
            this.Property(t => t.lay_series_pfx_len).HasColumnName("lay_series_pfx_len");
            this.Property(t => t.lease_area_type).HasColumnName("lease_area_type");
            this.Property(t => t.lease_proration_method).HasColumnName("lease_proration_method");
            this.Property(t => t.linetype_file).HasColumnName("linetype_file");
            this.Property(t => t.num_space_fcast_per).HasColumnName("num_space_fcast_per");
            this.Property(t => t.space_area_type).HasColumnName("space_area_type");
            this.Property(t => t.space_hier_field_names).HasColumnName("space_hier_field_names");
            this.Property(t => t.sym_lib_base_metric_units).HasColumnName("sym_lib_base_metric_units");
            this.Property(t => t.sym_lib_units).HasColumnName("sym_lib_units");
            this.Property(t => t.afm_cascades_changes).HasColumnName("afm_cascades_changes");
            this.Property(t => t.base_metric_units).HasColumnName("base_metric_units");
            this.Property(t => t.cluster_num_servers).HasColumnName("cluster_num_servers");
            this.Property(t => t.date_lang_01).HasColumnName("date_lang_01");
            this.Property(t => t.date_lang_02).HasColumnName("date_lang_02");
            this.Property(t => t.date_lang_03).HasColumnName("date_lang_03");
            this.Property(t => t.date_lang_ch).HasColumnName("date_lang_ch");
            this.Property(t => t.date_lang_de).HasColumnName("date_lang_de");
            this.Property(t => t.date_lang_en).HasColumnName("date_lang_en");
            this.Property(t => t.date_lang_es).HasColumnName("date_lang_es");
            this.Property(t => t.date_lang_fr).HasColumnName("date_lang_fr");
            this.Property(t => t.date_lang_it).HasColumnName("date_lang_it");
            this.Property(t => t.date_lang_jp).HasColumnName("date_lang_jp");
            this.Property(t => t.date_lang_ko).HasColumnName("date_lang_ko");
            this.Property(t => t.date_lang_nl).HasColumnName("date_lang_nl");
            this.Property(t => t.date_lang_no).HasColumnName("date_lang_no");
            this.Property(t => t.date_lang_zh).HasColumnName("date_lang_zh");
            this.Property(t => t.doc_cluster_internal_use).HasColumnName("doc_cluster_internal_use");
            this.Property(t => t.hierarchy_delim).HasColumnName("hierarchy_delim");
            this.Property(t => t.preferences).HasColumnName("preferences");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.units).HasColumnName("units");
            this.Property(t => t.use_hier_security).HasColumnName("use_hier_security");
        }
    }
}
