using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class rrressheetMap : EntityTypeConfiguration<rrressheet>
    {
        public rrressheetMap()
        {
            // Primary Key
            this.HasKey(t => new { t.res_id, t.date_start });

            // Properties
            this.Property(t => t.res_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("rrressheet", "afm");
            this.Property(t => t.res_id).HasColumnName("res_id");
            this.Property(t => t.date_start).HasColumnName("date_start");
        }
    }
}
