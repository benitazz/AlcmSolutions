using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class wohwoMap : EntityTypeConfiguration<wohwo>
    {
        public wohwoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.cost_estimated, t.cost_labor, t.cost_other, t.cost_parts, t.cost_tools, t.cost_total, t.priority, t.wo_id });

            // Properties
            this.Property(t => t.ac_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.cost_estimated)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cost_labor)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cost_other)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cost_parts)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cost_tools)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cost_total)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.description)
                .HasMaxLength(5000);

            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.name_authorized)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.name_of_contact)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.name_of_planner)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.priority)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.supervisor)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.tr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.wo_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.wo_type)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.work_team_id)
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("wohwo", "afm");
            this.Property(t => t.ac_id).HasColumnName("ac_id");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.cost_estimated).HasColumnName("cost_estimated");
            this.Property(t => t.cost_labor).HasColumnName("cost_labor");
            this.Property(t => t.cost_other).HasColumnName("cost_other");
            this.Property(t => t.cost_parts).HasColumnName("cost_parts");
            this.Property(t => t.cost_tools).HasColumnName("cost_tools");
            this.Property(t => t.cost_total).HasColumnName("cost_total");
            this.Property(t => t.date_assigned).HasColumnName("date_assigned");
            this.Property(t => t.date_closed).HasColumnName("date_closed");
            this.Property(t => t.date_completed).HasColumnName("date_completed");
            this.Property(t => t.date_created).HasColumnName("date_created");
            this.Property(t => t.date_issued).HasColumnName("date_issued");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.name_authorized).HasColumnName("name_authorized");
            this.Property(t => t.name_of_contact).HasColumnName("name_of_contact");
            this.Property(t => t.name_of_planner).HasColumnName("name_of_planner");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.priority).HasColumnName("priority");
            this.Property(t => t.qty_open_wr).HasColumnName("qty_open_wr");
            this.Property(t => t.supervisor).HasColumnName("supervisor");
            this.Property(t => t.time_assigned).HasColumnName("time_assigned");
            this.Property(t => t.time_closed).HasColumnName("time_closed");
            this.Property(t => t.time_completed).HasColumnName("time_completed");
            this.Property(t => t.time_created).HasColumnName("time_created");
            this.Property(t => t.time_issued).HasColumnName("time_issued");
            this.Property(t => t.tr_id).HasColumnName("tr_id");
            this.Property(t => t.wo_id).HasColumnName("wo_id");
            this.Property(t => t.wo_type).HasColumnName("wo_type");
            this.Property(t => t.work_team_id).HasColumnName("work_team_id");
        }
    }
}
