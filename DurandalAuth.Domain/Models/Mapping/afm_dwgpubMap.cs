using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_dwgpubMap : EntityTypeConfiguration<afm_dwgpub>
    {
        public afm_dwgpubMap()
        {
            // Primary Key
            this.HasKey(t => t.rule_id);

            // Properties
            this.Property(t => t.color_mapping)
                .HasMaxLength(256);

            this.Property(t => t.comments)
                .HasMaxLength(256);

            this.Property(t => t.dwg_view)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.filter_assigned)
                .HasMaxLength(256);

            this.Property(t => t.filter_owner)
                .HasMaxLength(256);

            this.Property(t => t.hpattern_acad)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.is_active)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.layer_addl)
                .HasMaxLength(512);

            this.Property(t => t.layer_background)
                .HasMaxLength(512);

            this.Property(t => t.layer_output)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.lgnd_totalon)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.qtxt_assign_templ)
                .HasMaxLength(512);

            this.Property(t => t.qtxt_owner_templ)
                .HasMaxLength(512);

            this.Property(t => t.rule_suffix)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.rule_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.table_assigned)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.table_owner)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.title)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.url_name)
                .HasMaxLength(256);

            this.Property(t => t.rule_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("afm_dwgpub", "afm");
            this.Property(t => t.color_mapping).HasColumnName("color_mapping");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.dwg_view).HasColumnName("dwg_view");
            this.Property(t => t.filter_assigned).HasColumnName("filter_assigned");
            this.Property(t => t.filter_owner).HasColumnName("filter_owner");
            this.Property(t => t.highlight_outline).HasColumnName("highlight_outline");
            this.Property(t => t.hpattern_acad).HasColumnName("hpattern_acad");
            this.Property(t => t.is_active).HasColumnName("is_active");
            this.Property(t => t.layer_addl).HasColumnName("layer_addl");
            this.Property(t => t.layer_background).HasColumnName("layer_background");
            this.Property(t => t.layer_output).HasColumnName("layer_output");
            this.Property(t => t.lgnd_all_owners).HasColumnName("lgnd_all_owners");
            this.Property(t => t.lgnd_counts).HasColumnName("lgnd_counts");
            this.Property(t => t.lgnd_draw).HasColumnName("lgnd_draw");
            this.Property(t => t.lgnd_key_flds).HasColumnName("lgnd_key_flds");
            this.Property(t => t.lgnd_ncolumns).HasColumnName("lgnd_ncolumns");
            this.Property(t => t.lgnd_show_date).HasColumnName("lgnd_show_date");
            this.Property(t => t.lgnd_show_desc).HasColumnName("lgnd_show_desc");
            this.Property(t => t.lgnd_show_time).HasColumnName("lgnd_show_time");
            this.Property(t => t.lgnd_sort).HasColumnName("lgnd_sort");
            this.Property(t => t.lgnd_totalon).HasColumnName("lgnd_totalon");
            this.Property(t => t.lgnd_totals).HasColumnName("lgnd_totals");
            this.Property(t => t.lgnd_txtheight).HasColumnName("lgnd_txtheight");
            this.Property(t => t.lgnd_x).HasColumnName("lgnd_x");
            this.Property(t => t.lgnd_y).HasColumnName("lgnd_y");
            this.Property(t => t.qtxt_assign_templ).HasColumnName("qtxt_assign_templ");
            this.Property(t => t.qtxt_fit).HasColumnName("qtxt_fit");
            this.Property(t => t.qtxt_ht).HasColumnName("qtxt_ht");
            this.Property(t => t.qtxt_owner_templ).HasColumnName("qtxt_owner_templ");
            this.Property(t => t.rule_suffix).HasColumnName("rule_suffix");
            this.Property(t => t.rule_type).HasColumnName("rule_type");
            this.Property(t => t.table_assigned).HasColumnName("table_assigned");
            this.Property(t => t.table_owner).HasColumnName("table_owner");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.url_name).HasColumnName("url_name");
            this.Property(t => t.rule_id).HasColumnName("rule_id");

            // Relationships
            this.HasOptional(t => t.afm_flds)
                .WithMany(t => t.afm_dwgpub)
                .HasForeignKey(d => new { d.table_assigned, d.lgnd_totalon });
            this.HasOptional(t => t.afm_tbls)
                .WithMany(t => t.afm_dwgpub)
                .HasForeignKey(d => d.table_assigned);
            this.HasOptional(t => t.afm_tbls1)
                .WithMany(t => t.afm_dwgpub1)
                .HasForeignKey(d => d.table_owner);

        }
    }
}
