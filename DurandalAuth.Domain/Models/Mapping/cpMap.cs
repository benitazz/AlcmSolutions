using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class cpMap : EntityTypeConfiguration<cp>
    {
        public cpMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ca_id, t.cp_id });

            // Properties
            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.tc_level)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.tc_use_status)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.ca_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.cp_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("cp", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.tc_level).HasColumnName("tc_level");
            this.Property(t => t.tc_use_status).HasColumnName("tc_use_status");
            this.Property(t => t.ca_id).HasColumnName("ca_id");
            this.Property(t => t.cp_id).HasColumnName("cp_id");

            // Relationships
            this.HasOptional(t => t.afm_tclevel)
                .WithMany(t => t.cps)
                .HasForeignKey(d => d.tc_level);
            this.HasRequired(t => t.ca)
                .WithMany(t => t.cps)
                .HasForeignKey(d => d.ca_id);

        }
    }
}
