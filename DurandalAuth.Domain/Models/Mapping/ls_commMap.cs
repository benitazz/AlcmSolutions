using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ls_commMap : EntityTypeConfiguration<ls_comm>
    {
        public ls_commMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.comm_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.comm_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.contact_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.doc)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.hierarchy_ids)
                .HasMaxLength(500);

            this.Property(t => t.image_doc1)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.ls_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.priority)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.project_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.recorded_by)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.reg_program)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.reg_requirement)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.regulation)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.summary)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("ls_comm", "afm");
            this.Property(t => t.comm_id).HasColumnName("comm_id");
            this.Property(t => t.comm_type).HasColumnName("comm_type");
            this.Property(t => t.contact_id).HasColumnName("contact_id");
            this.Property(t => t.date_of_comm).HasColumnName("date_of_comm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.doc).HasColumnName("doc");
            this.Property(t => t.hierarchy_ids).HasColumnName("hierarchy_ids");
            this.Property(t => t.image_doc1).HasColumnName("image_doc1");
            this.Property(t => t.location_id).HasColumnName("location_id");
            this.Property(t => t.ls_id).HasColumnName("ls_id");
            this.Property(t => t.parent_key).HasColumnName("parent_key");
            this.Property(t => t.priority).HasColumnName("priority");
            this.Property(t => t.project_id).HasColumnName("project_id");
            this.Property(t => t.recorded_by).HasColumnName("recorded_by");
            this.Property(t => t.reg_program).HasColumnName("reg_program");
            this.Property(t => t.reg_requirement).HasColumnName("reg_requirement");
            this.Property(t => t.regulation).HasColumnName("regulation");
            this.Property(t => t.summary).HasColumnName("summary");
            this.Property(t => t.time_of_comm).HasColumnName("time_of_comm");
            this.Property(t => t.activity_log_id).HasColumnName("activity_log_id");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasOptional(t => t.activity_log)
                .WithMany(t => t.ls_comm)
                .HasForeignKey(d => d.activity_log_id);
            this.HasOptional(t => t.commtype)
                .WithMany(t => t.ls_comm)
                .HasForeignKey(d => d.comm_type);
            this.HasOptional(t => t.compliance_locations)
                .WithMany(t => t.ls_comm)
                .HasForeignKey(d => d.location_id);
            this.HasOptional(t => t.contact)
                .WithMany(t => t.LsComm)
                .HasForeignKey(d => d.contact_id);
            this.HasOptional(t => t.em)
                .WithMany(t => t.ls_comm)
                .HasForeignKey(d => d.recorded_by);
            this.HasOptional(t => t.l)
                .WithMany(t => t.ls_comm)
                .HasForeignKey(d => d.ls_id);
            this.HasOptional(t => t.project)
                .WithMany(t => t.ls_comm)
                .HasForeignKey(d => d.project_id);
            this.HasOptional(t => t.regprogram)
                .WithMany(t => t.ls_comm)
                .HasForeignKey(d => new { d.regulation, d.reg_program });
            this.HasOptional(t => t.regrequirement)
                .WithMany(t => t.ls_comm)
                .HasForeignKey(d => new { d.regulation, d.reg_program, d.reg_requirement });
            this.HasOptional(t => t.regulation1)
                .WithMany(t => t.ls_comm)
                .HasForeignKey(d => d.regulation);

        }
    }
}
