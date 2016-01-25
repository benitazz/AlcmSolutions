using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ls_clause_typeMap : EntityTypeConfiguration<ls_clause_type>
    {
        public ls_clause_typeMap()
        {
            // Primary Key
            this.HasKey(t => t.clause_type_id);

            // Properties
            this.Property(t => t.clause_type_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("ls_clause_type", "afm");
            this.Property(t => t.clause_type_id).HasColumnName("clause_type_id");
        }
    }
}
