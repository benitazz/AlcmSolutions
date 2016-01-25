using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class programtypeMap : EntityTypeConfiguration<programtype>
    {
        public programtypeMap()
        {
            // Primary Key
            this.HasKey(t => t.program_type);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(300);

            this.Property(t => t.description_01)
                .HasMaxLength(450);

            this.Property(t => t.description_02)
                .HasMaxLength(450);

            this.Property(t => t.description_03)
                .HasMaxLength(450);

            this.Property(t => t.description_ch)
                .HasMaxLength(450);

            this.Property(t => t.description_de)
                .HasMaxLength(450);

            this.Property(t => t.description_es)
                .HasMaxLength(450);

            this.Property(t => t.description_fr)
                .HasMaxLength(450);

            this.Property(t => t.description_it)
                .HasMaxLength(450);

            this.Property(t => t.description_jp)
                .HasMaxLength(450);

            this.Property(t => t.description_ko)
                .HasMaxLength(450);

            this.Property(t => t.description_nl)
                .HasMaxLength(450);

            this.Property(t => t.description_no)
                .HasMaxLength(450);

            this.Property(t => t.description_zh)
                .HasMaxLength(450);

            this.Property(t => t.program_type_01)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.program_type_02)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.program_type_03)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.program_type_ch)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.program_type_de)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.program_type_es)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.program_type_fr)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.program_type_it)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.program_type_jp)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.program_type_ko)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.program_type_nl)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.program_type_no)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.program_type_zh)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.program_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("programtype", "afm");
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
            this.Property(t => t.program_type_01).HasColumnName("program_type_01");
            this.Property(t => t.program_type_02).HasColumnName("program_type_02");
            this.Property(t => t.program_type_03).HasColumnName("program_type_03");
            this.Property(t => t.program_type_ch).HasColumnName("program_type_ch");
            this.Property(t => t.program_type_de).HasColumnName("program_type_de");
            this.Property(t => t.program_type_es).HasColumnName("program_type_es");
            this.Property(t => t.program_type_fr).HasColumnName("program_type_fr");
            this.Property(t => t.program_type_it).HasColumnName("program_type_it");
            this.Property(t => t.program_type_jp).HasColumnName("program_type_jp");
            this.Property(t => t.program_type_ko).HasColumnName("program_type_ko");
            this.Property(t => t.program_type_nl).HasColumnName("program_type_nl");
            this.Property(t => t.program_type_no).HasColumnName("program_type_no");
            this.Property(t => t.program_type_zh).HasColumnName("program_type_zh");
            this.Property(t => t.program_type).HasColumnName("program_type");
        }
    }
}
