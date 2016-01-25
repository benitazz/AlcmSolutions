using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class siteMap : EntityTypeConfiguration<site>
    {
        public siteMap()
        {
            // Primary Key
            this.HasKey(t => t.site_id);

            // Properties
            this.Property(t => t.city_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.ctry_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.detail_dwg)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.dwgname)
                .HasMaxLength(128);

            this.Property(t => t.ehandle)
                .HasMaxLength(64);

            this.Property(t => t.name)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.regn_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.site_photo)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.state_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.site_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("site", "afm");
            this.Property(t => t.acres).HasColumnName("acres");
            this.Property(t => t.area_em_dp).HasColumnName("area_em_dp");
            this.Property(t => t.area_ext_wall).HasColumnName("area_ext_wall");
            this.Property(t => t.area_gp).HasColumnName("area_gp");
            this.Property(t => t.area_gp_comn).HasColumnName("area_gp_comn");
            this.Property(t => t.area_gp_dp).HasColumnName("area_gp_dp");
            this.Property(t => t.area_gross_ext).HasColumnName("area_gross_ext");
            this.Property(t => t.area_gross_int).HasColumnName("area_gross_int");
            this.Property(t => t.area_nocup).HasColumnName("area_nocup");
            this.Property(t => t.area_nocup_comn).HasColumnName("area_nocup_comn");
            this.Property(t => t.area_nocup_dp).HasColumnName("area_nocup_dp");
            this.Property(t => t.area_ocup).HasColumnName("area_ocup");
            this.Property(t => t.area_ocup_comn).HasColumnName("area_ocup_comn");
            this.Property(t => t.area_ocup_dp).HasColumnName("area_ocup_dp");
            this.Property(t => t.area_rentable).HasColumnName("area_rentable");
            this.Property(t => t.area_rm).HasColumnName("area_rm");
            this.Property(t => t.area_rm_comn).HasColumnName("area_rm_comn");
            this.Property(t => t.area_rm_dp).HasColumnName("area_rm_dp");
            this.Property(t => t.area_serv).HasColumnName("area_serv");
            this.Property(t => t.area_st_comn_gp).HasColumnName("area_st_comn_gp");
            this.Property(t => t.area_st_comn_nocup).HasColumnName("area_st_comn_nocup");
            this.Property(t => t.area_st_comn_ocup).HasColumnName("area_st_comn_ocup");
            this.Property(t => t.area_st_comn_rm).HasColumnName("area_st_comn_rm");
            this.Property(t => t.area_st_comn_serv).HasColumnName("area_st_comn_serv");
            this.Property(t => t.area_su).HasColumnName("area_su");
            this.Property(t => t.area_usable).HasColumnName("area_usable");
            this.Property(t => t.area_vert_pen).HasColumnName("area_vert_pen");
            this.Property(t => t.city_id).HasColumnName("city_id");
            this.Property(t => t.count_em).HasColumnName("count_em");
            this.Property(t => t.ctry_id).HasColumnName("ctry_id");
            this.Property(t => t.detail_dwg).HasColumnName("detail_dwg");
            this.Property(t => t.dwgname).HasColumnName("dwgname");
            this.Property(t => t.ehandle).HasColumnName("ehandle");
            this.Property(t => t.geo_objectid).HasColumnName("geo_objectid");
            this.Property(t => t.lat).HasColumnName("lat");
            this.Property(t => t.lon).HasColumnName("lon");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.no_bldgs).HasColumnName("no_bldgs");
            this.Property(t => t.ratio_ru).HasColumnName("ratio_ru");
            this.Property(t => t.ratio_ur).HasColumnName("ratio_ur");
            this.Property(t => t.regn_id).HasColumnName("regn_id");
            this.Property(t => t.site_photo).HasColumnName("site_photo");
            this.Property(t => t.state_id).HasColumnName("state_id");
            this.Property(t => t.site_id).HasColumnName("site_id");

            // Relationships
            this.HasOptional(t => t.city)
                .WithMany(t => t.Sites)
                .HasForeignKey(d => new { d.state_id, d.city_id });
            this.HasOptional(t => t.ctry)
                .WithMany(t => t.sites)
                .HasForeignKey(d => d.ctry_id);
            this.HasOptional(t => t.regn)
                .WithMany(t => t.Sites)
                .HasForeignKey(d => new { d.ctry_id, d.regn_id });
            this.HasOptional(t => t.state)
                .WithMany(t => t.sites)
                .HasForeignKey(d => d.state_id);

        }
    }
}
