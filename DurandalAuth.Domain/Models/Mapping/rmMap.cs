using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class rmMap : EntityTypeConfiguration<Rm>
    {
        public rmMap()
        {
            // Primary Key
            this.HasKey(t => new { t.bl_id, t.fl_id, t.rm_id });

            // Properties
            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dwgname)
                .HasMaxLength(128);

            this.Property(t => t.ehandle)
                .HasMaxLength(64);

            this.Property(t => t.extension)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.layer_name)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.ls_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.name)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.org_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.phone)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.prorate)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.recovery_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.rm_cat)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.rm_std)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.rm_type)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.rm_use)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.survey_comments_rm)
                .HasMaxLength(5000);

            this.Property(t => t.survey_photo)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.survey_redline_rm)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.tc_level)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.fl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.rm_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("rm", "afm");
            this.Property(t => t.area).HasColumnName("area");
            this.Property(t => t.area_alloc).HasColumnName("area_alloc");
            this.Property(t => t.area_chargable).HasColumnName("area_chargable");
            this.Property(t => t.area_comn).HasColumnName("area_comn");
            this.Property(t => t.area_comn_nocup).HasColumnName("area_comn_nocup");
            this.Property(t => t.area_comn_ocup).HasColumnName("area_comn_ocup");
            this.Property(t => t.area_comn_rm).HasColumnName("area_comn_rm");
            this.Property(t => t.area_comn_serv).HasColumnName("area_comn_serv");
            this.Property(t => t.area_manual).HasColumnName("area_manual");
            this.Property(t => t.area_unalloc).HasColumnName("area_unalloc");
            this.Property(t => t.cap_em).HasColumnName("cap_em");
            this.Property(t => t.cost).HasColumnName("cost");
            this.Property(t => t.cost_sqft).HasColumnName("cost_sqft");
            this.Property(t => t.count_em).HasColumnName("count_em");
            this.Property(t => t.date_last_surveyed).HasColumnName("date_last_surveyed");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.dwgname).HasColumnName("dwgname");
            this.Property(t => t.ehandle).HasColumnName("ehandle");
            this.Property(t => t.extension).HasColumnName("extension");
            this.Property(t => t.geo_objectid).HasColumnName("geo_objectid");
            this.Property(t => t.hotelable).HasColumnName("hotelable");
            this.Property(t => t.lat).HasColumnName("lat");
            this.Property(t => t.layer_name).HasColumnName("layer_name");
            this.Property(t => t.length).HasColumnName("length");
            this.Property(t => t.lon).HasColumnName("lon");
            this.Property(t => t.ls_id).HasColumnName("ls_id");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.org_id).HasColumnName("org_id");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.prorate).HasColumnName("prorate");
            this.Property(t => t.recovery_status).HasColumnName("recovery_status");
            this.Property(t => t.reservable).HasColumnName("reservable");
            this.Property(t => t.rm_cat).HasColumnName("rm_cat");
            this.Property(t => t.rm_std).HasColumnName("rm_std");
            this.Property(t => t.rm_type).HasColumnName("rm_type");
            this.Property(t => t.rm_use).HasColumnName("rm_use");
            this.Property(t => t.survey_comments_rm).HasColumnName("survey_comments_rm");
            this.Property(t => t.survey_photo).HasColumnName("survey_photo");
            this.Property(t => t.survey_redline_rm).HasColumnName("survey_redline_rm");
            this.Property(t => t.tc_level).HasColumnName("tc_level");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");

            // Relationships
            this.HasOptional(t => t.afm_tclevel)
                .WithMany(t => t.rms)
                .HasForeignKey(d => d.tc_level);
            this.HasRequired(t => t.bl)
                .WithMany(t => t.rms)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.dp)
                .WithMany(t => t.rms)
                .HasForeignKey(d => new { d.dv_id, d.dp_id });
            this.HasOptional(t => t.dv)
                .WithMany(t => t.rms)
                .HasForeignKey(d => d.dv_id);
            this.HasRequired(t => t.fl)
                .WithMany(t => t.Rms)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.l)
                .WithMany(t => t.rms)
                .HasForeignKey(d => d.ls_id);
            this.HasOptional(t => t.org)
                .WithMany(t => t.rms)
                .HasForeignKey(d => d.org_id);
            this.HasOptional(t => t.rmcat)
                .WithMany(t => t.rms)
                .HasForeignKey(d => d.rm_cat);
            this.HasOptional(t => t.rmstd)
                .WithMany(t => t.rms)
                .HasForeignKey(d => d.rm_std);
            this.HasOptional(t => t.rmtype)
                .WithMany(t => t.rms)
                .HasForeignKey(d => new { d.rm_cat, d.rm_type });
            this.HasOptional(t => t.rmuse)
                .WithMany(t => t.rms)
                .HasForeignKey(d => d.rm_use);

        }
    }
}
