using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class work_roles_locationMap : EntityTypeConfiguration<work_roles_location>
    {
        public work_roles_locationMap()
        {
            // Primary Key
            this.HasKey(t => t.work_role_location_id);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.em_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.pr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.work_role_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("work_roles_location", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.pr_id).HasColumnName("pr_id");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.work_role_name).HasColumnName("work_role_name");
            this.Property(t => t.work_role_location_id).HasColumnName("work_role_location_id");

            // Relationships
            this.HasOptional(t => t.bl)
                .WithMany(t => t.work_roles_location)
                .HasForeignKey(d => d.bl_id);
            this.HasRequired(t => t.em)
                .WithMany(t => t.work_roles_location)
                .HasForeignKey(d => d.em_id);
            this.HasOptional(t => t.property)
                .WithMany(t => t.work_roles_location)
                .HasForeignKey(d => d.pr_id);
            this.HasOptional(t => t.site)
                .WithMany(t => t.work_roles_location)
                .HasForeignKey(d => d.site_id);
            this.HasRequired(t => t.work_roles)
                .WithMany(t => t.work_roles_location)
                .HasForeignKey(d => d.work_role_name);

        }
    }
}
