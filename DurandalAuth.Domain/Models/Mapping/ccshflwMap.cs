using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ccshflwMap : EntityTypeConfiguration<ccshflw>
    {
        public ccshflwMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

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
            this.ToTable("ccshflw", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.cost_cat_id).HasColumnName("cost_cat_id");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.ls_id).HasColumnName("ls_id");
            this.Property(t => t.month_01_budget).HasColumnName("month_01_budget");
            this.Property(t => t.month_01_costs).HasColumnName("month_01_costs");
            this.Property(t => t.month_01_var).HasColumnName("month_01_var");
            this.Property(t => t.month_02_budget).HasColumnName("month_02_budget");
            this.Property(t => t.month_02_costs).HasColumnName("month_02_costs");
            this.Property(t => t.month_02_var).HasColumnName("month_02_var");
            this.Property(t => t.month_03_budget).HasColumnName("month_03_budget");
            this.Property(t => t.month_03_costs).HasColumnName("month_03_costs");
            this.Property(t => t.month_03_var).HasColumnName("month_03_var");
            this.Property(t => t.month_04_budget).HasColumnName("month_04_budget");
            this.Property(t => t.month_04_costs).HasColumnName("month_04_costs");
            this.Property(t => t.month_04_var).HasColumnName("month_04_var");
            this.Property(t => t.month_05_budget).HasColumnName("month_05_budget");
            this.Property(t => t.month_05_costs).HasColumnName("month_05_costs");
            this.Property(t => t.month_05_var).HasColumnName("month_05_var");
            this.Property(t => t.month_06_budget).HasColumnName("month_06_budget");
            this.Property(t => t.month_06_costs).HasColumnName("month_06_costs");
            this.Property(t => t.month_06_var).HasColumnName("month_06_var");
            this.Property(t => t.month_07_budget).HasColumnName("month_07_budget");
            this.Property(t => t.month_07_costs).HasColumnName("month_07_costs");
            this.Property(t => t.month_07_var).HasColumnName("month_07_var");
            this.Property(t => t.month_08_budget).HasColumnName("month_08_budget");
            this.Property(t => t.month_08_costs).HasColumnName("month_08_costs");
            this.Property(t => t.month_08_var).HasColumnName("month_08_var");
            this.Property(t => t.month_09_budget).HasColumnName("month_09_budget");
            this.Property(t => t.month_09_costs).HasColumnName("month_09_costs");
            this.Property(t => t.month_09_var).HasColumnName("month_09_var");
            this.Property(t => t.month_10_budget).HasColumnName("month_10_budget");
            this.Property(t => t.month_10_costs).HasColumnName("month_10_costs");
            this.Property(t => t.month_10_var).HasColumnName("month_10_var");
            this.Property(t => t.month_11_budget).HasColumnName("month_11_budget");
            this.Property(t => t.month_11_costs).HasColumnName("month_11_costs");
            this.Property(t => t.month_11_var).HasColumnName("month_11_var");
            this.Property(t => t.month_12_budget).HasColumnName("month_12_budget");
            this.Property(t => t.month_12_costs).HasColumnName("month_12_costs");
            this.Property(t => t.month_12_var).HasColumnName("month_12_var");
            this.Property(t => t.pr_id).HasColumnName("pr_id");
            this.Property(t => t.qtr_01_budget).HasColumnName("qtr_01_budget");
            this.Property(t => t.qtr_01_costs).HasColumnName("qtr_01_costs");
            this.Property(t => t.qtr_01_var).HasColumnName("qtr_01_var");
            this.Property(t => t.qtr_02_budget).HasColumnName("qtr_02_budget");
            this.Property(t => t.qtr_02_costs).HasColumnName("qtr_02_costs");
            this.Property(t => t.qtr_02_var).HasColumnName("qtr_02_var");
            this.Property(t => t.qtr_03_budget).HasColumnName("qtr_03_budget");
            this.Property(t => t.qtr_03_costs).HasColumnName("qtr_03_costs");
            this.Property(t => t.qtr_03_var).HasColumnName("qtr_03_var");
            this.Property(t => t.qtr_04_budget).HasColumnName("qtr_04_budget");
            this.Property(t => t.qtr_04_costs).HasColumnName("qtr_04_costs");
            this.Property(t => t.qtr_04_var).HasColumnName("qtr_04_var");
            this.Property(t => t.source).HasColumnName("source");
            this.Property(t => t.year_budget).HasColumnName("year_budget");
            this.Property(t => t.year_costs).HasColumnName("year_costs");
            this.Property(t => t.year_var).HasColumnName("year_var");
            this.Property(t => t.ac_id).HasColumnName("ac_id");
            this.Property(t => t.auto_number).HasColumnName("auto_number");
        }
    }
}
