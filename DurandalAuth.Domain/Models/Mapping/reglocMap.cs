using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class reglocMap : EntityTypeConfiguration<regloc>
    {
        public reglocMap()
        {
            // Primary Key
            this.HasKey(t => t.location_id);

            // Properties
            this.Property(t => t.comp_level)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.comp_level_calc)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.reg_program)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.reg_requirement)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.regulation)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.resp_person)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.vn_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.location_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("regloc", "afm");
            this.Property(t => t.comp_level).HasColumnName("comp_level");
            this.Property(t => t.comp_level_calc).HasColumnName("comp_level_calc");
            this.Property(t => t.comp_level_number_calc).HasColumnName("comp_level_number_calc");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.event_offset).HasColumnName("event_offset");
            this.Property(t => t.reg_program).HasColumnName("reg_program");
            this.Property(t => t.reg_requirement).HasColumnName("reg_requirement");
            this.Property(t => t.regulation).HasColumnName("regulation");
            this.Property(t => t.resp_person).HasColumnName("resp_person");
            this.Property(t => t.vn_id).HasColumnName("vn_id");
            this.Property(t => t.location_id).HasColumnName("location_id");

            // Relationships
            this.HasRequired(t => t.compliance_locations)
                .WithOptional(t => t.regloc);
            this.HasOptional(t => t.em)
                .WithMany(t => t.reglocs)
                .HasForeignKey(d => d.resp_person);
            this.HasOptional(t => t.regcomplevel)
                .WithMany(t => t.reglocs)
                .HasForeignKey(d => d.comp_level);
            this.HasOptional(t => t.regcomplevel1)
                .WithMany(t => t.reglocs1)
                .HasForeignKey(d => d.comp_level_calc);
            this.HasOptional(t => t.regprogram)
                .WithMany(t => t.reglocs)
                .HasForeignKey(d => new { d.regulation, d.reg_program });
            this.HasOptional(t => t.regrequirement)
                .WithMany(t => t.reglocs)
                .HasForeignKey(d => new { d.regulation, d.reg_program, d.reg_requirement });
            this.HasOptional(t => t.regulation1)
                .WithMany(t => t.reglocs)
                .HasForeignKey(d => d.regulation);
            this.HasOptional(t => t.vn)
                .WithMany(t => t.reglocs)
                .HasForeignKey(d => d.vn_id);

        }
    }
}
