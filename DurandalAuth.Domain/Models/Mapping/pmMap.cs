namespace DurandalAuth.Domain.Models.Mapping
{
    #region

    using System.Data.Entity.ModelConfiguration;

    #endregion


    public class PmMap : EntityTypeConfiguration<Pm>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PmMap"/> class.
        /// </summary>
        public PmMap()
        {
            // Primary Key
            this.HasKey(t => t.PmsId);

            // Properties
            this.Property(t => t.bl_id).IsFixedLength().HasMaxLength(8);

            this.Property(t => t.Comments).HasMaxLength(100);

            this.Property(t => t.dp_id).IsFixedLength().HasMaxLength(16);

            this.Property(t => t.dv_id).IsFixedLength().HasMaxLength(16);

            this.Property(t => t.EqId).IsFixedLength().HasMaxLength(12);

            this.Property(t => t.fl_id).IsFixedLength().HasMaxLength(4);

            this.Property(t => t.IntervalType).IsRequired().IsFixedLength().HasMaxLength(4);

            this.Property(t => t.Option1).IsFixedLength().HasMaxLength(16);

            this.Property(t => t.Option2).IsFixedLength().HasMaxLength(16);

            this.Property(t => t.PmGroup).IsFixedLength().HasMaxLength(16);

            this.Property(t => t.PmpId).IsRequired().IsFixedLength().HasMaxLength(16);

            this.Property(t => t.rm_id).IsFixedLength().HasMaxLength(8);

            this.Property(t => t.SiteId).IsFixedLength().HasMaxLength(16);

            this.Property(t => t.Units).IsFixedLength().HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("pms", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.Comments).HasColumnName("comments");
            this.Property(t => t.DateFirstTodo).HasColumnName("date_first_todo");
            this.Property(t => t.DateLastCompleted).HasColumnName("date_last_completed");
            this.Property(t => t.DateNextAltTodo).HasColumnName("date_next_alt_todo");
            this.Property(t => t.DateNextTodo).HasColumnName("date_next_todo");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.EqId).HasColumnName("eq_id");
            this.Property(t => t.FixedType).HasColumnName("fixed");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.HoursCalc).HasColumnName("hours_calc");
            this.Property(t => t.HoursEst).HasColumnName("hours_est");
            this.Property(t => t.Interval1).HasColumnName("interval_1");
            this.Property(t => t.Interval2).HasColumnName("interval_2");
            this.Property(t => t.Interval3).HasColumnName("interval_3");
            this.Property(t => t.Interval4).HasColumnName("interval_4");
            this.Property(t => t.IntervalFreq).HasColumnName("interval_freq");
            this.Property(t => t.IntervalType).HasColumnName("interval_type");
            this.Property(t => t.MeterLastPm).HasColumnName("meter_last_pm");
            this.Property(t => t.Nactive).HasColumnName("nactive");
            this.Property(t => t.Option1).HasColumnName("option1");
            this.Property(t => t.Option2).HasColumnName("option2");
            this.Property(t => t.PmGroup).HasColumnName("pm_group");
            this.Property(t => t.PmpId).HasColumnName("pmp_id");
            this.Property(t => t.Priority).HasColumnName("priority");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.SiteId).HasColumnName("site_id");
            this.Property(t => t.TotalUnit).HasColumnName("total_unit");
            this.Property(t => t.Units).HasColumnName("units");
            this.Property(t => t.PmsId).HasColumnName("pms_id");

            // Relationships
            this.HasOptional(t => t.Bl).WithMany(t => t.pms).HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.Dp).WithMany(t => t.pms).HasForeignKey(d => new { dv_id = d.dv_id, dp_id = d.dp_id });
            this.HasOptional(t => t.Dv).WithMany(t => t.pms).HasForeignKey(d => d.dv_id);
            this.HasOptional(t => t.Eq).WithMany(t => t.pms).HasForeignKey(d => d.EqId);
            this.HasOptional(t => t.Fl).WithMany(t => t.Pms).HasForeignKey(d => new { bl_id = d.bl_id, fl_id = d.fl_id });
            this.HasOptional(t => t.Pmgp).WithMany(t => t.pms).HasForeignKey(d => d.PmGroup);
            this.HasRequired(t => t.Pmp).WithMany(t => t.pms).HasForeignKey(d => d.PmpId);
            this.HasOptional(t => t.Rm)
                .WithMany(t => t.pms)
                .HasForeignKey(d => new { bl_id = d.bl_id, fl_id = d.fl_id, rm_id = d.rm_id });
            this.HasOptional(t => t.Site).WithMany(t => t.pms).HasForeignKey(d => d.SiteId);
        }
    }
}