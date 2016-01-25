using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_tbl_mapMap : EntityTypeConfiguration<afm_tbl_map>
    {
        public afm_tbl_mapMap()
        {
            // Primary Key
            this.HasKey(t => new { t.new_table, t.new_field });

            // Properties
            this.Property(t => t.old_field)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.old_table)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.new_table)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.new_field)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("afm_tbl_map", "afm");
            this.Property(t => t.old_field).HasColumnName("old_field");
            this.Property(t => t.old_table).HasColumnName("old_table");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.new_table).HasColumnName("new_table");
            this.Property(t => t.new_field).HasColumnName("new_field");

            // Relationships
            this.HasRequired(t => t.afm_tbls)
                .WithMany(t => t.afm_tbl_map)
                .HasForeignKey(d => d.new_table);

        }
    }
}
