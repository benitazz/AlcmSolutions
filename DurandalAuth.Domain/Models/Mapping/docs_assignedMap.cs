using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class docs_assignedMap : EntityTypeConfiguration<docs_assigned>
    {
        public docs_assignedMap()
        {
            // Primary Key
            this.HasKey(t => t.doc_id);

            // Properties
            this.Property(t => t.doc_note)
                .HasMaxLength(2000);

            this.Property(t => t.doc_review_grp)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.doc_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.ls_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.ppe_type_id)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.pr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.reg_program)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.reg_requirement)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.regulation)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.training_id)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.classification)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(512);

            this.Property(t => t.doc)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.doc_author)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.doc_cat)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.doc_folder)
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("docs_assigned", "afm");
            this.Property(t => t.doc_note).HasColumnName("doc_note");
            this.Property(t => t.doc_review_grp).HasColumnName("doc_review_grp");
            this.Property(t => t.doc_type).HasColumnName("doc_type");
            this.Property(t => t.incident_id).HasColumnName("incident_id");
            this.Property(t => t.location_id).HasColumnName("location_id");
            this.Property(t => t.ls_id).HasColumnName("ls_id");
            this.Property(t => t.medical_monitoring_id).HasColumnName("medical_monitoring_id");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.ppe_type_id).HasColumnName("ppe_type_id");
            this.Property(t => t.pr_id).HasColumnName("pr_id");
            this.Property(t => t.reg_program).HasColumnName("reg_program");
            this.Property(t => t.reg_requirement).HasColumnName("reg_requirement");
            this.Property(t => t.regulation).HasColumnName("regulation");
            this.Property(t => t.restriction_id).HasColumnName("restriction_id");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.training_id).HasColumnName("training_id");
            this.Property(t => t.activity_log_id).HasColumnName("activity_log_id");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.classification).HasColumnName("classification");
            this.Property(t => t.date_doc).HasColumnName("date_doc");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.doc).HasColumnName("doc");
            this.Property(t => t.doc_author).HasColumnName("doc_author");
            this.Property(t => t.doc_cat).HasColumnName("doc_cat");
            this.Property(t => t.doc_folder).HasColumnName("doc_folder");
            this.Property(t => t.doc_id).HasColumnName("doc_id");

            // Relationships
            this.HasOptional(t => t.activity_log)
                .WithMany(t => t.docs_assigned)
                .HasForeignKey(d => d.activity_log_id);
            this.HasOptional(t => t.afm_groups)
                .WithMany(t => t.docs_assigned)
                .HasForeignKey(d => d.doc_review_grp);
            this.HasOptional(t => t.bl)
                .WithMany(t => t.docs_assigned)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.compliance_locations)
                .WithMany(t => t.docs_assigned)
                .HasForeignKey(d => d.location_id);
            this.HasOptional(t => t.doccat)
                .WithMany(t => t.docs_assigned)
                .HasForeignKey(d => d.doc_cat);
            this.HasOptional(t => t.docfolder)
                .WithMany(t => t.docs_assigned)
                .HasForeignKey(d => d.doc_folder);
            this.HasOptional(t => t.doctype)
                .WithMany(t => t.docs_assigned)
                .HasForeignKey(d => new { d.doc_cat, d.doc_type });
            this.HasOptional(t => t.ehs_incidents)
                .WithMany(t => t.docs_assigned)
                .HasForeignKey(d => d.incident_id);
            this.HasOptional(t => t.l)
                .WithMany(t => t.docs_assigned)
                .HasForeignKey(d => d.ls_id);
            this.HasOptional(t => t.ehs_medical_monitoring)
                .WithMany(t => t.docs_assigned)
                .HasForeignKey(d => d.medical_monitoring_id);
            this.HasOptional(t => t.ehs_ppe_types)
                .WithMany(t => t.docs_assigned)
                .HasForeignKey(d => d.ppe_type_id);
            this.HasOptional(t => t.property)
                .WithMany(t => t.docs_assigned)
                .HasForeignKey(d => d.pr_id);
            this.HasOptional(t => t.regprogram)
                .WithMany(t => t.docs_assigned)
                .HasForeignKey(d => new { d.regulation, d.reg_program });
            this.HasOptional(t => t.regrequirement)
                .WithMany(t => t.docs_assigned)
                .HasForeignKey(d => new { d.regulation, d.reg_program, d.reg_requirement });
            this.HasOptional(t => t.regulation1)
                .WithMany(t => t.docs_assigned)
                .HasForeignKey(d => d.regulation);
            this.HasOptional(t => t.ehs_restrictions)
                .WithMany(t => t.docs_assigned)
                .HasForeignKey(d => d.restriction_id);
            this.HasOptional(t => t.site)
                .WithMany(t => t.docs_assigned)
                .HasForeignKey(d => d.site_id);
            this.HasOptional(t => t.ehs_training)
                .WithMany(t => t.docs_assigned)
                .HasForeignKey(d => d.training_id);

        }
    }
}
