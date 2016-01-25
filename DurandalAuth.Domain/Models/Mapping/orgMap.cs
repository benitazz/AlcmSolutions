using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class orgMap : EntityTypeConfiguration<org>
    {
        public orgMap()
        {
            // Primary Key
            this.HasKey(t => t.org_id);

            // Properties
            this.Property(t => t.ac_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.contact_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.description)
                .HasMaxLength(250);

            this.Property(t => t.hierarchy_ids)
                .HasMaxLength(500);

            this.Property(t => t.hpattern)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.hpattern_acad)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.org_name)
                .HasMaxLength(64);

            this.Property(t => t.org_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("org", "afm");
            this.Property(t => t.ac_id).HasColumnName("ac_id");
            this.Property(t => t.contact_id).HasColumnName("contact_id");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.hierarchy_ids).HasColumnName("hierarchy_ids");
            this.Property(t => t.hpattern).HasColumnName("hpattern");
            this.Property(t => t.hpattern_acad).HasColumnName("hpattern_acad");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.org_name).HasColumnName("org_name");
            this.Property(t => t.org_id).HasColumnName("org_id");

            // Relationships
            this.HasOptional(t => t.ac)
                .WithMany(t => t.orgs)
                .HasForeignKey(d => d.ac_id);
            this.HasOptional(t => t.contact)
                .WithMany(t => t.Orgs)
                .HasForeignKey(d => d.contact_id);

        }
    }
}
