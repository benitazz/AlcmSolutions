using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class fn_compinvtrialMap : EntityTypeConfiguration<fn_compinvtrial>
    {
        public fn_compinvtrialMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.dwgnames)
                .HasMaxLength(128);

            this.Property(t => t.fn_std)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.layers)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.trial_project_id)
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("fn_compinvtrial", "afm");
            this.Property(t => t.count_inv).HasColumnName("count_inv");
            this.Property(t => t.count_stor).HasColumnName("count_stor");
            this.Property(t => t.count_to_move_from_inv).HasColumnName("count_to_move_from_inv");
            this.Property(t => t.count_to_move_from_stor).HasColumnName("count_to_move_from_stor");
            this.Property(t => t.count_to_move_to_stor).HasColumnName("count_to_move_to_stor");
            this.Property(t => t.count_to_order).HasColumnName("count_to_order");
            this.Property(t => t.count_trial).HasColumnName("count_trial");
            this.Property(t => t.dwgnames).HasColumnName("dwgnames");
            this.Property(t => t.fn_std).HasColumnName("fn_std");
            this.Property(t => t.layers).HasColumnName("layers");
            this.Property(t => t.trial_project_id).HasColumnName("trial_project_id");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasOptional(t => t.fnstd)
                .WithMany(t => t.fn_compinvtrial)
                .HasForeignKey(d => d.fn_std);

        }
    }
}
