using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ehs_em_ppe_typesMap : EntityTypeConfiguration<ehs_em_ppe_types>
    {
        public ehs_em_ppe_typesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.em_id, t.ppe_type_id, t.date_use });

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.doc)
                .IsFixedLength()
                .HasMaxLength(144);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.em_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.ppe_type_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("ehs_em_ppe_types", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.date_delivered).HasColumnName("date_delivered");
            this.Property(t => t.doc).HasColumnName("doc");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.incident_id).HasColumnName("incident_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.ppe_type_id).HasColumnName("ppe_type_id");
            this.Property(t => t.date_use).HasColumnName("date_use");

            // Relationships
            this.HasOptional(t => t.bl)
                .WithMany(t => t.ehs_em_ppe_types)
                .HasForeignKey(d => d.bl_id);
            this.HasRequired(t => t.em)
                .WithMany(t => t.EhsEmPpeTypes)
                .HasForeignKey(d => d.em_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.EhsEmPpeTypes)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.ehs_incidents)
                .WithMany(t => t.ehs_em_ppe_types)
                .HasForeignKey(d => d.incident_id);
            this.HasRequired(t => t.ehs_ppe_types)
                .WithMany(t => t.ehs_em_ppe_types)
                .HasForeignKey(d => d.ppe_type_id);
            this.HasOptional(t => t.rm)
                .WithMany(t => t.ehs_em_ppe_types)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });

        }
    }
}
