using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class emMap : EntityTypeConfiguration<Em>
    {
        public emMap()
        {
            // Primary Key
            this.HasKey(t => t.EmId);

            // Properties
            this.Property(t => t.EmNumber)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.EmPhoto)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.EmStd)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.EmTitle)
                .HasMaxLength(64);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            this.Property(t => t.EmergencyContact)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.EmergencyPhone)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.EmergencyRelation)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.Extension)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.Fax)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.Honorific)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.ImageFile)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.LayerName)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.Mailstop)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.NameFirst)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.NameLast)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.net_id)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.NetUserName)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.Option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.Option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.PagerNumber)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.Phone)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.PhoneHome)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.RecoveryStatus)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.rf_id)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.Status)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.TcLevel)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.CallingCardNumber)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.CellularNumber)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.Comments)
                .HasMaxLength(500);

            this.Property(t => t.contingency_bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.ContingencyEmail)
                .HasMaxLength(50);

            this.Property(t => t.ContingencyFax)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.contingency_fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.ContingencyPhone)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.contingency_rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.curr_bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.curr_fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.curr_rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.CurrSiteId)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.dv_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.Dwgname)
                .HasMaxLength(128);

            this.Property(t => t.Ehandle)
                .HasMaxLength(64);

            this.Property(t => t.EmId)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(35);

            // Table & Column Mappings
            this.ToTable("em", "afm");
            this.Property(t => t.EmNumber).HasColumnName("em_number");
            this.Property(t => t.EmPhoto).HasColumnName("em_photo");
            this.Property(t => t.EmStd).HasColumnName("em_std");
            this.Property(t => t.EmTitle).HasColumnName("em_title");
            this.Property(t => t.Email).HasColumnName("email");
            this.Property(t => t.EmergencyContact).HasColumnName("emergency_contact");
            this.Property(t => t.EmergencyPhone).HasColumnName("emergency_phone");
            this.Property(t => t.EmergencyRelation).HasColumnName("emergency_relation");
            this.Property(t => t.Extension).HasColumnName("extension");
            this.Property(t => t.Fax).HasColumnName("fax");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.geo_objectid).HasColumnName("geo_objectid");
            this.Property(t => t.Honorific).HasColumnName("honorific");
            this.Property(t => t.ImageFile).HasColumnName("image_file");
            this.Property(t => t.Lat).HasColumnName("lat");
            this.Property(t => t.LayerName).HasColumnName("layer_name");
            this.Property(t => t.Lon).HasColumnName("lon");
            this.Property(t => t.Mailstop).HasColumnName("mailstop");
            this.Property(t => t.NameFirst).HasColumnName("name_first");
            this.Property(t => t.NameLast).HasColumnName("name_last");
            this.Property(t => t.net_id).HasColumnName("net_id");
            this.Property(t => t.NetUserName).HasColumnName("net_user_name");
            this.Property(t => t.Option1).HasColumnName("option1");
            this.Property(t => t.Option2).HasColumnName("option2");
            this.Property(t => t.PagerNumber).HasColumnName("pager_number");
            this.Property(t => t.PctRm).HasColumnName("pct_rm");
            this.Property(t => t.Phone).HasColumnName("phone");
            this.Property(t => t.PhoneHome).HasColumnName("phone_home");
            this.Property(t => t.RecoveryStatus).HasColumnName("recovery_status");
            this.Property(t => t.rf_id).HasColumnName("rf_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.Status).HasColumnName("status");
            this.Property(t => t.TcLevel).HasColumnName("tc_level");
            this.Property(t => t.AreaChargable).HasColumnName("area_chargable");
            this.Property(t => t.AreaComn).HasColumnName("area_comn");
            this.Property(t => t.AreaComnNocup).HasColumnName("area_comn_nocup");
            this.Property(t => t.AreaComnOcup).HasColumnName("area_comn_ocup");
            this.Property(t => t.AreaComnRm).HasColumnName("area_comn_rm");
            this.Property(t => t.AreaComnServ).HasColumnName("area_comn_serv");
            this.Property(t => t.AreaRm).HasColumnName("area_rm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.CallingCardNumber).HasColumnName("calling_card_number");
            this.Property(t => t.CellularNumber).HasColumnName("cellular_number");
            this.Property(t => t.Comments).HasColumnName("comments");
            this.Property(t => t.contingency_bl_id).HasColumnName("contingency_bl_id");
            this.Property(t => t.ContingencyEmail).HasColumnName("contingency_email");
            this.Property(t => t.ContingencyFacAt).HasColumnName("contingency_fac_at");
            this.Property(t => t.ContingencyFax).HasColumnName("contingency_fax");
            this.Property(t => t.contingency_fl_id).HasColumnName("contingency_fl_id");
            this.Property(t => t.ContingencyPhone).HasColumnName("contingency_phone");
            this.Property(t => t.contingency_rm_id).HasColumnName("contingency_rm_id");
            this.Property(t => t.Cost).HasColumnName("cost");
            this.Property(t => t.curr_bl_id).HasColumnName("curr_bl_id");
            this.Property(t => t.curr_fl_id).HasColumnName("curr_fl_id");
            this.Property(t => t.curr_rm_id).HasColumnName("curr_rm_id");
            this.Property(t => t.CurrSiteId).HasColumnName("curr_site_id");
            this.Property(t => t.DateHired).HasColumnName("date_hired");
            this.Property(t => t.dp_id).HasColumnName("dp_id");
            this.Property(t => t.dv_id).HasColumnName("dv_id");
            this.Property(t => t.Dwgname).HasColumnName("dwgname");
            this.Property(t => t.Ehandle).HasColumnName("ehandle");
            this.Property(t => t.EmId).HasColumnName("em_id");

            // Relationships
            this.HasOptional(t => t.AfmTclevel)
                .WithMany(t => t.ems)
                .HasForeignKey(d => d.TcLevel);
            this.HasOptional(t => t.Bl)
                .WithMany(t => t.ems)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.Bl1)
                .WithMany(t => t.ems1)
                .HasForeignKey(d => d.contingency_bl_id);
            this.HasOptional(t => t.Dp)
                .WithMany(t => t.ems)
                .HasForeignKey(d => new { dv_id = d.dv_id, dp_id = d.dp_id });
            this.HasOptional(t => t.Dv)
                .WithMany(t => t.ems)
                .HasForeignKey(d => d.dv_id);
            this.HasOptional(t => t.Fl)
                .WithMany(t => t.Ems)
                .HasForeignKey(d => new { contingency_bl_id = d.contingency_bl_id, contingency_fl_id = d.contingency_fl_id });
            this.HasOptional(t => t.Rm)
                .WithMany(t => t.ems)
                .HasForeignKey(d => new { contingency_bl_id = d.contingency_bl_id, contingency_fl_id = d.contingency_fl_id, contingency_rm_id = d.contingency_rm_id });
            this.HasOptional(t => t.Fl1)
                .WithMany(t => t.Ems1)
                .HasForeignKey(d => new { curr_bl_id = d.curr_bl_id, curr_fl_id = d.curr_fl_id });
            this.HasOptional(t => t.Rm1)
                .WithMany(t => t.ems1)
                .HasForeignKey(d => new { curr_bl_id = d.curr_bl_id, curr_fl_id = d.curr_fl_id, curr_rm_id = d.curr_rm_id });
            this.HasOptional(t => t.Emstd)
                .WithMany(t => t.ems)
                .HasForeignKey(d => d.EmStd);
            this.HasOptional(t => t.Fl2)
                .WithMany(t => t.Ems2)
                .HasForeignKey(d => new { bl_id = d.bl_id, fl_id = d.fl_id });
            this.HasOptional(t => t.Net)
                .WithMany(t => t.ems)
                .HasForeignKey(d => d.net_id);
            this.HasOptional(t => t.Rm2)
                .WithMany(t => t.ems2)
                .HasForeignKey(d => new { bl_id = d.bl_id, fl_id = d.fl_id, rm_id = d.rm_id });

        }
    }
}
