using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class projteamMap : EntityTypeConfiguration<ProjectTeam>
    {
        public projteamMap()
        {
            // Primary Key
            this.HasKey(t => new { t.project_id, t.member_id });

            // Properties
            this.Property(t => t.address1)
                .HasMaxLength(64);

            this.Property(t => t.address2)
                .HasMaxLength(64);

            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.city_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.company)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.county_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.ctry_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.email)
                .HasMaxLength(64);

            this.Property(t => t.fax)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.honorific)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.image_file)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.member_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.name_first)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.name_last)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.notes)
                .HasMaxLength(2000);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.pager)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.phone)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.regn_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.source_table)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.state_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.zip)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.project_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.member_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("projteam", "afm");
            this.Property(t => t.address1).HasColumnName("address1");
            this.Property(t => t.address2).HasColumnName("address2");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.city_id).HasColumnName("city_id");
            this.Property(t => t.company).HasColumnName("company");
            this.Property(t => t.county_id).HasColumnName("county_id");
            this.Property(t => t.ctry_id).HasColumnName("ctry_id");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.fax).HasColumnName("fax");
            this.Property(t => t.honorific).HasColumnName("honorific");
            this.Property(t => t.image_file).HasColumnName("image_file");
            this.Property(t => t.member_type).HasColumnName("member_type");
            this.Property(t => t.name_first).HasColumnName("name_first");
            this.Property(t => t.name_last).HasColumnName("name_last");
            this.Property(t => t.notes).HasColumnName("notes");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.pager).HasColumnName("pager");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.regn_id).HasColumnName("regn_id");
            this.Property(t => t.source_table).HasColumnName("source_table");
            this.Property(t => t.state_id).HasColumnName("state_id");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.zip).HasColumnName("zip");
            this.Property(t => t.project_id).HasColumnName("project_id");
            this.Property(t => t.member_id).HasColumnName("member_id");

            // Relationships
            this.HasOptional(t => t.afm_tbls)
                .WithMany(t => t.projteams)
                .HasForeignKey(d => d.source_table);
            this.HasOptional(t => t.bl)
                .WithMany(t => t.projteams)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.city)
                .WithMany(t => t.Projteams)
                .HasForeignKey(d => new { d.state_id, d.city_id });
            this.HasOptional(t => t.company1)
                .WithMany(t => t.Projteams)
                .HasForeignKey(d => d.company);
            this.HasOptional(t => t.county)
                .WithMany(t => t.ProjectTeams)
                .HasForeignKey(d => new { d.state_id, d.county_id });
            this.HasOptional(t => t.ctry)
                .WithMany(t => t.projteams)
                .HasForeignKey(d => d.ctry_id);
            this.HasRequired(t => t.project)
                .WithMany(t => t.projteams)
                .HasForeignKey(d => d.project_id);
            this.HasOptional(t => t.regn)
                .WithMany(t => t.Projteams)
                .HasForeignKey(d => new { d.ctry_id, d.regn_id });
            this.HasOptional(t => t.state)
                .WithMany(t => t.projteams)
                .HasForeignKey(d => d.state_id);

        }
    }
}
