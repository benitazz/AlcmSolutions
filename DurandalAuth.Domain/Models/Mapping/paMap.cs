using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class paMap : EntityTypeConfiguration<pa>
    {
        public paMap()
        {
            // Primary Key
            this.HasKey(t => new { t.pr_id, t.pa_name });

            // Properties
            this.Property(t => t.condition)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.image_file)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.ls_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.property_type)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.status)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.pr_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.pa_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(24);

            // Table & Column Mappings
            this.ToTable("pa", "afm");
            this.Property(t => t.condition).HasColumnName("condition");
            this.Property(t => t.cost).HasColumnName("cost");
            this.Property(t => t.cost_selling).HasColumnName("cost_selling");
            this.Property(t => t.date_received).HasColumnName("date_received");
            this.Property(t => t.date_sold).HasColumnName("date_sold");
            this.Property(t => t.image_file).HasColumnName("image_file");
            this.Property(t => t.last_date).HasColumnName("last_date");
            this.Property(t => t.ls_id).HasColumnName("ls_id");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.property_type).HasColumnName("property_type");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.value_book).HasColumnName("value_book");
            this.Property(t => t.value_mkt).HasColumnName("value_mkt");
            this.Property(t => t.value_replace).HasColumnName("value_replace");
            this.Property(t => t.value_salvage).HasColumnName("value_salvage");
            this.Property(t => t.value_tax).HasColumnName("value_tax");
            this.Property(t => t.pr_id).HasColumnName("pr_id");
            this.Property(t => t.pa_name).HasColumnName("pa_name");

            // Relationships
            this.HasOptional(t => t.l)
                .WithMany(t => t.pas)
                .HasForeignKey(d => d.ls_id);
            this.HasRequired(t => t.property)
                .WithMany(t => t.pas)
                .HasForeignKey(d => d.pr_id);
            this.HasOptional(t => t.property_type1)
                .WithMany(t => t.pas)
                .HasForeignKey(d => d.property_type);

        }
    }
}
