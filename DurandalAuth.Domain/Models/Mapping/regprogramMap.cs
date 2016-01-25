using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class regprogramMap : EntityTypeConfiguration<regprogram>
    {
        public regprogramMap()
        {
            // Primary Key
            this.HasKey(t => new { t.regulation, t.reg_program });

            // Properties
            this.Property(t => t.comp_level)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.comp_level_calc)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.contact_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.criteria)
                .HasMaxLength(2000);

            this.Property(t => t.criteria_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.hold_reason)
                .HasMaxLength(2000);

            this.Property(t => t.project_id)
                .IsFixedLength()
                .HasMaxLength(32);

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

            this.Property(t => t.regprog_cat)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.regprog_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.regulation)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.reg_program)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("regprogram", "afm");
            this.Property(t => t.comp_level).HasColumnName("comp_level");
            this.Property(t => t.comp_level_calc).HasColumnName("comp_level_calc");
            this.Property(t => t.comp_level_number_calc).HasColumnName("comp_level_number_calc");
            this.Property(t => t.contact_id).HasColumnName("contact_id");
            this.Property(t => t.criteria).HasColumnName("criteria");
            this.Property(t => t.criteria_type).HasColumnName("criteria_type");
            this.Property(t => t.date_end).HasColumnName("date_end");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.hold_reason).HasColumnName("hold_reason");
            this.Property(t => t.priority).HasColumnName("priority");
            this.Property(t => t.project_id).HasColumnName("project_id");
            this.Property(t => t.reqs_inherit_locs).HasColumnName("reqs_inherit_locs");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.summary).HasColumnName("summary");
            this.Property(t => t.vn_id).HasColumnName("vn_id");
            this.Property(t => t.regprog_cat).HasColumnName("regprog_cat");
            this.Property(t => t.regprog_type).HasColumnName("regprog_type");
            this.Property(t => t.regulation).HasColumnName("regulation");
            this.Property(t => t.reg_program).HasColumnName("reg_program");

            // Relationships
            this.HasOptional(t => t.contact)
                .WithMany(t => t.Regprograms)
                .HasForeignKey(d => d.contact_id);
            this.HasOptional(t => t.em)
                .WithMany(t => t.regprograms)
                .HasForeignKey(d => d.em_id);
            this.HasOptional(t => t.project)
                .WithMany(t => t.regprograms)
                .HasForeignKey(d => d.project_id);
            this.HasOptional(t => t.regcomplevel)
                .WithMany(t => t.regprograms)
                .HasForeignKey(d => d.comp_level);
            this.HasOptional(t => t.regcomplevel1)
                .WithMany(t => t.regprograms1)
                .HasForeignKey(d => d.comp_level_calc);
            this.HasOptional(t => t.regprogcat)
                .WithMany(t => t.regprograms)
                .HasForeignKey(d => d.regprog_cat);
            this.HasOptional(t => t.regprogtype)
                .WithMany(t => t.regprograms)
                .HasForeignKey(d => new { d.regprog_cat, d.regprog_type });
            this.HasRequired(t => t.regulation1)
                .WithMany(t => t.regprograms)
                .HasForeignKey(d => d.regulation);
            this.HasOptional(t => t.vn)
                .WithMany(t => t.regprograms)
                .HasForeignKey(d => d.vn_id);

        }
    }
}
