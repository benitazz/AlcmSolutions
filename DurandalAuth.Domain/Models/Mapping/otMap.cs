using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class otMap : EntityTypeConfiguration<ot>
    {
        public otMap()
        {
            // Primary Key
            this.HasKey(t => t.ot_id);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.comments)
                .HasMaxLength(2000);

            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.pr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.status)
                .IsFixedLength()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("ot", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.cost_purchase).HasColumnName("cost_purchase");
            this.Property(t => t.cost_selling).HasColumnName("cost_selling");
            this.Property(t => t.date_purchase).HasColumnName("date_purchase");
            this.Property(t => t.date_sold).HasColumnName("date_sold");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.pr_id).HasColumnName("pr_id");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.ot_id).HasColumnName("ot_id");

            // Relationships
            this.HasOptional(t => t.bl)
                .WithMany(t => t.ots)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.property)
                .WithMany(t => t.ots)
                .HasForeignKey(d => d.pr_id);

        }
    }
}
