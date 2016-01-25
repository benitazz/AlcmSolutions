using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class pmgenMap : EntityTypeConfiguration<pmgen>
    {
        public pmgenMap()
        {
            // Primary Key
            this.HasKey(t => t.pmgen_id);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.group_param)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.pm_group)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.pm_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.recurring_rule)
                .HasMaxLength(1000);

            this.Property(t => t.site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.tr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("pmgen", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.gen_new_pmsd).HasColumnName("gen_new_pmsd");
            this.Property(t => t.group_param).HasColumnName("group_param");
            this.Property(t => t.pm_group).HasColumnName("pm_group");
            this.Property(t => t.pm_type).HasColumnName("pm_type");
            this.Property(t => t.recurring_rule).HasColumnName("recurring_rule");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.tr_id).HasColumnName("tr_id");
            this.Property(t => t.use_pm_group).HasColumnName("use_pm_group");
            this.Property(t => t.pmgen_id).HasColumnName("pmgen_id");

            // Relationships
            this.HasOptional(t => t.bl)
                .WithMany(t => t.pmgens)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.Pmgens)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.pmgp)
                .WithMany(t => t.pmgens)
                .HasForeignKey(d => d.pm_group);
            this.HasOptional(t => t.site)
                .WithMany(t => t.pmgens)
                .HasForeignKey(d => d.site_id);
            this.HasOptional(t => t.tr)
                .WithMany(t => t.pmgens)
                .HasForeignKey(d => d.tr_id);

        }
    }
}
