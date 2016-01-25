using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_holiday_datesMap : EntityTypeConfiguration<afm_holiday_dates>
    {
        public afm_holiday_datesMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.ctry_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.description_01)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.description_02)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.description_03)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.description_ch)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.description_de)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.description_es)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.description_fr)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.description_it)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.description_jp)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.description_ko)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.description_nl)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.description_no)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.description_zh)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.regn_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("afm_holiday_dates", "afm");
            this.Property(t => t.cal_date).HasColumnName("cal_date");
            this.Property(t => t.ctry_id).HasColumnName("ctry_id");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.description_01).HasColumnName("description_01");
            this.Property(t => t.description_02).HasColumnName("description_02");
            this.Property(t => t.description_03).HasColumnName("description_03");
            this.Property(t => t.description_ch).HasColumnName("description_ch");
            this.Property(t => t.description_de).HasColumnName("description_de");
            this.Property(t => t.description_es).HasColumnName("description_es");
            this.Property(t => t.description_fr).HasColumnName("description_fr");
            this.Property(t => t.description_it).HasColumnName("description_it");
            this.Property(t => t.description_jp).HasColumnName("description_jp");
            this.Property(t => t.description_ko).HasColumnName("description_ko");
            this.Property(t => t.description_nl).HasColumnName("description_nl");
            this.Property(t => t.description_no).HasColumnName("description_no");
            this.Property(t => t.description_zh).HasColumnName("description_zh");
            this.Property(t => t.regn_id).HasColumnName("regn_id");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasOptional(t => t.ctry)
                .WithMany(t => t.afm_holiday_dates)
                .HasForeignKey(d => d.ctry_id);
            this.HasOptional(t => t.regn)
                .WithMany(t => t.AfmHolidayDates)
                .HasForeignKey(d => new { d.ctry_id, d.regn_id });

        }
    }
}
