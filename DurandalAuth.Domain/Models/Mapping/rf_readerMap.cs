using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class rf_readerMap : EntityTypeConfiguration<rf_reader>
    {
        public rf_readerMap()
        {
            // Primary Key
            this.HasKey(t => t.reader_id);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.description)
                .HasMaxLength(1000);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.in_rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.out_rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.reader_type)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.reader_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("rf_reader", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.geo_objectid).HasColumnName("geo_objectid");
            this.Property(t => t.in_rm_id).HasColumnName("in_rm_id");
            this.Property(t => t.lat).HasColumnName("lat");
            this.Property(t => t.lon).HasColumnName("lon");
            this.Property(t => t.out_rm_id).HasColumnName("out_rm_id");
            this.Property(t => t.reader_type).HasColumnName("reader_type");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.reader_id).HasColumnName("reader_id");

            // Relationships
            this.HasOptional(t => t.bl)
                .WithMany(t => t.rf_reader)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.RfReader)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.rm)
                .WithMany(t => t.rf_reader)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.in_rm_id });
            this.HasOptional(t => t.rm1)
                .WithMany(t => t.rf_reader1)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.out_rm_id });
            this.HasOptional(t => t.site)
                .WithMany(t => t.rf_reader)
                .HasForeignKey(d => d.site_id);

        }
    }
}
