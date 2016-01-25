using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ls_comm_logMap : EntityTypeConfiguration<ls_comm_log>
    {
        public ls_comm_logMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ls_comm_id, t.user_name });

            // Properties
            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.ls_comm_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.user_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("ls_comm_log", "afm");
            this.Property(t => t.date_stat_chgd).HasColumnName("date_stat_chgd");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.time_stat_chgd).HasColumnName("time_stat_chgd");
            this.Property(t => t.ls_comm_id).HasColumnName("ls_comm_id");
            this.Property(t => t.user_name).HasColumnName("user_name");

            // Relationships
            this.HasRequired(t => t.afm_users)
                .WithMany(t => t.ls_comm_log)
                .HasForeignKey(d => d.user_name);
            this.HasRequired(t => t.ls_comm)
                .WithMany(t => t.ls_comm_log)
                .HasForeignKey(d => d.ls_comm_id);

        }
    }
}
