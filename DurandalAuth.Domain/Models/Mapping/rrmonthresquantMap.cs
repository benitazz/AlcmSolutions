using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class rrmonthresquantMap : EntityTypeConfiguration<rrmonthresquant>
    {
        public rrmonthresquantMap()
        {
            // Primary Key
            this.HasKey(t => new { t.total_quantity, t.resource_id, t.status, t.time_start, t.time_end, t.bl_id, t.date_start, t.rsres_id, t.res_id });

            // Properties
            this.Property(t => t.monthtxt)
                .HasMaxLength(8);

            this.Property(t => t.total_quantity)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.resource_name)
                .HasMaxLength(65);

            this.Property(t => t.resource_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.ctry_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.rsres_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.res_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.resource_std)
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("rrmonthresquant", "afm");
            this.Property(t => t.monthtxt).HasColumnName("monthtxt");
            this.Property(t => t.total_quantity).HasColumnName("total_quantity");
            this.Property(t => t.resource_name).HasColumnName("resource_name");
            this.Property(t => t.resource_id).HasColumnName("resource_id");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.time_start).HasColumnName("time_start");
            this.Property(t => t.time_end).HasColumnName("time_end");
            this.Property(t => t.ctry_id).HasColumnName("ctry_id");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.rsres_id).HasColumnName("rsres_id");
            this.Property(t => t.res_id).HasColumnName("res_id");
            this.Property(t => t.resource_std).HasColumnName("resource_std");
        }
    }
}
