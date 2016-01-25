using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_timezonesMap : EntityTypeConfiguration<afm_timezones>
    {
        public afm_timezonesMap()
        {
            // Primary Key
            this.HasKey(t => t.timezone_id);

            // Properties
            this.Property(t => t.timezone_id_01)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.timezone_id_02)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.timezone_id_03)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.timezone_id_ch)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.timezone_id_de)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.timezone_id_es)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.timezone_id_fr)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.timezone_id_it)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.timezone_id_jp)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.timezone_id_ko)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.timezone_id_nl)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.timezone_id_no)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.timezone_id_zh)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.timezone_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("afm_timezones", "afm");
            this.Property(t => t.timezone_id_01).HasColumnName("timezone_id_01");
            this.Property(t => t.timezone_id_02).HasColumnName("timezone_id_02");
            this.Property(t => t.timezone_id_03).HasColumnName("timezone_id_03");
            this.Property(t => t.timezone_id_ch).HasColumnName("timezone_id_ch");
            this.Property(t => t.timezone_id_de).HasColumnName("timezone_id_de");
            this.Property(t => t.timezone_id_es).HasColumnName("timezone_id_es");
            this.Property(t => t.timezone_id_fr).HasColumnName("timezone_id_fr");
            this.Property(t => t.timezone_id_it).HasColumnName("timezone_id_it");
            this.Property(t => t.timezone_id_jp).HasColumnName("timezone_id_jp");
            this.Property(t => t.timezone_id_ko).HasColumnName("timezone_id_ko");
            this.Property(t => t.timezone_id_nl).HasColumnName("timezone_id_nl");
            this.Property(t => t.timezone_id_no).HasColumnName("timezone_id_no");
            this.Property(t => t.timezone_id_zh).HasColumnName("timezone_id_zh");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.timezone_id).HasColumnName("timezone_id");
        }
    }
}
