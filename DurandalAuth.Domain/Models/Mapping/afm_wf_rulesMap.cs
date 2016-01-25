using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_wf_rulesMap : EntityTypeConfiguration<afm_wf_rules>
    {
        public afm_wf_rulesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.activity_id, t.rule_id });

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(500);

            this.Property(t => t.dwgname)
                .HasMaxLength(128);

            this.Property(t => t.ehandle)
                .HasMaxLength(64);

            this.Property(t => t.group_name)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.rule_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.xml_rule_props)
                .HasMaxLength(4000);

            this.Property(t => t.xml_sched_props)
                .HasMaxLength(3000);

            this.Property(t => t.activity_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.rule_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("afm_wf_rules", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.dwgname).HasColumnName("dwgname");
            this.Property(t => t.ehandle).HasColumnName("ehandle");
            this.Property(t => t.group_name).HasColumnName("group_name");
            this.Property(t => t.is_active).HasColumnName("is_active");
            this.Property(t => t.rule_type).HasColumnName("rule_type");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.xml_rule_props).HasColumnName("xml_rule_props");
            this.Property(t => t.xml_sched_props).HasColumnName("xml_sched_props");
            this.Property(t => t.activity_id).HasColumnName("activity_id");
            this.Property(t => t.rule_id).HasColumnName("rule_id");

            // Relationships
            this.HasRequired(t => t.afm_activities)
                .WithMany(t => t.afm_wf_rules)
                .HasForeignKey(d => d.activity_id);
            this.HasOptional(t => t.afm_groups)
                .WithMany(t => t.afm_wf_rules)
                .HasForeignKey(d => d.group_name);

        }
    }
}
