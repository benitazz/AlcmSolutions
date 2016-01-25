using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class grp_typeMap : EntityTypeConfiguration<grp_type>
    {
        public grp_typeMap()
        {
            // Primary Key
            this.HasKey(t => t.grp_type_id);

            // Properties
            this.Property(t => t.grp_type_description)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.grp_type_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("grp_type", "afm");
            this.Property(t => t.grp_type_description).HasColumnName("grp_type_description");
            this.Property(t => t.grp_type_id).HasColumnName("grp_type_id");
        }
    }
}
