using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class mo_fncountMap : EntityTypeConfiguration<mo_fncount>
    {
        public mo_fncountMap()
        {
            // Primary Key
            this.HasKey(t => new { t.mo_id, t.fn_std, t.from_bl_id, t.from_fl_id, t.from_rm_id });

            // Properties
            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.mo_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.fn_std)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.from_bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.from_fl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.from_rm_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("mo_fncount", "afm");
            this.Property(t => t.cost_moving).HasColumnName("cost_moving");
            this.Property(t => t.fn_count).HasColumnName("fn_count");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.mo_id).HasColumnName("mo_id");
            this.Property(t => t.fn_std).HasColumnName("fn_std");
            this.Property(t => t.from_bl_id).HasColumnName("from_bl_id");
            this.Property(t => t.from_fl_id).HasColumnName("from_fl_id");
            this.Property(t => t.from_rm_id).HasColumnName("from_rm_id");

            // Relationships
            this.HasRequired(t => t.bl)
                .WithMany(t => t.mo_fncount)
                .HasForeignKey(d => d.from_bl_id);
            this.HasRequired(t => t.fl)
                .WithMany(t => t.MoFncount)
                .HasForeignKey(d => new { d.from_bl_id, d.from_fl_id });
            this.HasRequired(t => t.fnstd)
                .WithMany(t => t.mo_fncount)
                .HasForeignKey(d => d.fn_std);
            this.HasRequired(t => t.mo)
                .WithMany(t => t.mo_fncount)
                .HasForeignKey(d => d.mo_id);
            this.HasRequired(t => t.rm)
                .WithMany(t => t.mo_fncount)
                .HasForeignKey(d => new { d.from_bl_id, d.from_fl_id, d.from_rm_id });

        }
    }
}
