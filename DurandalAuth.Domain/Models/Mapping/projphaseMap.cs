using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class projphaseMap : EntityTypeConfiguration<projphase>
    {
        public projphaseMap()
        {
            // Primary Key
            this.HasKey(t => t.proj_phase);

            // Properties
            this.Property(t => t.proj_phase_01)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.proj_phase_02)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.proj_phase_03)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.proj_phase_ch)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.proj_phase_de)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.proj_phase_es)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.proj_phase_fr)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.proj_phase_it)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.proj_phase_jp)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.proj_phase_ko)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.proj_phase_nl)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.proj_phase_no)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.proj_phase_zh)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.proj_phase)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("projphase", "afm");
            this.Property(t => t.proj_phase_01).HasColumnName("proj_phase_01");
            this.Property(t => t.proj_phase_02).HasColumnName("proj_phase_02");
            this.Property(t => t.proj_phase_03).HasColumnName("proj_phase_03");
            this.Property(t => t.proj_phase_ch).HasColumnName("proj_phase_ch");
            this.Property(t => t.proj_phase_de).HasColumnName("proj_phase_de");
            this.Property(t => t.proj_phase_es).HasColumnName("proj_phase_es");
            this.Property(t => t.proj_phase_fr).HasColumnName("proj_phase_fr");
            this.Property(t => t.proj_phase_it).HasColumnName("proj_phase_it");
            this.Property(t => t.proj_phase_jp).HasColumnName("proj_phase_jp");
            this.Property(t => t.proj_phase_ko).HasColumnName("proj_phase_ko");
            this.Property(t => t.proj_phase_nl).HasColumnName("proj_phase_nl");
            this.Property(t => t.proj_phase_no).HasColumnName("proj_phase_no");
            this.Property(t => t.proj_phase_zh).HasColumnName("proj_phase_zh");
            this.Property(t => t.proj_phase).HasColumnName("proj_phase");
        }
    }
}
