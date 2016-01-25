using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class grp_useMap : EntityTypeConfiguration<grp_use>
    {
        public grp_useMap()
        {
            // Primary Key
            this.HasKey(t => new { t.grp_type_id, t.grp_use_id });

            // Properties
            this.Property(t => t.grp_use_description)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(100);

            this.Property(t => t.grp_type_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.grp_use_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("grp_use", "afm");
            this.Property(t => t.grp_use_description).HasColumnName("grp_use_description");
            this.Property(t => t.grp_type_id).HasColumnName("grp_type_id");
            this.Property(t => t.grp_use_id).HasColumnName("grp_use_id");

            // Relationships
            this.HasRequired(t => t.grp_type)
                .WithMany(t => t.grp_use)
                .HasForeignKey(d => d.grp_type_id);

        }
    }
}
