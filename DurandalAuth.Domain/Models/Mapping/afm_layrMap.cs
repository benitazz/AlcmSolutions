using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_layrMap : EntityTypeConfiguration<afm_layr>
    {
        public afm_layrMap()
        {
            // Primary Key
            this.HasKey(t => t.layer_name);

            // Properties
            this.Property(t => t.linetype)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.redef_name)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.table_name)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.title)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.title_01)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.title_02)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.title_03)
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

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.layer_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("afm_layr", "afm");
            this.Property(t => t.linetype).HasColumnName("linetype");
            this.Property(t => t.redef_name).HasColumnName("redef_name");
            this.Property(t => t.table_name).HasColumnName("table_name");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.title_01).HasColumnName("title_01");
            this.Property(t => t.title_02).HasColumnName("title_02");
            this.Property(t => t.title_03).HasColumnName("title_03");
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
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.color).HasColumnName("color");
            this.Property(t => t.layer_name).HasColumnName("layer_name");

            // Relationships
            this.HasOptional(t => t.afm_atyp)
                .WithMany(t => t.afm_layr)
                .HasForeignKey(d => d.table_name);

        }
    }
}
