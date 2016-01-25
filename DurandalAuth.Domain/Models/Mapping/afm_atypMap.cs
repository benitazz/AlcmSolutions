using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_atypMap : EntityTypeConfiguration<afm_atyp>
    {
        public afm_atypMap()
        {
            // Primary Key
            this.HasKey(t => t.table_name);

            // Properties
            this.Property(t => t.atxt_style)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.dflt_symbol)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.dflt_view)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.dflt_view_sc)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.pop_layer)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.pop_loc)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.rule_id)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.std_table)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.table_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("afm_atyp", "afm");
            this.Property(t => t.atxt_boxed).HasColumnName("atxt_boxed");
            this.Property(t => t.atxt_gen).HasColumnName("atxt_gen");
            this.Property(t => t.atxt_ht).HasColumnName("atxt_ht");
            this.Property(t => t.atxt_ht_cm).HasColumnName("atxt_ht_cm");
            this.Property(t => t.atxt_ht_in).HasColumnName("atxt_ht_in");
            this.Property(t => t.atxt_just).HasColumnName("atxt_just");
            this.Property(t => t.atxt_style).HasColumnName("atxt_style");
            this.Property(t => t.atxt_xoff_cm).HasColumnName("atxt_xoff_cm");
            this.Property(t => t.atxt_xoff_in).HasColumnName("atxt_xoff_in");
            this.Property(t => t.atxt_yoff_cm).HasColumnName("atxt_yoff_cm");
            this.Property(t => t.atxt_yoff_in).HasColumnName("atxt_yoff_in");
            this.Property(t => t.dflt_symbol).HasColumnName("dflt_symbol");
            this.Property(t => t.dflt_view).HasColumnName("dflt_view");
            this.Property(t => t.dflt_view_sc).HasColumnName("dflt_view_sc");
            this.Property(t => t.entity_type).HasColumnName("entity_type");
            this.Property(t => t.param_units).HasColumnName("param_units");
            this.Property(t => t.pop_layer).HasColumnName("pop_layer");
            this.Property(t => t.pop_loc).HasColumnName("pop_loc");
            this.Property(t => t.record_source).HasColumnName("record_source");
            this.Property(t => t.regen_pop).HasColumnName("regen_pop");
            this.Property(t => t.rule_id).HasColumnName("rule_id");
            this.Property(t => t.scaled_ins).HasColumnName("scaled_ins");
            this.Property(t => t.std_table).HasColumnName("std_table");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.table_name).HasColumnName("table_name");

            // Relationships
            this.HasOptional(t => t.afm_dwgpub)
                .WithMany(t => t.afm_atyp)
                .HasForeignKey(d => d.rule_id);
            this.HasOptional(t => t.afm_tbls)
                .WithMany(t => t.afm_atyp)
                .HasForeignKey(d => d.std_table);
            this.HasRequired(t => t.afm_tbls1)
                .WithOptional(t => t.afm_atyp1);

        }
    }
}
