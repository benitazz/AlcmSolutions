using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class regrequirementMap : EntityTypeConfiguration<regrequirement>
    {
        public regrequirementMap()
        {
            // Primary Key
            this.HasKey(t => new { t.regulation, t.reg_program, t.reg_requirement });

            // Properties
            this.Property(t => t.citation)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.comp_level)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.comp_level_calc)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.completion_criteria)
                .HasMaxLength(2000);

            this.Property(t => t.contact_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.criteria_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.event_title)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.hold_reason)
                .HasMaxLength(2000);

            this.Property(t => t.notes)
                .HasMaxLength(5000);

            this.Property(t => t.recurring_rule)
                .HasMaxLength(256);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(18);

            this.Property(t => t.summary)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.vn_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.regreq_cat)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.regreq_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.regulation)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.reg_program)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.reg_requirement)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("regrequirement", "afm");
            this.Property(t => t.citation).HasColumnName("citation");
            this.Property(t => t.comp_level).HasColumnName("comp_level");
            this.Property(t => t.comp_level_calc).HasColumnName("comp_level_calc");
            this.Property(t => t.comp_level_number_calc).HasColumnName("comp_level_number_calc");
            this.Property(t => t.completion_criteria).HasColumnName("completion_criteria");
            this.Property(t => t.contact_id).HasColumnName("contact_id");
            this.Property(t => t.criteria_type).HasColumnName("criteria_type");
            this.Property(t => t.date_end).HasColumnName("date_end");
            this.Property(t => t.date_expire).HasColumnName("date_expire");
            this.Property(t => t.date_initial).HasColumnName("date_initial");
            this.Property(t => t.date_recurrence_end).HasColumnName("date_recurrence_end");
            this.Property(t => t.date_required).HasColumnName("date_required");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.event_duration).HasColumnName("event_duration");
            this.Property(t => t.event_sched_buffer).HasColumnName("event_sched_buffer");
            this.Property(t => t.event_title).HasColumnName("event_title");
            this.Property(t => t.hold_reason).HasColumnName("hold_reason");
            this.Property(t => t.notes).HasColumnName("notes");
            this.Property(t => t.notify_active).HasColumnName("notify_active");
            this.Property(t => t.priority).HasColumnName("priority");
            this.Property(t => t.recurring_rule).HasColumnName("recurring_rule");
            this.Property(t => t.sched_loc).HasColumnName("sched_loc");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.summary).HasColumnName("summary");
            this.Property(t => t.vn_id).HasColumnName("vn_id");
            this.Property(t => t.regreq_cat).HasColumnName("regreq_cat");
            this.Property(t => t.regreq_type).HasColumnName("regreq_type");
            this.Property(t => t.regulation).HasColumnName("regulation");
            this.Property(t => t.reg_program).HasColumnName("reg_program");
            this.Property(t => t.reg_requirement).HasColumnName("reg_requirement");

            // Relationships
            this.HasOptional(t => t.contact)
                .WithMany(t => t.Regrequirements)
                .HasForeignKey(d => d.contact_id);
            this.HasOptional(t => t.em)
                .WithMany(t => t.regrequirements)
                .HasForeignKey(d => d.em_id);
            this.HasOptional(t => t.regcomplevel)
                .WithMany(t => t.regrequirements)
                .HasForeignKey(d => d.comp_level);
            this.HasOptional(t => t.regcomplevel1)
                .WithMany(t => t.regrequirements1)
                .HasForeignKey(d => d.comp_level_calc);
            this.HasRequired(t => t.regprogram)
                .WithMany(t => t.regrequirements)
                .HasForeignKey(d => new { d.regulation, d.reg_program });
            this.HasOptional(t => t.regreqcat)
                .WithMany(t => t.regrequirements)
                .HasForeignKey(d => d.regreq_cat);
            this.HasRequired(t => t.regulation1)
                .WithMany(t => t.regrequirements)
                .HasForeignKey(d => d.regulation);
            this.HasOptional(t => t.vn)
                .WithMany(t => t.regrequirements)
                .HasForeignKey(d => d.vn_id);

        }
    }
}
