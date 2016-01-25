using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_redlinesMap : EntityTypeConfiguration<afm_redlines>
    {
        public afm_redlinesMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.comments)
                .HasMaxLength(1000);

            this.Property(t => t.dwg_name)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.highlightds)
                .IsFixedLength()
                .HasMaxLength(60);

            this.Property(t => t.highlightds_view_name)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.labelds)
                .IsFixedLength()
                .HasMaxLength(60);

            this.Property(t => t.labelds_view_name)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.redlines)
                .HasMaxLength(2000);

            this.Property(t => t.user_name)
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("afm_redlines", "afm");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.date_created).HasColumnName("date_created");
            this.Property(t => t.dwg_name).HasColumnName("dwg_name");
            this.Property(t => t.highlightds).HasColumnName("highlightds");
            this.Property(t => t.highlightds_view_name).HasColumnName("highlightds_view_name");
            this.Property(t => t.labelds).HasColumnName("labelds");
            this.Property(t => t.labelds_view_name).HasColumnName("labelds_view_name");
            this.Property(t => t.position_lux).HasColumnName("position_lux");
            this.Property(t => t.position_luy).HasColumnName("position_luy");
            this.Property(t => t.position_rlx).HasColumnName("position_rlx");
            this.Property(t => t.position_rly).HasColumnName("position_rly");
            this.Property(t => t.redlines).HasColumnName("redlines");
            this.Property(t => t.time_created).HasColumnName("time_created");
            this.Property(t => t.user_name).HasColumnName("user_name");
            this.Property(t => t.activity_log_id).HasColumnName("activity_log_id");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasRequired(t => t.afm_dwgs)
                .WithMany(t => t.afm_redlines)
                .HasForeignKey(d => d.dwg_name);
            this.HasOptional(t => t.afm_users)
                .WithMany(t => t.afm_redlines)
                .HasForeignKey(d => d.user_name);

        }
    }
}
