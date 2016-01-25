using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class msds_chemicalMap : EntityTypeConfiguration<msds_chemical>
    {
        public msds_chemicalMap()
        {
            // Primary Key
            this.HasKey(t => t.chemical_id);

            // Properties
            this.Property(t => t.ec_number)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.icsc_number)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.rtecs_number)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.tier2)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.un_number)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.alias)
                .HasMaxLength(160);

            this.Property(t => t.cas_number)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.chemical_id)
                .IsRequired()
                .HasMaxLength(160);

            // Table & Column Mappings
            this.ToTable("msds_chemical", "afm");
            this.Property(t => t.ec_number).HasColumnName("ec_number");
            this.Property(t => t.icsc_number).HasColumnName("icsc_number");
            this.Property(t => t.rtecs_number).HasColumnName("rtecs_number");
            this.Property(t => t.tier2).HasColumnName("tier2");
            this.Property(t => t.un_number).HasColumnName("un_number");
            this.Property(t => t.alias).HasColumnName("alias");
            this.Property(t => t.cas_number).HasColumnName("cas_number");
            this.Property(t => t.chemical_id).HasColumnName("chemical_id");
        }
    }
}
