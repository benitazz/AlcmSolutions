using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class regulationMap : EntityTypeConfiguration<regulation>
    {
        public regulationMap()
        {
            // Primary Key
            this.HasKey(t => t.regulation1);

            // Properties
            this.Property(t => t.authority)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.citation)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.hierarchy_ids)
                .HasMaxLength(500);

            this.Property(t => t.hpattern)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.hpattern_acad)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.legal_refs)
                .HasMaxLength(2000);

            this.Property(t => t.reg_cat)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.reg_category)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.reg_class)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.reg_name)
                .IsFixedLength()
                .HasMaxLength(96);

            this.Property(t => t.reg_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.related_reg)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.web_ref1)
                .HasMaxLength(256);

            this.Property(t => t.website)
                .HasMaxLength(256);

            this.Property(t => t.regulation1)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("regulation", "afm");
            this.Property(t => t.authority).HasColumnName("authority");
            this.Property(t => t.citation).HasColumnName("citation");
            this.Property(t => t.date_compliance).HasColumnName("date_compliance");
            this.Property(t => t.date_end).HasColumnName("date_end");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.hierarchy_ids).HasColumnName("hierarchy_ids");
            this.Property(t => t.hpattern).HasColumnName("hpattern");
            this.Property(t => t.hpattern_acad).HasColumnName("hpattern_acad");
            this.Property(t => t.legal_refs).HasColumnName("legal_refs");
            this.Property(t => t.reg_cat).HasColumnName("reg_cat");
            this.Property(t => t.reg_category).HasColumnName("reg_category");
            this.Property(t => t.reg_class).HasColumnName("reg_class");
            this.Property(t => t.reg_name).HasColumnName("reg_name");
            this.Property(t => t.reg_rank).HasColumnName("reg_rank");
            this.Property(t => t.reg_type).HasColumnName("reg_type");
            this.Property(t => t.related_reg).HasColumnName("related_reg");
            this.Property(t => t.web_ref1).HasColumnName("web_ref1");
            this.Property(t => t.website).HasColumnName("website");
            this.Property(t => t.regulation1).HasColumnName("regulation");

            // Relationships
            this.HasOptional(t => t.company)
                .WithMany(t => t.Regulations)
                .HasForeignKey(d => d.authority);
            this.HasOptional(t => t.regcat)
                .WithMany(t => t.regulations)
                .HasForeignKey(d => d.reg_cat);
            this.HasOptional(t => t.regtype)
                .WithMany(t => t.regulations)
                .HasForeignKey(d => new { d.reg_cat, d.reg_type });

        }
    }
}
