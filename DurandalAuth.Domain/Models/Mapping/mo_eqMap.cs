using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class mo_eqMap : EntityTypeConfiguration<mo_eq>
    {
        public mo_eqMap()
        {
            // Primary Key
            this.HasKey(t => new { t.mo_id, t.eq_id });

            // Properties
            this.Property(t => t.eq_new_jk_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.eq_std)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.eq_trace)
                .HasMaxLength(2000);

            this.Property(t => t.from_bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.from_fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.from_rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.mo_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.eq_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("mo_eq", "afm");
            this.Property(t => t.eq_new_jk_id).HasColumnName("eq_new_jk_id");
            this.Property(t => t.eq_std).HasColumnName("eq_std");
            this.Property(t => t.eq_trace).HasColumnName("eq_trace");
            this.Property(t => t.from_bl_id).HasColumnName("from_bl_id");
            this.Property(t => t.from_fl_id).HasColumnName("from_fl_id");
            this.Property(t => t.from_rm_id).HasColumnName("from_rm_id");
            this.Property(t => t.cost_moving).HasColumnName("cost_moving");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.mo_id).HasColumnName("mo_id");
            this.Property(t => t.eq_id).HasColumnName("eq_id");

            // Relationships
            this.HasOptional(t => t.bl)
                .WithMany(t => t.mo_eq)
                .HasForeignKey(d => d.from_bl_id);
            this.HasOptional(t => t.em)
                .WithMany(t => t.mo_eq)
                .HasForeignKey(d => d.em_id);
            this.HasRequired(t => t.eq)
                .WithMany(t => t.mo_eq)
                .HasForeignKey(d => d.eq_id);
            this.HasOptional(t => t.eqstd)
                .WithMany(t => t.mo_eq)
                .HasForeignKey(d => d.eq_std);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.MoEq)
                .HasForeignKey(d => new { d.from_bl_id, d.from_fl_id });
            this.HasOptional(t => t.jk)
                .WithMany(t => t.mo_eq)
                .HasForeignKey(d => d.eq_new_jk_id);
            this.HasRequired(t => t.mo)
                .WithMany(t => t.mo_eq)
                .HasForeignKey(d => d.mo_id);
            this.HasOptional(t => t.rm)
                .WithMany(t => t.mo_eq)
                .HasForeignKey(d => new { d.from_bl_id, d.from_fl_id, d.from_rm_id });

        }
    }
}
