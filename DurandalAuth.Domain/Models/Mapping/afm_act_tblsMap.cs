using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_act_tblsMap : EntityTypeConfiguration<afm_act_tbls>
    {
        public afm_act_tblsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.activity_id, t.table_name });

            // Properties
            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.activity_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.table_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("afm_act_tbls", "afm");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.activity_id).HasColumnName("activity_id");
            this.Property(t => t.table_name).HasColumnName("table_name");

            // Relationships
            this.HasRequired(t => t.afm_activities)
                .WithMany(t => t.afm_act_tbls)
                .HasForeignKey(d => d.activity_id);
            this.HasRequired(t => t.afm_tbls)
                .WithMany(t => t.afm_act_tbls)
                .HasForeignKey(d => d.table_name);

        }
    }
}
