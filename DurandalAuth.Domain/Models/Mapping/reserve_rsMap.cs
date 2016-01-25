using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class reserve_rsMap : EntityTypeConfiguration<reserve_rs>
    {
        public reserve_rsMap()
        {
            // Primary Key
            this.HasKey(t => t.rsres_id);

            // Properties
            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.comments)
                .HasMaxLength(2000);

            this.Property(t => t.fl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.resource_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.rm_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.user_last_modified_by)
                .IsFixedLength()
                .HasMaxLength(35);

            // Table & Column Mappings
            this.ToTable("reserve_rs", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.cost_rsres).HasColumnName("cost_rsres");
            this.Property(t => t.date_cancelled).HasColumnName("date_cancelled");
            this.Property(t => t.date_created).HasColumnName("date_created");
            this.Property(t => t.date_last_modified).HasColumnName("date_last_modified");
            this.Property(t => t.date_rejected).HasColumnName("date_rejected");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.quantity).HasColumnName("quantity");
            this.Property(t => t.recurring_order).HasColumnName("recurring_order");
            this.Property(t => t.res_id).HasColumnName("res_id");
            this.Property(t => t.resource_id).HasColumnName("resource_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.time_end).HasColumnName("time_end");
            this.Property(t => t.time_start).HasColumnName("time_start");
            this.Property(t => t.user_last_modified_by).HasColumnName("user_last_modified_by");
            this.Property(t => t.rsres_id).HasColumnName("rsres_id");

            // Relationships
            this.HasRequired(t => t.bl)
                .WithMany(t => t.reserve_rs)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.em)
                .WithMany(t => t.reserve_rs)
                .HasForeignKey(d => d.user_last_modified_by);
            this.HasRequired(t => t.fl)
                .WithMany(t => t.ReserveRs)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasRequired(t => t.reserve)
                .WithMany(t => t.reserve_rs)
                .HasForeignKey(d => d.res_id);
            this.HasRequired(t => t.resource)
                .WithMany(t => t.reserve_rs)
                .HasForeignKey(d => d.resource_id);
            this.HasRequired(t => t.rm)
                .WithMany(t => t.reserve_rs)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });

        }
    }
}
