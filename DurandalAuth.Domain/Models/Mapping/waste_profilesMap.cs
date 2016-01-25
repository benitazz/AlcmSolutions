using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class waste_profilesMap : EntityTypeConfiguration<waste_profiles>
    {
        public waste_profilesMap()
        {
            // Primary Key
            this.HasKey(t => t.waste_profile);

            // Properties
            this.Property(t => t.cas_number)
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.transp_classification)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.transp_shipping_name)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.units_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.waste_category)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.waste_name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.waste_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.waste_profile)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("waste_profiles", "afm");
            this.Property(t => t.cas_number).HasColumnName("cas_number");
            this.Property(t => t.is_recyclable).HasColumnName("is_recyclable");
            this.Property(t => t.msds_id).HasColumnName("msds_id");
            this.Property(t => t.specific_gravity).HasColumnName("specific_gravity");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.transp_classification).HasColumnName("transp_classification");
            this.Property(t => t.transp_hazardous).HasColumnName("transp_hazardous");
            this.Property(t => t.transp_shipping_name).HasColumnName("transp_shipping_name");
            this.Property(t => t.units_type).HasColumnName("units_type");
            this.Property(t => t.waste_category).HasColumnName("waste_category");
            this.Property(t => t.waste_name).HasColumnName("waste_name");
            this.Property(t => t.waste_type).HasColumnName("waste_type");
            this.Property(t => t.waste_profile).HasColumnName("waste_profile");

            // Relationships
            this.HasRequired(t => t.bill_type)
                .WithMany(t => t.waste_profiles)
                .HasForeignKey(d => d.units_type);
            this.HasRequired(t => t.waste_categories)
                .WithMany(t => t.waste_profiles)
                .HasForeignKey(d => d.waste_category);

        }
    }
}
