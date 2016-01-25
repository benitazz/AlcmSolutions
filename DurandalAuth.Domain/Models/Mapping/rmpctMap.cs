using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class rmpctMap : EntityTypeConfiguration<rmpct>
    {
        public rmpctMap()
        {
            // Primary Key
            this.HasKey(t => t.pct_id);

            // Properties
            this.Property(t => t.ac_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.del_user_name)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.from_bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.from_fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.from_rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.org_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.prorate)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.resources)
                .HasMaxLength(5000);

            this.Property(t => t.rm_cat)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.rm_type)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.user_name)
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("rmpct", "afm");
            this.Property(t => t.ac_id).HasColumnName("ac_id");
            this.Property(t => t.activity_log_id).HasColumnName("activity_log_id");
            this.Property(t => t.area_chargable).HasColumnName("area_chargable");
            this.Property(t => t.area_comn).HasColumnName("area_comn");
            this.Property(t => t.area_comn_nocup).HasColumnName("area_comn_nocup");
            this.Property(t => t.area_comn_ocup).HasColumnName("area_comn_ocup");
            this.Property(t => t.area_comn_rm).HasColumnName("area_comn_rm");
            this.Property(t => t.area_comn_serv).HasColumnName("area_comn_serv");
            this.Property(t => t.area_rm).HasColumnName("area_rm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.confirmed).HasColumnName("confirmed");
            this.Property(t => t.cost).HasColumnName("cost");
            this.Property(t => t.date_created).HasColumnName("date_created");
            this.Property(t => t.date_deleted).HasColumnName("date_deleted");
            this.Property(t => t.date_end).HasColumnName("date_end");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.day_part).HasColumnName("day_part");
            this.Property(t => t.del_user_name).HasColumnName("del_user_name");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.from_bl_id).HasColumnName("from_bl_id");
            this.Property(t => t.from_fl_id).HasColumnName("from_fl_id");
            this.Property(t => t.from_rm_id).HasColumnName("from_rm_id");
            this.Property(t => t.mo_id).HasColumnName("mo_id");
            this.Property(t => t.org_id).HasColumnName("org_id");
            this.Property(t => t.parent_pct_id).HasColumnName("parent_pct_id");
            this.Property(t => t.pct_space).HasColumnName("pct_space");
            this.Property(t => t.pct_time).HasColumnName("pct_time");
            this.Property(t => t.primary_em).HasColumnName("primary_em");
            this.Property(t => t.primary_rm).HasColumnName("primary_rm");
            this.Property(t => t.prorate).HasColumnName("prorate");
            this.Property(t => t.resources).HasColumnName("resources");
            this.Property(t => t.rm_cat).HasColumnName("rm_cat");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.rm_type).HasColumnName("rm_type");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.user_name).HasColumnName("user_name");
            this.Property(t => t.visitor_id).HasColumnName("visitor_id");
            this.Property(t => t.pct_id).HasColumnName("pct_id");

            // Relationships
            this.HasOptional(t => t.ac)
                .WithMany(t => t.rmpcts)
                .HasForeignKey(d => d.ac_id);
            this.HasOptional(t => t.activity_log)
                .WithMany(t => t.rmpcts)
                .HasForeignKey(d => d.activity_log_id);
            this.HasOptional(t => t.bl)
                .WithMany(t => t.rmpcts)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.dp)
                .WithMany(t => t.rmpcts)
                .HasForeignKey(d => new { d.dv_id, d.dp_id });
            this.HasOptional(t => t.dv)
                .WithMany(t => t.rmpcts)
                .HasForeignKey(d => d.dv_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.Rmpcts)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.mo)
                .WithMany(t => t.rmpcts)
                .HasForeignKey(d => d.mo_id);
            this.HasOptional(t => t.org)
                .WithMany(t => t.rmpcts)
                .HasForeignKey(d => d.org_id);
            this.HasOptional(t => t.rm)
                .WithMany(t => t.rmpcts)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });
            this.HasOptional(t => t.rmcat)
                .WithMany(t => t.rmpcts)
                .HasForeignKey(d => d.rm_cat);
            this.HasOptional(t => t.rmtype)
                .WithMany(t => t.rmpcts)
                .HasForeignKey(d => new { d.rm_cat, d.rm_type });

        }
    }
}
