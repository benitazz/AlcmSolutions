using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class fn_comptrialtrialMap : EntityTypeConfiguration<fn_comptrialtrial>
    {
        public fn_comptrialtrialMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.dwgnames1)
                .HasMaxLength(128);

            this.Property(t => t.dwgnames2)
                .HasMaxLength(128);

            this.Property(t => t.fn_std)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.layers1)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.layers2)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.trial_project_id1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.trial_project_id2)
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("fn_comptrialtrial", "afm");
            this.Property(t => t.count_trial1).HasColumnName("count_trial1");
            this.Property(t => t.count_trial2).HasColumnName("count_trial2");
            this.Property(t => t.dwgnames1).HasColumnName("dwgnames1");
            this.Property(t => t.dwgnames2).HasColumnName("dwgnames2");
            this.Property(t => t.fn_std).HasColumnName("fn_std");
            this.Property(t => t.layers1).HasColumnName("layers1");
            this.Property(t => t.layers2).HasColumnName("layers2");
            this.Property(t => t.trial_project_id1).HasColumnName("trial_project_id1");
            this.Property(t => t.trial_project_id2).HasColumnName("trial_project_id2");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasOptional(t => t.fnstd)
                .WithMany(t => t.fn_comptrialtrial)
                .HasForeignKey(d => d.fn_std);
            this.HasOptional(t => t.trialproject)
                .WithMany(t => t.fn_comptrialtrial)
                .HasForeignKey(d => d.trial_project_id1);
            this.HasOptional(t => t.trialproject1)
                .WithMany(t => t.fn_comptrialtrial1)
                .HasForeignKey(d => d.trial_project_id2);

        }
    }
}
