using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class rm_arrange_typeMap : EntityTypeConfiguration<rm_arrange_type>
    {
        public rm_arrange_typeMap()
        {
            // Primary Key
            this.HasKey(t => t.rm_arrange_type_id);

            // Properties
            this.Property(t => t.arrange_name)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.tr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.vn_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.rm_arrange_type_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("rm_arrange_type", "afm");
            this.Property(t => t.arrange_name).HasColumnName("arrange_name");
            this.Property(t => t.tr_id).HasColumnName("tr_id");
            this.Property(t => t.vn_id).HasColumnName("vn_id");
            this.Property(t => t.rm_arrange_type_id).HasColumnName("rm_arrange_type_id");

            // Relationships
            this.HasOptional(t => t.tr)
                .WithMany(t => t.rm_arrange_type)
                .HasForeignKey(d => d.tr_id);
            this.HasOptional(t => t.vn)
                .WithMany(t => t.rm_arrange_type)
                .HasForeignKey(d => d.vn_id);

        }
    }
}
