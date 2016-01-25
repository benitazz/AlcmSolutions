using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class cb_hcm_placesMap : EntityTypeConfiguration<cb_hcm_places>
    {
        public cb_hcm_placesMap()
        {
            // Primary Key
            this.HasKey(t => t.hcm_places_id);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.comments)
                .HasMaxLength(2000);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("cb_hcm_places", "afm");
            this.Property(t => t.activity_log_id).HasColumnName("activity_log_id");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.hcm_places_id).HasColumnName("hcm_places_id");

            // Relationships
            this.HasRequired(t => t.activity_log)
                .WithMany(t => t.cb_hcm_places)
                .HasForeignKey(d => d.activity_log_id);
            this.HasOptional(t => t.bl)
                .WithMany(t => t.cb_hcm_places)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.CbHcmPlaces)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.rm)
                .WithMany(t => t.cb_hcm_places)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });

        }
    }
}
