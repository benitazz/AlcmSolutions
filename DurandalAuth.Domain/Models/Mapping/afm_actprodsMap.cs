using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_actprodsMap : EntityTypeConfiguration<afm_actprods>
    {
        public afm_actprodsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.product_id, t.activity_id });

            // Properties
            this.Property(t => t.activity_cat_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.comments)
                .HasMaxLength(256);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.product_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.activity_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("afm_actprods", "afm");
            this.Property(t => t.activity_cat_id).HasColumnName("activity_cat_id");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.product_id).HasColumnName("product_id");
            this.Property(t => t.activity_id).HasColumnName("activity_id");

            // Relationships
            this.HasRequired(t => t.afm_activities)
                .WithMany(t => t.afm_actprods)
                .HasForeignKey(d => d.activity_id);
            this.HasRequired(t => t.afm_activity_cats)
                .WithMany(t => t.afm_actprods)
                .HasForeignKey(d => d.activity_cat_id);
            this.HasRequired(t => t.afm_products)
                .WithMany(t => t.afm_actprods)
                .HasForeignKey(d => d.product_id);

        }
    }
}
