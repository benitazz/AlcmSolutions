using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class mo_taMap : EntityTypeConfiguration<mo_ta>
    {
        public mo_taMap()
        {
            // Primary Key
            this.HasKey(t => new { t.mo_id, t.ta_id });

            // Properties
            this.Property(t => t.em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.fn_std)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.from_bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.from_fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.from_rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.mo_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ta_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("mo_ta", "afm");
            this.Property(t => t.cost_moving).HasColumnName("cost_moving");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.fn_std).HasColumnName("fn_std");
            this.Property(t => t.from_bl_id).HasColumnName("from_bl_id");
            this.Property(t => t.from_fl_id).HasColumnName("from_fl_id");
            this.Property(t => t.from_rm_id).HasColumnName("from_rm_id");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.mo_id).HasColumnName("mo_id");
            this.Property(t => t.ta_id).HasColumnName("ta_id");

            // Relationships
            this.HasOptional(t => t.bl)
                .WithMany(t => t.mo_ta)
                .HasForeignKey(d => d.from_bl_id);
            this.HasOptional(t => t.em)
                .WithMany(t => t.mo_ta)
                .HasForeignKey(d => d.em_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.MoTa)
                .HasForeignKey(d => new { d.from_bl_id, d.from_fl_id });
            this.HasOptional(t => t.fnstd)
                .WithMany(t => t.mo_ta)
                .HasForeignKey(d => d.fn_std);
            this.HasRequired(t => t.mo)
                .WithMany(t => t.mo_ta)
                .HasForeignKey(d => d.mo_id);
            this.HasOptional(t => t.rm)
                .WithMany(t => t.mo_ta)
                .HasForeignKey(d => new { d.from_bl_id, d.from_fl_id, d.from_rm_id });
            this.HasRequired(t => t.ta)
                .WithMany(t => t.mo_ta)
                .HasForeignKey(d => d.ta_id);

        }
    }
}
