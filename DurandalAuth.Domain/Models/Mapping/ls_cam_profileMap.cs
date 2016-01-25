using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ls_cam_profileMap : EntityTypeConfiguration<ls_cam_profile>
    {
        public ls_cam_profileMap()
        {
            // Primary Key
            this.HasKey(t => t.ls_id);

            // Properties
            this.Property(t => t.cam_alloc_method)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.cam_freq)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.cam_year_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ls_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("ls_cam_profile", "afm");
            this.Property(t => t.cam_alloc_method).HasColumnName("cam_alloc_method");
            this.Property(t => t.cam_area_negotiated).HasColumnName("cam_area_negotiated");
            this.Property(t => t.cam_cost_area).HasColumnName("cam_cost_area");
            this.Property(t => t.cam_cost_fixed).HasColumnName("cam_cost_fixed");
            this.Property(t => t.cam_cost_per_area).HasColumnName("cam_cost_per_area");
            this.Property(t => t.cam_cost_rent_pct).HasColumnName("cam_cost_rent_pct");
            this.Property(t => t.cam_freq).HasColumnName("cam_freq");
            this.Property(t => t.cam_rent).HasColumnName("cam_rent");
            this.Property(t => t.cam_rent_pct).HasColumnName("cam_rent_pct");
            this.Property(t => t.cam_year_type).HasColumnName("cam_year_type");
            this.Property(t => t.date_rent_last_update).HasColumnName("date_rent_last_update");
            this.Property(t => t.ls_id).HasColumnName("ls_id");

            // Relationships
            this.HasRequired(t => t.l)
                .WithOptional(t => t.ls_cam_profile);

        }
    }
}
