using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class cost_classMap : EntityTypeConfiguration<cost_class>
    {
        public cost_classMap()
        {
            // Primary Key
            this.HasKey(t => t.cost_class_id);

            // Properties
            this.Property(t => t.cost_super_class)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.cost_class_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("cost_class", "afm");
            this.Property(t => t.cost_super_class).HasColumnName("cost_super_class");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.cost_class_id).HasColumnName("cost_class_id");
        }
    }
}
