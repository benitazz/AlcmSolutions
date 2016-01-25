using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ehs_incidents_syncMap : EntityTypeConfiguration<ehs_incidents_sync>
    {
        public ehs_incidents_syncMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.contact_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.description)
                .HasMaxLength(500);

            this.Property(t => t.em_id_affected)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.incident_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.injury_area_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.injury_category_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.mob_locked_by)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.non_em_info)
                .HasMaxLength(500);

            this.Property(t => t.non_em_name)
                .HasMaxLength(60);

            this.Property(t => t.pr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.recorded_by)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.reported_by)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("ehs_incidents_sync", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.contact_id).HasColumnName("contact_id");
            this.Property(t => t.date_death).HasColumnName("date_death");
            this.Property(t => t.date_incident).HasColumnName("date_incident");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.em_id_affected).HasColumnName("em_id_affected");
            this.Property(t => t.emergency_rm_treatment).HasColumnName("emergency_rm_treatment");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.incident_id).HasColumnName("incident_id");
            this.Property(t => t.incident_type).HasColumnName("incident_type");
            this.Property(t => t.injury_area_id).HasColumnName("injury_area_id");
            this.Property(t => t.injury_category_id).HasColumnName("injury_category_id");
            this.Property(t => t.is_hospitalized).HasColumnName("is_hospitalized");
            this.Property(t => t.mob_incident_id).HasColumnName("mob_incident_id");
            this.Property(t => t.mob_is_changed).HasColumnName("mob_is_changed");
            this.Property(t => t.mob_locked_by).HasColumnName("mob_locked_by");
            this.Property(t => t.non_em_info).HasColumnName("non_em_info");
            this.Property(t => t.non_em_name).HasColumnName("non_em_name");
            this.Property(t => t.parent_incident_id).HasColumnName("parent_incident_id");
            this.Property(t => t.pr_id).HasColumnName("pr_id");
            this.Property(t => t.recorded_by).HasColumnName("recorded_by");
            this.Property(t => t.reported_by).HasColumnName("reported_by");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.time_incident).HasColumnName("time_incident");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasOptional(t => t.bl)
                .WithMany(t => t.ehs_incidents_sync)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.contact)
                .WithMany(t => t.EhsIncidentsSync)
                .HasForeignKey(d => d.contact_id);
            this.HasOptional(t => t.ehs_incident_injury_areas)
                .WithMany(t => t.ehs_incidents_sync)
                .HasForeignKey(d => d.injury_area_id);
            this.HasOptional(t => t.ehs_incident_injury_cat)
                .WithMany(t => t.ehs_incidents_sync)
                .HasForeignKey(d => d.injury_category_id);
            this.HasRequired(t => t.ehs_incident_types)
                .WithMany(t => t.ehs_incidents_sync)
                .HasForeignKey(d => d.incident_type);
            this.HasOptional(t => t.em)
                .WithMany(t => t.EhsIncidentsSync)
                .HasForeignKey(d => d.em_id_affected);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.EhsIncidentsSync)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.property)
                .WithMany(t => t.ehs_incidents_sync)
                .HasForeignKey(d => d.pr_id);
            this.HasOptional(t => t.em1)
                .WithMany(t => t.EhsIncidentsSync1)
                .HasForeignKey(d => d.recorded_by);
            this.HasOptional(t => t.em2)
                .WithMany(t => t.EhsIncidentsSync2)
                .HasForeignKey(d => d.reported_by);
            this.HasOptional(t => t.rm)
                .WithMany(t => t.ehs_incidents_sync)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });
            this.HasOptional(t => t.site)
                .WithMany(t => t.ehs_incidents_sync)
                .HasForeignKey(d => d.site_id);

        }
    }
}
