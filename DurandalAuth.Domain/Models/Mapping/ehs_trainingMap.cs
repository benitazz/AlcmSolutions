using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ehs_trainingMap : EntityTypeConfiguration<ehs_training>
    {
        public ehs_trainingMap()
        {
            // Primary Key
            this.HasKey(t => t.training_id);

            // Properties
            this.Property(t => t.chemical_name)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.comments)
                .HasMaxLength(300);

            this.Property(t => t.description)
                .HasMaxLength(500);

            this.Property(t => t.doc)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.eq_std)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.ppe_type_id)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.recurring_rule)
                .HasMaxLength(5000);

            this.Property(t => t.reg_program)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.reg_requirement)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.regulation)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.requirements_description)
                .HasMaxLength(500);

            this.Property(t => t.training_category_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.training_name)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.training_type_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.vn_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.training_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("ehs_training", "afm");
            this.Property(t => t.chemical_name).HasColumnName("chemical_name");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.date_recurrence_end).HasColumnName("date_recurrence_end");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.doc).HasColumnName("doc");
            this.Property(t => t.eq_std).HasColumnName("eq_std");
            this.Property(t => t.hours_training).HasColumnName("hours_training");
            this.Property(t => t.needs_refresh).HasColumnName("needs_refresh");
            this.Property(t => t.ppe_type_id).HasColumnName("ppe_type_id");
            this.Property(t => t.recurring_rule).HasColumnName("recurring_rule");
            this.Property(t => t.reg_program).HasColumnName("reg_program");
            this.Property(t => t.reg_requirement).HasColumnName("reg_requirement");
            this.Property(t => t.regulation).HasColumnName("regulation");
            this.Property(t => t.requirements_description).HasColumnName("requirements_description");
            this.Property(t => t.training_category_id).HasColumnName("training_category_id");
            this.Property(t => t.training_name).HasColumnName("training_name");
            this.Property(t => t.training_type_id).HasColumnName("training_type_id");
            this.Property(t => t.vn_id).HasColumnName("vn_id");
            this.Property(t => t.training_id).HasColumnName("training_id");

            // Relationships
            this.HasMany(t => t.work_categories)
                .WithMany(t => t.ehs_training)
                .Map(m =>
                    {
                        m.ToTable("ehs_work_cat_training", "afm");
                        m.MapLeftKey("training_id");
                        m.MapRightKey("work_category_id");
                    });

            this.HasOptional(t => t.ehs_chemicals)
                .WithMany(t => t.ehs_training)
                .HasForeignKey(d => d.chemical_name);
            this.HasOptional(t => t.ehs_ppe_types)
                .WithMany(t => t.ehs_training)
                .HasForeignKey(d => d.ppe_type_id);
            this.HasOptional(t => t.eqstd)
                .WithMany(t => t.ehs_training)
                .HasForeignKey(d => d.eq_std);
            this.HasOptional(t => t.regprogram)
                .WithMany(t => t.ehs_training)
                .HasForeignKey(d => new { d.regulation, d.reg_program });
            this.HasOptional(t => t.regrequirement)
                .WithMany(t => t.ehs_training)
                .HasForeignKey(d => new { d.regulation, d.reg_program, d.reg_requirement });
            this.HasOptional(t => t.regulation1)
                .WithMany(t => t.ehs_training)
                .HasForeignKey(d => d.regulation);
            this.HasRequired(t => t.ehs_training_cat)
                .WithMany(t => t.ehs_training)
                .HasForeignKey(d => d.training_category_id);
            this.HasRequired(t => t.ehs_training_types)
                .WithMany(t => t.ehs_training)
                .HasForeignKey(d => d.training_type_id);
            this.HasOptional(t => t.vn)
                .WithMany(t => t.ehs_training)
                .HasForeignKey(d => d.vn_id);

        }
    }
}
