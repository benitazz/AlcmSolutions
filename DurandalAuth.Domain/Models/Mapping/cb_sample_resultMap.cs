using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class cb_sample_resultMap : EntityTypeConfiguration<cb_sample_result>
    {
        public cb_sample_resultMap()
        {
            // Primary Key
            this.HasKey(t => t.result_id);

            // Properties
            this.Property(t => t.cb_units_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.qualifier)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.sample_comp_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("cb_sample_result", "afm");
            this.Property(t => t.cb_units_id).HasColumnName("cb_units_id");
            this.Property(t => t.qualifier).HasColumnName("qualifier");
            this.Property(t => t.result_1).HasColumnName("result_1");
            this.Property(t => t.result_2).HasColumnName("result_2");
            this.Property(t => t.sample_comp_id).HasColumnName("sample_comp_id");
            this.Property(t => t.sample_id).HasColumnName("sample_id");
            this.Property(t => t.result_id).HasColumnName("result_id");

            // Relationships
            this.HasRequired(t => t.cb_sample_comp)
                .WithMany(t => t.cb_sample_result)
                .HasForeignKey(d => d.sample_comp_id);
            this.HasRequired(t => t.cb_units)
                .WithMany(t => t.cb_sample_result)
                .HasForeignKey(d => d.cb_units_id);
            this.HasRequired(t => t.cb_samples)
                .WithMany(t => t.cb_sample_result)
                .HasForeignKey(d => d.sample_id);

        }
    }
}
