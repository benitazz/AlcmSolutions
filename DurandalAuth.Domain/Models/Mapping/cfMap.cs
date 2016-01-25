using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class cfMap : EntityTypeConfiguration<cf>
    {
        public cfMap()
        {
            // Primary Key
            this.HasKey(t => t.CfId);

            // Properties
            this.Property(t => t.Email)
                .HasMaxLength(64);

            this.Property(t => t.IssueWorkInFormat)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.IssueWorkTo)
                .IsFixedLength()
                .HasMaxLength(255);

            this.Property(t => t.Name)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.Option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.Option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.Position)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.ReportsTo)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.Skills)
                .HasMaxLength(5000);

            this.Property(t => t.Status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.TrId)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.WorkTeamId)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.CfId)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("cf", "afm");
            this.Property(t => t.DateContractExp).HasColumnName("date_contract_exp");
            this.Property(t => t.DateInsAutoExp).HasColumnName("date_ins_auto_exp");
            this.Property(t => t.DateInsLiaExp).HasColumnName("date_ins_lia_exp");
            this.Property(t => t.DateInsWcExp).HasColumnName("date_ins_wc_exp");
            this.Property(t => t.Email).HasColumnName("email");
            this.Property(t => t.InHouse).HasColumnName("in_house");
            this.Property(t => t.IsEstimator).HasColumnName("is_estimator");
            this.Property(t => t.IsPlanner).HasColumnName("is_planner");
            this.Property(t => t.IsSupervisor).HasColumnName("is_supervisor");
            this.Property(t => t.IssueWorkInFormat).HasColumnName("issue_work_in_format");
            this.Property(t => t.IssueWorkTo).HasColumnName("issue_work_to");
            this.Property(t => t.Name).HasColumnName("name");
            this.Property(t => t.Option1).HasColumnName("option1");
            this.Property(t => t.Option2).HasColumnName("option2");
            this.Property(t => t.Position).HasColumnName("position");
            this.Property(t => t.RateDouble).HasColumnName("rate_double");
            this.Property(t => t.RateHourly).HasColumnName("rate_hourly");
            this.Property(t => t.RateOver).HasColumnName("rate_over");
            this.Property(t => t.ReportsTo).HasColumnName("reports_to");
            this.Property(t => t.Skills).HasColumnName("skills");
            this.Property(t => t.Status).HasColumnName("status");
            this.Property(t => t.StdHoursAvail).HasColumnName("std_hours_avail");
            this.Property(t => t.TrId).HasColumnName("tr_id");
            this.Property(t => t.WorkTeamId).HasColumnName("work_team_id");
            this.Property(t => t.AssignWork).HasColumnName("assign_work");
            this.Property(t => t.CfId).HasColumnName("cf_id");

            // Relationships
            this.HasMany(t => t.WorkTeam1)
                .WithMany(t => t.cfs1)
                .Map(m =>
                    {
                        m.ToTable("cf_work_team", "afm");
                        m.MapLeftKey("cf_id");
                        m.MapRightKey("work_team_id");
                    });

            this.HasOptional(t => t.Em)
                .WithMany(t => t.Cfs)
                .HasForeignKey(d => d.ReportsTo);
            this.HasRequired(t => t.Tr)
                .WithMany(t => t.cfs)
                .HasForeignKey(d => d.TrId);
            this.HasOptional(t => t.WorkTeam)
                .WithMany(t => t.cfs)
                .HasForeignKey(d => d.WorkTeamId);

        }
    }
}
