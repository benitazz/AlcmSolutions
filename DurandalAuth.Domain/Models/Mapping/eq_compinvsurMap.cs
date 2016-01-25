using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class eq_compinvsurMap : EntityTypeConfiguration<eq_compinvsur>
    {
        public eq_compinvsurMap()
        {
            // Primary Key
            this.HasKey(t => t.eq_id);

            // Properties
            this.Property(t => t.inv_bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.inv_dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.inv_dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.inv_em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.inv_fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.inv_rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.inv_status)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.sur_bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.sur_dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.sur_dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.sur_em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.sur_fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.sur_rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.sur_status)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.survey_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.difference)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.eq_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("eq_compinvsur", "afm");
            this.Property(t => t.inv_bl_id).HasColumnName("inv_bl_id");
            this.Property(t => t.inv_dp_id).HasColumnName("inv_dp_id");
            this.Property(t => t.inv_dv_id).HasColumnName("inv_dv_id");
            this.Property(t => t.inv_em_id).HasColumnName("inv_em_id");
            this.Property(t => t.inv_fl_id).HasColumnName("inv_fl_id");
            this.Property(t => t.inv_rm_id).HasColumnName("inv_rm_id");
            this.Property(t => t.inv_status).HasColumnName("inv_status");
            this.Property(t => t.sur_bl_id).HasColumnName("sur_bl_id");
            this.Property(t => t.sur_dp_id).HasColumnName("sur_dp_id");
            this.Property(t => t.sur_dv_id).HasColumnName("sur_dv_id");
            this.Property(t => t.sur_em_id).HasColumnName("sur_em_id");
            this.Property(t => t.sur_fl_id).HasColumnName("sur_fl_id");
            this.Property(t => t.sur_rm_id).HasColumnName("sur_rm_id");
            this.Property(t => t.sur_status).HasColumnName("sur_status");
            this.Property(t => t.survey_id).HasColumnName("survey_id");
            this.Property(t => t.difference).HasColumnName("difference");
            this.Property(t => t.eq_id).HasColumnName("eq_id");

            // Relationships
            this.HasOptional(t => t.survey)
                .WithMany(t => t.eq_compinvsur)
                .HasForeignKey(d => d.survey_id);

        }
    }
}
