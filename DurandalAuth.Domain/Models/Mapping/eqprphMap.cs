using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class eqprphMap : EntityTypeConfiguration<eqprph>
    {
        public eqprphMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.eq_id)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.eq_std)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.num_serial)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.prph_type)
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("eqprph", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.eq_id).HasColumnName("eq_id");
            this.Property(t => t.eq_std).HasColumnName("eq_std");
            this.Property(t => t.num_serial).HasColumnName("num_serial");
            this.Property(t => t.prph_type).HasColumnName("prph_type");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasOptional(t => t.eq)
                .WithMany(t => t.eqprphs)
                .HasForeignKey(d => d.eq_id);
            this.HasOptional(t => t.eqstd)
                .WithMany(t => t.eqprphs)
                .HasForeignKey(d => d.eq_std);

        }
    }
}
