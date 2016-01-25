using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_conversionsMap : EntityTypeConfiguration<afm_conversions>
    {
        public afm_conversionsMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.destin_units)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.exchange_rate_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.is_currency)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.source_units)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.symbol)
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("afm_conversions", "afm");
            this.Property(t => t.date_conversion).HasColumnName("date_conversion");
            this.Property(t => t.date_last_update).HasColumnName("date_last_update");
            this.Property(t => t.destin_units).HasColumnName("destin_units");
            this.Property(t => t.exchange_rate_type).HasColumnName("exchange_rate_type");
            this.Property(t => t.factor).HasColumnName("factor");
            this.Property(t => t.is_currency).HasColumnName("is_currency");
            this.Property(t => t.source_units).HasColumnName("source_units");
            this.Property(t => t.symbol).HasColumnName("symbol");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasRequired(t => t.afm_currencies)
                .WithMany(t => t.afm_conversions)
                .HasForeignKey(d => d.destin_units);
            this.HasRequired(t => t.afm_currencies1)
                .WithMany(t => t.afm_conversions1)
                .HasForeignKey(d => d.source_units);

        }
    }
}
