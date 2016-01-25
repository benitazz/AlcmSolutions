using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class regcomplianceMap : EntityTypeConfiguration<regcompliance>
    {
        public regcomplianceMap()
        {
            // Primary Key
            this.HasKey(t => t.regcomp_id);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.comp_action)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.comp_status_orig)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.comp_status_res)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.contact_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.dwgname)
                .HasMaxLength(128);

            this.Property(t => t.ehandle)
                .HasMaxLength(64);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.pr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.regulation)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("regcompliance", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.comp_action).HasColumnName("comp_action");
            this.Property(t => t.comp_status_orig).HasColumnName("comp_status_orig");
            this.Property(t => t.comp_status_res).HasColumnName("comp_status_res");
            this.Property(t => t.contact_id).HasColumnName("contact_id");
            this.Property(t => t.date_logged).HasColumnName("date_logged");
            this.Property(t => t.date_resolved).HasColumnName("date_resolved");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.dwgname).HasColumnName("dwgname");
            this.Property(t => t.ehandle).HasColumnName("ehandle");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.pr_id).HasColumnName("pr_id");
            this.Property(t => t.regulation).HasColumnName("regulation");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.regcomp_id).HasColumnName("regcomp_id");

            // Relationships
            this.HasOptional(t => t.bl)
                .WithMany(t => t.regcompliances)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.contact)
                .WithMany(t => t.Regcompliances)
                .HasForeignKey(d => d.contact_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.Regcompliances)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.property)
                .WithMany(t => t.regcompliances)
                .HasForeignKey(d => d.pr_id);
            this.HasOptional(t => t.regulation1)
                .WithMany(t => t.regcompliances)
                .HasForeignKey(d => d.regulation);
            this.HasOptional(t => t.rm)
                .WithMany(t => t.regcompliances)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });

        }
    }
}
