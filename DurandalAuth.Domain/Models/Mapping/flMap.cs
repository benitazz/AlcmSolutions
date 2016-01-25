using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class flMap : EntityTypeConfiguration<Fl>
    {
        public flMap()
        {
            // Primary Key
            this.HasKey(t => new { bl_id = t.bl_id, fl_id = t.fl_id });

            // Properties
            this.Property(t => t.ImageFile)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.Name)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.Option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.Option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.ProrateRemain)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.DetailDwg)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.Dwgname)
                .HasMaxLength(128);

            this.Property(t => t.Ehandle)
                .HasMaxLength(64);

            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.fl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("fl", "afm");
            this.Property(t => t.AreaAllocated).HasColumnName("area_allocated");
            this.Property(t => t.AreaEmDp).HasColumnName("area_em_dp");
            this.Property(t => t.AreaExtWall).HasColumnName("area_ext_wall");
            this.Property(t => t.AreaFlComnGp).HasColumnName("area_fl_comn_gp");
            this.Property(t => t.AreaFlComnNocup).HasColumnName("area_fl_comn_nocup");
            this.Property(t => t.AreaFlComnOcup).HasColumnName("area_fl_comn_ocup");
            this.Property(t => t.AreaFlComnRm).HasColumnName("area_fl_comn_rm");
            this.Property(t => t.AreaFlComnServ).HasColumnName("area_fl_comn_serv");
            this.Property(t => t.AreaGp).HasColumnName("area_gp");
            this.Property(t => t.AreaGpComn).HasColumnName("area_gp_comn");
            this.Property(t => t.AreaGpDp).HasColumnName("area_gp_dp");
            this.Property(t => t.AreaGrossExt).HasColumnName("area_gross_ext");
            this.Property(t => t.AreaGrossInt).HasColumnName("area_gross_int");
            this.Property(t => t.AreaManual).HasColumnName("area_manual");
            this.Property(t => t.AreaNocup).HasColumnName("area_nocup");
            this.Property(t => t.AreaNocupComn).HasColumnName("area_nocup_comn");
            this.Property(t => t.AreaNocupDp).HasColumnName("area_nocup_dp");
            this.Property(t => t.AreaOcup).HasColumnName("area_ocup");
            this.Property(t => t.AreaOcupComn).HasColumnName("area_ocup_comn");
            this.Property(t => t.AreaOcupDp).HasColumnName("area_ocup_dp");
            this.Property(t => t.AreaRemain).HasColumnName("area_remain");
            this.Property(t => t.AreaRentable).HasColumnName("area_rentable");
            this.Property(t => t.AreaRm).HasColumnName("area_rm");
            this.Property(t => t.AreaRmComn).HasColumnName("area_rm_comn");
            this.Property(t => t.AreaRmDp).HasColumnName("area_rm_dp");
            this.Property(t => t.AreaServ).HasColumnName("area_serv");
            this.Property(t => t.AreaSu).HasColumnName("area_su");
            this.Property(t => t.AreaUsable).HasColumnName("area_usable");
            this.Property(t => t.AreaVertPen).HasColumnName("area_vert_pen");
            this.Property(t => t.HeightNom).HasColumnName("height_nom");
            this.Property(t => t.ImageFile).HasColumnName("image_file");
            this.Property(t => t.Name).HasColumnName("name");
            this.Property(t => t.Option1).HasColumnName("option1");
            this.Property(t => t.Option2).HasColumnName("option2");
            this.Property(t => t.ProrateRemain).HasColumnName("prorate_remain");
            this.Property(t => t.RatioRu).HasColumnName("ratio_ru");
            this.Property(t => t.RatioUr).HasColumnName("ratio_ur");
            this.Property(t => t.StdAreaPerEm).HasColumnName("std_area_per_em");
            this.Property(t => t.CostSqft).HasColumnName("cost_sqft");
            this.Property(t => t.CountEm).HasColumnName("count_em");
            this.Property(t => t.DetailDwg).HasColumnName("detail_dwg");
            this.Property(t => t.Dwgname).HasColumnName("dwgname");
            this.Property(t => t.Ehandle).HasColumnName("ehandle");
            this.Property(t => t.ElevationNom).HasColumnName("elevation_nom");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.fl_id).HasColumnName("fl_id");

            // Relationships
            this.HasRequired(t => t.Bl)
                .WithMany(t => t.fls)
                .HasForeignKey(d => d.bl_id);

        }
    }
}
