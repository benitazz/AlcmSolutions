using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class runoffareaMap : EntityTypeConfiguration<runoffarea>
    {
        public runoffareaMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.comments)
                .IsFixedLength()
                .HasMaxLength(256);

            this.Property(t => t.dwgname)
                .HasMaxLength(128);

            this.Property(t => t.ehandle)
                .HasMaxLength(64);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.pr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.runoff_type)
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("runoffarea", "afm");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.dwgname).HasColumnName("dwgname");
            this.Property(t => t.ehandle).HasColumnName("ehandle");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.pr_id).HasColumnName("pr_id");
            this.Property(t => t.runoff_type).HasColumnName("runoff_type");
            this.Property(t => t.area_cad).HasColumnName("area_cad");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasOptional(t => t.property)
                .WithMany(t => t.runoffareas)
                .HasForeignKey(d => d.pr_id);
            this.HasOptional(t => t.runofftype)
                .WithMany(t => t.runoffareas)
                .HasForeignKey(d => d.runoff_type);

        }
    }
}
