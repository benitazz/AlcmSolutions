using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class system_depMap : EntityTypeConfiguration<system_dep>
    {
        public system_depMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.system_id_depend)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.system_id_master)
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("system_dep", "afm");
            this.Property(t => t.propagate_status).HasColumnName("propagate_status");
            this.Property(t => t.system_id_depend).HasColumnName("system_id_depend");
            this.Property(t => t.system_id_master).HasColumnName("system_id_master");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasOptional(t => t.system_bl)
                .WithMany(t => t.system_dep)
                .HasForeignKey(d => d.system_id_depend);
            this.HasOptional(t => t.system_bl1)
                .WithMany(t => t.system_dep1)
                .HasForeignKey(d => d.system_id_master);

        }
    }
}
