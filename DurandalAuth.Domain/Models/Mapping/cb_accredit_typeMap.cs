using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class cb_accredit_typeMap : EntityTypeConfiguration<cb_accredit_type>
    {
        public cb_accredit_typeMap()
        {
            // Primary Key
            this.HasKey(t => t.accredit_type_id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(512);

            this.Property(t => t.name)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.prob_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.accredit_type_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("cb_accredit_type", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.prob_type).HasColumnName("prob_type");
            this.Property(t => t.accredit_type_id).HasColumnName("accredit_type_id");

            // Relationships
            this.HasOptional(t => t.probtype)
                .WithMany(t => t.cb_accredit_type)
                .HasForeignKey(d => d.prob_type);

        }
    }
}
