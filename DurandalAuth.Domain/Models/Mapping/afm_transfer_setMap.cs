using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_transfer_setMap : EntityTypeConfiguration<afm_transfer_set>
    {
        public afm_transfer_setMap()
        {
            // Primary Key
            this.HasKey(t => t.autonumbered_id);

            // Properties
            this.Property(t => t.set_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.table_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.table_type)
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("afm_transfer_set", "afm");
            this.Property(t => t.nrecords_dest).HasColumnName("nrecords_dest");
            this.Property(t => t.nrecords_inserted).HasColumnName("nrecords_inserted");
            this.Property(t => t.nrecords_missing).HasColumnName("nrecords_missing");
            this.Property(t => t.nrecords_source).HasColumnName("nrecords_source");
            this.Property(t => t.nrecords_updated).HasColumnName("nrecords_updated");
            this.Property(t => t.processing_order).HasColumnName("processing_order");
            this.Property(t => t.set_name).HasColumnName("set_name");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.table_name).HasColumnName("table_name");
            this.Property(t => t.table_type).HasColumnName("table_type");
            this.Property(t => t.autonumbered_id).HasColumnName("autonumbered_id");
        }
    }
}
