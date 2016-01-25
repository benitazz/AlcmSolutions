using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class bas_data_pointMap : EntityTypeConfiguration<bas_data_point>
    {
        public bas_data_pointMap()
        {
            // Primary Key
            this.HasKey(t => t.data_point_id);

            // Properties
            this.Property(t => t.bill_type_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.bill_unit_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.data_point_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.data_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.description)
                .HasMaxLength(512);

            this.Property(t => t.eq_id)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("bas_data_point", "afm");
            this.Property(t => t.area).HasColumnName("area");
            this.Property(t => t.area_manual).HasColumnName("area_manual");
            this.Property(t => t.bill_type_id).HasColumnName("bill_type_id");
            this.Property(t => t.bill_unit_id).HasColumnName("bill_unit_id");
            this.Property(t => t.data_point_type).HasColumnName("data_point_type");
            this.Property(t => t.data_type).HasColumnName("data_type");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.eq_id).HasColumnName("eq_id");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.sampling_interval).HasColumnName("sampling_interval");
            this.Property(t => t.data_point_id).HasColumnName("data_point_id");

            // Relationships
            this.HasRequired(t => t.bill_type)
                .WithMany(t => t.bas_data_point)
                .HasForeignKey(d => d.bill_type_id);
            this.HasRequired(t => t.bill_unit)
                .WithMany(t => t.bas_data_point)
                .HasForeignKey(d => new { d.bill_type_id, d.bill_unit_id });
            this.HasOptional(t => t.eq)
                .WithMany(t => t.bas_data_point)
                .HasForeignKey(d => d.eq_id);

        }
    }
}
