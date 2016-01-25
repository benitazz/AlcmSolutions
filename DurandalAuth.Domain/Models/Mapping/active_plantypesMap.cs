using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class active_plantypesMap : EntityTypeConfiguration<active_plantypes>
    {
        public active_plantypesMap()
        {
            // Primary Key
            this.HasKey(t => t.plan_type);

            // Properties
            this.Property(t => t.hs_ds)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.hs_ds2)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.label_clr)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.label_clr2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.label_ds)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.label_ds2)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.title)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.title_ch)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.title_de)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.title_es)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.title_fr)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.title_it)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.title_jp)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.title_ko)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.title_nl)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.title_no)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.title_zh)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.view_file)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.view_file2)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.plan_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("active_plantypes", "afm");
            this.Property(t => t.active).HasColumnName("active");
            this.Property(t => t.hs_ds).HasColumnName("hs_ds");
            this.Property(t => t.hs_ds2).HasColumnName("hs_ds2");
            this.Property(t => t.hs_hide).HasColumnName("hs_hide");
            this.Property(t => t.hs_hide2).HasColumnName("hs_hide2");
            this.Property(t => t.label_clr).HasColumnName("label_clr");
            this.Property(t => t.label_clr2).HasColumnName("label_clr2");
            this.Property(t => t.label_ds).HasColumnName("label_ds");
            this.Property(t => t.label_ds2).HasColumnName("label_ds2");
            this.Property(t => t.label_ht).HasColumnName("label_ht");
            this.Property(t => t.label_ht2).HasColumnName("label_ht2");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.title_ch).HasColumnName("title_ch");
            this.Property(t => t.title_de).HasColumnName("title_de");
            this.Property(t => t.title_es).HasColumnName("title_es");
            this.Property(t => t.title_fr).HasColumnName("title_fr");
            this.Property(t => t.title_it).HasColumnName("title_it");
            this.Property(t => t.title_jp).HasColumnName("title_jp");
            this.Property(t => t.title_ko).HasColumnName("title_ko");
            this.Property(t => t.title_nl).HasColumnName("title_nl");
            this.Property(t => t.title_no).HasColumnName("title_no");
            this.Property(t => t.title_zh).HasColumnName("title_zh");
            this.Property(t => t.view_file).HasColumnName("view_file");
            this.Property(t => t.view_file2).HasColumnName("view_file2");
            this.Property(t => t.plan_type).HasColumnName("plan_type");
        }
    }
}
