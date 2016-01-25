using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ccostprjnMap : EntityTypeConfiguration<ccostprjn>
    {
        public ccostprjnMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.budget_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.cost_cat_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.ls_id)
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

            // Table & Column Mappings
            this.ToTable("ccostprjn", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.budget_id).HasColumnName("budget_id");
            this.Property(t => t.cost_cat_id).HasColumnName("cost_cat_id");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.ls_id).HasColumnName("ls_id");
            this.Property(t => t.pr_id).HasColumnName("pr_id");
            this.Property(t => t.source).HasColumnName("source");
            this.Property(t => t.year_01_costs).HasColumnName("year_01_costs");
            this.Property(t => t.year_02_costs).HasColumnName("year_02_costs");
            this.Property(t => t.year_03_costs).HasColumnName("year_03_costs");
            this.Property(t => t.year_04_costs).HasColumnName("year_04_costs");
            this.Property(t => t.year_05_costs).HasColumnName("year_05_costs");
            this.Property(t => t.year_06_costs).HasColumnName("year_06_costs");
            this.Property(t => t.year_07_costs).HasColumnName("year_07_costs");
            this.Property(t => t.year_08_costs).HasColumnName("year_08_costs");
            this.Property(t => t.year_09_costs).HasColumnName("year_09_costs");
            this.Property(t => t.year_10_costs).HasColumnName("year_10_costs");
            this.Property(t => t.year_11_costs).HasColumnName("year_11_costs");
            this.Property(t => t.year_12_costs).HasColumnName("year_12_costs");
            this.Property(t => t.year_13_costs).HasColumnName("year_13_costs");
            this.Property(t => t.year_14_costs).HasColumnName("year_14_costs");
            this.Property(t => t.year_15_costs).HasColumnName("year_15_costs");
            this.Property(t => t.ac_id).HasColumnName("ac_id");
            this.Property(t => t.auto_number).HasColumnName("auto_number");
        }
    }
}
