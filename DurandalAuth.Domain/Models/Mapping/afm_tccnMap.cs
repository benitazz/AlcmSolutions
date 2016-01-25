using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_tccnMap : EntityTypeConfiguration<afm_tccn>
    {
        public afm_tccnMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.ca_std)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.comments)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.downhill_key)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.downhill_position)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.downhill_position_end)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.downhill_table)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.uphill_key)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.uphill_position)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.uphill_position_end)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.uphill_table)
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("afm_tccn", "afm");
            this.Property(t => t.ca_std).HasColumnName("ca_std");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.downhill_key).HasColumnName("downhill_key");
            this.Property(t => t.downhill_position).HasColumnName("downhill_position");
            this.Property(t => t.downhill_position_end).HasColumnName("downhill_position_end");
            this.Property(t => t.downhill_table).HasColumnName("downhill_table");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.uphill_key).HasColumnName("uphill_key");
            this.Property(t => t.uphill_position).HasColumnName("uphill_position");
            this.Property(t => t.uphill_position_end).HasColumnName("uphill_position_end");
            this.Property(t => t.uphill_table).HasColumnName("uphill_table");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasOptional(t => t.afm_tbls)
                .WithMany(t => t.afm_tccn)
                .HasForeignKey(d => d.downhill_table);
            this.HasOptional(t => t.afm_tbls1)
                .WithMany(t => t.afm_tccn1)
                .HasForeignKey(d => d.uphill_table);
            this.HasOptional(t => t.castd)
                .WithMany(t => t.afm_tccn)
                .HasForeignKey(d => d.ca_std);

        }
    }
}
