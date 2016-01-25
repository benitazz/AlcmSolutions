using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class wntypeMap : EntityTypeConfiguration<wntype>
    {
        public wntypeMap()
        {
            // Primary Key
            this.HasKey(t => t.wn_type);

            // Properties
            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.wn_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("wntype", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.wn_type).HasColumnName("wn_type");
        }
    }
}
