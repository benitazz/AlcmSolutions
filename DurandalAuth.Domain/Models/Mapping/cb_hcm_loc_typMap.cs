using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class cb_hcm_loc_typMap : EntityTypeConfiguration<cb_hcm_loc_typ>
    {
        public cb_hcm_loc_typMap()
        {
            // Primary Key
            this.HasKey(t => t.hcm_loc_typ_id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(512);

            this.Property(t => t.name)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.prob_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.hcm_loc_typ_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("cb_hcm_loc_typ", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.prob_type).HasColumnName("prob_type");
            this.Property(t => t.hcm_loc_typ_id).HasColumnName("hcm_loc_typ_id");

            // Relationships
            this.HasOptional(t => t.probtype)
                .WithMany(t => t.cb_hcm_loc_typ)
                .HasForeignKey(d => d.prob_type);

        }
    }
}
