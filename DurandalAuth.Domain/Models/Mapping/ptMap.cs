using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ptMap : EntityTypeConfiguration<pt>
    {
        public ptMap()
        {
            // Primary Key
            this.HasKey(t => t.part_id);

            // Properties
            this.Property(t => t.acc_prop_type)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.cad_file_name)
                .IsFixedLength()
                .HasMaxLength(64);

            /*this.Property(t => t.class)
                .IsFixedLength()
                .HasMaxLength(12);*/

            this.Property(t => t.description)
                .HasMaxLength(50);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.model_no)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.stock_no)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.storage)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.units_issue)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.units_order)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.part_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("pt", "afm");
            this.Property(t => t.acc_prop_type).HasColumnName("acc_prop_type");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.cad_file_name).HasColumnName("cad_file_name");
            //this.Property(t => t.class).HasColumnName("class");
            this.Property(t => t.cost_abc).HasColumnName("cost_abc");
            this.Property(t => t.cost_total).HasColumnName("cost_total");
            this.Property(t => t.cost_unit_avg).HasColumnName("cost_unit_avg");
            this.Property(t => t.cost_unit_last).HasColumnName("cost_unit_last");
            this.Property(t => t.cost_unit_std).HasColumnName("cost_unit_std");
            this.Property(t => t.date_of_last_cnt).HasColumnName("date_of_last_cnt");
            this.Property(t => t.date_of_last_use).HasColumnName("date_of_last_use");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.model_no).HasColumnName("model_no");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.qty_calc_wk_use).HasColumnName("qty_calc_wk_use");
            this.Property(t => t.qty_calc_yr_use).HasColumnName("qty_calc_yr_use");
            this.Property(t => t.qty_last_purch).HasColumnName("qty_last_purch");
            this.Property(t => t.qty_min_hand).HasColumnName("qty_min_hand");
            this.Property(t => t.qty_of_vendors).HasColumnName("qty_of_vendors");
            this.Property(t => t.qty_on_hand).HasColumnName("qty_on_hand");
            this.Property(t => t.qty_on_order).HasColumnName("qty_on_order");
            this.Property(t => t.qty_on_reserve).HasColumnName("qty_on_reserve");
            this.Property(t => t.qty_physical_count).HasColumnName("qty_physical_count");
            this.Property(t => t.qty_std_order).HasColumnName("qty_std_order");
            this.Property(t => t.qty_to_date_yr_use).HasColumnName("qty_to_date_yr_use");
            this.Property(t => t.qty_to_order).HasColumnName("qty_to_order");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.stock_no).HasColumnName("stock_no");
            this.Property(t => t.storage).HasColumnName("storage");
            this.Property(t => t.units_issue).HasColumnName("units_issue");
            this.Property(t => t.units_ord_iss).HasColumnName("units_ord_iss");
            this.Property(t => t.units_order).HasColumnName("units_order");
            this.Property(t => t.part_id).HasColumnName("part_id");

            // Relationships
            this.HasMany(t => t.pt1)
                .WithMany(t => t.pts)
                .Map(m =>
                    {
                        m.ToTable("ap", "afm");
                        m.MapLeftKey("alt_part_id");
                        m.MapRightKey("part_id");
                    });

            this.HasOptional(t => t.bl)
                .WithMany(t => t.pts)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.Pts)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.rm)
                .WithMany(t => t.pts)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });

        }
    }
}
