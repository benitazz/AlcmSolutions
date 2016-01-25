using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class budget_itemMap : EntityTypeConfiguration<budget_item>
    {
        public budget_itemMap()
        {
            // Primary Key
            this.HasKey(t => t.budget_item_id);

            // Properties
            this.Property(t => t.cost_cat_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.ls_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.pr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.source)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.ac_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.budget_id)
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("budget_item", "afm");
            this.Property(t => t.cost_cat_id).HasColumnName("cost_cat_id");
            this.Property(t => t.date_budget_created).HasColumnName("date_budget_created");
            this.Property(t => t.date_end).HasColumnName("date_end");
            this.Property(t => t.date_seasonal_end).HasColumnName("date_seasonal_end");
            this.Property(t => t.date_seasonal_start).HasColumnName("date_seasonal_start");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.ls_id).HasColumnName("ls_id");
            this.Property(t => t.month_exp).HasColumnName("month_exp");
            this.Property(t => t.month_inc).HasColumnName("month_inc");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.pr_id).HasColumnName("pr_id");
            this.Property(t => t.source).HasColumnName("source");
            this.Property(t => t.yearly_factor).HasColumnName("yearly_factor");
            this.Property(t => t.ac_id).HasColumnName("ac_id");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.budget_id).HasColumnName("budget_id");
            this.Property(t => t.budget_item_id).HasColumnName("budget_item_id");

            // Relationships
            this.HasOptional(t => t.ac)
                .WithMany(t => t.budget_item)
                .HasForeignKey(d => d.ac_id);
            this.HasOptional(t => t.bl)
                .WithMany(t => t.budget_item)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.budget)
                .WithMany(t => t.budget_item)
                .HasForeignKey(d => d.budget_id);
            this.HasRequired(t => t.cost_cat)
                .WithMany(t => t.budget_item)
                .HasForeignKey(d => d.cost_cat_id);
            this.HasOptional(t => t.dp)
                .WithMany(t => t.budget_item)
                .HasForeignKey(d => new { d.dv_id, d.dp_id });
            this.HasOptional(t => t.dv)
                .WithMany(t => t.budget_item)
                .HasForeignKey(d => d.dv_id);
            this.HasOptional(t => t.l)
                .WithMany(t => t.budget_item)
                .HasForeignKey(d => d.ls_id);
            this.HasOptional(t => t.property)
                .WithMany(t => t.budget_item)
                .HasForeignKey(d => d.pr_id);

        }
    }
}
