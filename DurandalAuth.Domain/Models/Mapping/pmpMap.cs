using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class pmpMap : EntityTypeConfiguration<pmp>
    {
        public pmpMap()
        {
            // Primary Key
            this.HasKey(t => t.pmp_id);

            // Properties
            this.Property(t => t.ac_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.description)
                .HasMaxLength(250);

            this.Property(t => t.doc)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.eq_std)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.pmp_ids_to_suppress)
                .HasMaxLength(1000);

            this.Property(t => t.pmp_type)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.tr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.units)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.pmp_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("pmp", "afm");
            this.Property(t => t.ac_id).HasColumnName("ac_id");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.doc).HasColumnName("doc");
            this.Property(t => t.eq_std).HasColumnName("eq_std");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.pmp_ids_to_suppress).HasColumnName("pmp_ids_to_suppress");
            this.Property(t => t.pmp_type).HasColumnName("pmp_type");
            this.Property(t => t.tr_id).HasColumnName("tr_id");
            this.Property(t => t.units).HasColumnName("units");
            this.Property(t => t.units_hour).HasColumnName("units_hour");
            this.Property(t => t.pmp_id).HasColumnName("pmp_id");

            // Relationships
            this.HasOptional(t => t.ac)
                .WithMany(t => t.pmps)
                .HasForeignKey(d => d.ac_id);
            this.HasOptional(t => t.eqstd)
                .WithMany(t => t.pmps)
                .HasForeignKey(d => d.eq_std);
            this.HasOptional(t => t.tr)
                .WithMany(t => t.pmps)
                .HasForeignKey(d => d.tr_id);

        }
    }
}
