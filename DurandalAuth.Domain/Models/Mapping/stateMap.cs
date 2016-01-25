using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class stateMap : EntityTypeConfiguration<state>
    {
        public stateMap()
        {
            // Primary Key
            this.HasKey(t => t.state_id);

            // Properties
            this.Property(t => t.ctry_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.detail_dwg)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.dwgname)
                .HasMaxLength(128);

            this.Property(t => t.ehandle)
                .HasMaxLength(64);

            this.Property(t => t.name)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.regn_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.state_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("state", "afm");
            this.Property(t => t.ctry_id).HasColumnName("ctry_id");
            this.Property(t => t.detail_dwg).HasColumnName("detail_dwg");
            this.Property(t => t.dwgname).HasColumnName("dwgname");
            this.Property(t => t.ehandle).HasColumnName("ehandle");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.regn_id).HasColumnName("regn_id");
            this.Property(t => t.state_id).HasColumnName("state_id");

            // Relationships
            this.HasOptional(t => t.ctry)
                .WithMany(t => t.states)
                .HasForeignKey(d => d.ctry_id);
            this.HasOptional(t => t.regn)
                .WithMany(t => t.States)
                .HasForeignKey(d => new { d.ctry_id, d.regn_id });

        }
    }
}
