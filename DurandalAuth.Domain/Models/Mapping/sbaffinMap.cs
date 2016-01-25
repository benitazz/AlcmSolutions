using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class sbaffinMap : EntityTypeConfiguration<sbaffin>
    {
        public sbaffinMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.bu_id_1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.bu_id_2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dp_id_1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dp_id_2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dv_id_1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dv_id_2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.fg_title_1)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.fg_title_2)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.sb_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("sbaffin", "afm");
            this.Property(t => t.bu_id_1).HasColumnName("bu_id_1");
            this.Property(t => t.bu_id_2).HasColumnName("bu_id_2");
            this.Property(t => t.dp_id_1).HasColumnName("dp_id_1");
            this.Property(t => t.dp_id_2).HasColumnName("dp_id_2");
            this.Property(t => t.dv_id_1).HasColumnName("dv_id_1");
            this.Property(t => t.dv_id_2).HasColumnName("dv_id_2");
            this.Property(t => t.fg_title_1).HasColumnName("fg_title_1");
            this.Property(t => t.fg_title_2).HasColumnName("fg_title_2");
            this.Property(t => t.sb_name).HasColumnName("sb_name");
            this.Property(t => t.affinity).HasColumnName("affinity");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasOptional(t => t.bu)
                .WithMany(t => t.sbaffins)
                .HasForeignKey(d => d.bu_id_1);
            this.HasOptional(t => t.bu1)
                .WithMany(t => t.sbaffins1)
                .HasForeignKey(d => d.bu_id_2);
            this.HasOptional(t => t.dp)
                .WithMany(t => t.sbaffins)
                .HasForeignKey(d => new { d.dv_id_1, d.dp_id_1 });
            this.HasOptional(t => t.dp1)
                .WithMany(t => t.sbaffins1)
                .HasForeignKey(d => new { d.dv_id_2, d.dp_id_2 });
            this.HasOptional(t => t.dv)
                .WithMany(t => t.sbaffins)
                .HasForeignKey(d => d.dv_id_1);
            this.HasOptional(t => t.dv1)
                .WithMany(t => t.sbaffins1)
                .HasForeignKey(d => d.dv_id_2);
            this.HasRequired(t => t.sb)
                .WithMany(t => t.sbaffins)
                .HasForeignKey(d => d.sb_name);

        }
    }
}
