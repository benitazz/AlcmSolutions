using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class helpdesk_sla_requestMap : EntityTypeConfiguration<helpdesk_sla_request>
    {
        public helpdesk_sla_requestMap()
        {
            // Primary Key
            this.HasKey(t => new { t.activity_type, t.ordering_seq });

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.em_std)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.eq_id)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.eq_std)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.pmp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.prob_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.requestor)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.activity_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.ordering_seq)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("helpdesk_sla_request", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.default_priority).HasColumnName("default_priority");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.em_std).HasColumnName("em_std");
            this.Property(t => t.eq_id).HasColumnName("eq_id");
            this.Property(t => t.eq_std).HasColumnName("eq_std");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.grouping).HasColumnName("grouping");
            this.Property(t => t.pmp_id).HasColumnName("pmp_id");
            this.Property(t => t.prob_type).HasColumnName("prob_type");
            this.Property(t => t.requestor).HasColumnName("requestor");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.activity_type).HasColumnName("activity_type");
            this.Property(t => t.ordering_seq).HasColumnName("ordering_seq");

            // Relationships
            this.HasRequired(t => t.activitytype)
                .WithMany(t => t.helpdesk_sla_request)
                .HasForeignKey(d => d.activity_type);
            this.HasOptional(t => t.bl)
                .WithMany(t => t.helpdesk_sla_request)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.dp)
                .WithMany(t => t.helpdesk_sla_request)
                .HasForeignKey(d => new { d.dv_id, d.dp_id });
            this.HasOptional(t => t.dv)
                .WithMany(t => t.helpdesk_sla_request)
                .HasForeignKey(d => d.dv_id);
            this.HasOptional(t => t.em)
                .WithMany(t => t.HelpdeskSlaRequest)
                .HasForeignKey(d => d.requestor);
            this.HasOptional(t => t.emstd)
                .WithMany(t => t.helpdesk_sla_request)
                .HasForeignKey(d => d.em_std);
            this.HasOptional(t => t.eq)
                .WithMany(t => t.helpdesk_sla_request)
                .HasForeignKey(d => d.eq_id);
            this.HasOptional(t => t.eqstd)
                .WithMany(t => t.helpdesk_sla_request)
                .HasForeignKey(d => d.eq_std);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.HelpdeskSlaRequest)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.pmp)
                .WithMany(t => t.helpdesk_sla_request)
                .HasForeignKey(d => d.pmp_id);
            this.HasOptional(t => t.probtype)
                .WithMany(t => t.helpdesk_sla_request)
                .HasForeignKey(d => d.prob_type);
            this.HasOptional(t => t.rm)
                .WithMany(t => t.helpdesk_sla_request)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });
            this.HasOptional(t => t.site)
                .WithMany(t => t.helpdesk_sla_request)
                .HasForeignKey(d => d.site_id);

        }
    }
}
