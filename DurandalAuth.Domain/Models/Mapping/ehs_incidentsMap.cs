using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ehs_incidentsMap : EntityTypeConfiguration<ehs_incidents>
    {
        public ehs_incidentsMap()
        {
            // Primary Key
            this.HasKey(t => t.incident_id);

            // Properties
            this.Property(t => t.activity_before)
                .HasMaxLength(200);

            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.cause_category_id)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.cause_description)
                .HasMaxLength(500);

            this.Property(t => t.cause_doc)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.chemical_name)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.contact_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.description)
                .HasMaxLength(500);

            this.Property(t => t.em_id_affected)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.eq_id)
                .IsFixedLength()
                .HasMaxLength(12);

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

            this.Property(t => t.long_term_ca)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.long_term_ca_desc)
                .HasMaxLength(1000);

            this.Property(t => t.lt_reg_program)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.lt_reg_requirement)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.lt_regulation)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.medical_facility)
                .HasMaxLength(80);

            this.Property(t => t.medical_facility_address)
                .HasMaxLength(200);

            this.Property(t => t.non_em_info)
                .HasMaxLength(500);

            this.Property(t => t.non_em_name)
                .HasMaxLength(60);

            this.Property(t => t.physician_name)
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

            this.Property(t => t.responsible_mgr)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.safety_officer)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.short_term_ca)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.short_term_ca_desc)
                .HasMaxLength(500);

            this.Property(t => t.site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.st_reg_program)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.st_reg_requirement)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.st_regulation)
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("ehs_incidents", "afm");
            this.Property(t => t.activity_before).HasColumnName("activity_before");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.cause_category_id).HasColumnName("cause_category_id");
            this.Property(t => t.cause_description).HasColumnName("cause_description");
            this.Property(t => t.cause_doc).HasColumnName("cause_doc");
            this.Property(t => t.chemical_name).HasColumnName("chemical_name");
            this.Property(t => t.contact_id).HasColumnName("contact_id");
            this.Property(t => t.date_death).HasColumnName("date_death");
            this.Property(t => t.date_incident).HasColumnName("date_incident");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.em_id_affected).HasColumnName("em_id_affected");
            this.Property(t => t.emergency_rm_treatment).HasColumnName("emergency_rm_treatment");
            this.Property(t => t.eq_id).HasColumnName("eq_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.geo_objectid).HasColumnName("geo_objectid");
            this.Property(t => t.incident_type).HasColumnName("incident_type");
            this.Property(t => t.injury_area_id).HasColumnName("injury_area_id");
            this.Property(t => t.injury_category_id).HasColumnName("injury_category_id");
            this.Property(t => t.is_hospitalized).HasColumnName("is_hospitalized");
            this.Property(t => t.lat).HasColumnName("lat");
            this.Property(t => t.lon).HasColumnName("lon");
            this.Property(t => t.long_term_ca).HasColumnName("long_term_ca");
            this.Property(t => t.long_term_ca_desc).HasColumnName("long_term_ca_desc");
            this.Property(t => t.lost_work_days).HasColumnName("lost_work_days");
            this.Property(t => t.lt_reg_program).HasColumnName("lt_reg_program");
            this.Property(t => t.lt_reg_requirement).HasColumnName("lt_reg_requirement");
            this.Property(t => t.lt_regulation).HasColumnName("lt_regulation");
            this.Property(t => t.medical_facility).HasColumnName("medical_facility");
            this.Property(t => t.medical_facility_address).HasColumnName("medical_facility_address");
            this.Property(t => t.non_em_info).HasColumnName("non_em_info");
            this.Property(t => t.non_em_name).HasColumnName("non_em_name");
            this.Property(t => t.parent_incident_id).HasColumnName("parent_incident_id");
            this.Property(t => t.physician_name).HasColumnName("physician_name");
            this.Property(t => t.pr_id).HasColumnName("pr_id");
            this.Property(t => t.recorded_by).HasColumnName("recorded_by");
            this.Property(t => t.reported_by).HasColumnName("reported_by");
            this.Property(t => t.responsible_mgr).HasColumnName("responsible_mgr");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.safety_officer).HasColumnName("safety_officer");
            this.Property(t => t.short_term_ca).HasColumnName("short_term_ca");
            this.Property(t => t.short_term_ca_desc).HasColumnName("short_term_ca_desc");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.st_reg_program).HasColumnName("st_reg_program");
            this.Property(t => t.st_reg_requirement).HasColumnName("st_reg_requirement");
            this.Property(t => t.st_regulation).HasColumnName("st_regulation");
            this.Property(t => t.time_incident).HasColumnName("time_incident");
            this.Property(t => t.incident_id).HasColumnName("incident_id");

            // Relationships
            this.HasOptional(t => t.bl)
                .WithMany(t => t.ehs_incidents)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.contact)
                .WithMany(t => t.EhsIncidents)
                .HasForeignKey(d => d.contact_id);
            this.HasOptional(t => t.ehs_chemicals)
                .WithMany(t => t.ehs_incidents)
                .HasForeignKey(d => d.chemical_name);
            this.HasOptional(t => t.ehs_incident_cause_cat)
                .WithMany(t => t.ehs_incidents)
                .HasForeignKey(d => d.cause_category_id);
            this.HasOptional(t => t.ehs_incident_injury_areas)
                .WithMany(t => t.ehs_incidents)
                .HasForeignKey(d => d.injury_area_id);
            this.HasOptional(t => t.ehs_incident_injury_cat)
                .WithMany(t => t.ehs_incidents)
                .HasForeignKey(d => d.injury_category_id);
            this.HasOptional(t => t.ehs_incident_long_tm_ca)
                .WithMany(t => t.ehs_incidents)
                .HasForeignKey(d => d.long_term_ca);
            this.HasOptional(t => t.ehs_incident_short_tm_ca)
                .WithMany(t => t.ehs_incidents)
                .HasForeignKey(d => d.short_term_ca);
            this.HasRequired(t => t.ehs_incident_types)
                .WithMany(t => t.ehs_incidents)
                .HasForeignKey(d => d.incident_type);
            this.HasOptional(t => t.em)
                .WithMany(t => t.EhsIncidents)
                .HasForeignKey(d => d.em_id_affected);
            this.HasOptional(t => t.eq)
                .WithMany(t => t.ehs_incidents)
                .HasForeignKey(d => d.eq_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.EhsIncidents)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.regprogram)
                .WithMany(t => t.ehs_incidents)
                .HasForeignKey(d => new { d.lt_regulation, d.lt_reg_program });
            this.HasOptional(t => t.regrequirement)
                .WithMany(t => t.ehs_incidents)
                .HasForeignKey(d => new { d.lt_regulation, d.lt_reg_program, d.lt_reg_requirement });
            this.HasOptional(t => t.regulation)
                .WithMany(t => t.ehs_incidents)
                .HasForeignKey(d => d.lt_regulation);
            this.HasOptional(t => t.property)
                .WithMany(t => t.ehs_incidents)
                .HasForeignKey(d => d.pr_id);
            this.HasOptional(t => t.em1)
                .WithMany(t => t.EhsIncidents1)
                .HasForeignKey(d => d.recorded_by);
            this.HasOptional(t => t.em2)
                .WithMany(t => t.EhsIncidents2)
                .HasForeignKey(d => d.reported_by);
            this.HasOptional(t => t.em3)
                .WithMany(t => t.EhsIncidents3)
                .HasForeignKey(d => d.responsible_mgr);
            this.HasOptional(t => t.rm)
                .WithMany(t => t.ehs_incidents)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });
            this.HasOptional(t => t.em4)
                .WithMany(t => t.EhsIncidents4)
                .HasForeignKey(d => d.safety_officer);
            this.HasOptional(t => t.site)
                .WithMany(t => t.ehs_incidents)
                .HasForeignKey(d => d.site_id);
            this.HasOptional(t => t.regprogram1)
                .WithMany(t => t.ehs_incidents1)
                .HasForeignKey(d => new { d.st_regulation, d.st_reg_program });
            this.HasOptional(t => t.regrequirement1)
                .WithMany(t => t.ehs_incidents1)
                .HasForeignKey(d => new { d.st_regulation, d.st_reg_program, d.st_reg_requirement });
            this.HasOptional(t => t.regulation1)
                .WithMany(t => t.ehs_incidents1)
                .HasForeignKey(d => d.st_regulation);

        }
    }
}
