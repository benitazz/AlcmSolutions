using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class blMap : EntityTypeConfiguration<bl>
    {
        public blMap()
        {
            // Primary Key
            this.HasKey(t => t.bl_id);

            // Properties
            this.Property(t => t.ac_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.address1)
                .HasMaxLength(50);

            this.Property(t => t.address2)
                .HasMaxLength(50);

            this.Property(t => t.bldg_photo)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.campus)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.campus_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.city_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.comments)
                .HasMaxLength(5000);

            this.Property(t => t.construction_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.contact_name)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.contact_phone)
                .IsFixedLength()
                .HasMaxLength(24);

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

            this.Property(t => t.energy_baseline_year)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(7);

            this.Property(t => t.grp_uid)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.image_file)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.name)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.pr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.regn_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.state_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.use1)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.utility_type_cool)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.utility_type_heat)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.weather_source_id)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.weather_station_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.zip)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("bl", "afm");
            this.Property(t => t.ac_id).HasColumnName("ac_id");
            this.Property(t => t.address1).HasColumnName("address1");
            this.Property(t => t.address2).HasColumnName("address2");
            this.Property(t => t.area_avg_em).HasColumnName("area_avg_em");
            this.Property(t => t.area_avg_floor).HasColumnName("area_avg_floor");
            this.Property(t => t.area_bl_comn_gp).HasColumnName("area_bl_comn_gp");
            this.Property(t => t.area_bl_comn_nocup).HasColumnName("area_bl_comn_nocup");
            this.Property(t => t.area_bl_comn_ocup).HasColumnName("area_bl_comn_ocup");
            this.Property(t => t.area_bl_comn_rm).HasColumnName("area_bl_comn_rm");
            this.Property(t => t.area_bl_comn_serv).HasColumnName("area_bl_comn_serv");
            this.Property(t => t.area_em_dp).HasColumnName("area_em_dp");
            this.Property(t => t.area_ext_wall).HasColumnName("area_ext_wall");
            this.Property(t => t.area_gp).HasColumnName("area_gp");
            this.Property(t => t.area_gp_comn).HasColumnName("area_gp_comn");
            this.Property(t => t.area_gp_dp).HasColumnName("area_gp_dp");
            this.Property(t => t.area_gross_ext).HasColumnName("area_gross_ext");
            this.Property(t => t.area_gross_int).HasColumnName("area_gross_int");
            this.Property(t => t.area_ls_negotiated).HasColumnName("area_ls_negotiated");
            this.Property(t => t.area_nocup).HasColumnName("area_nocup");
            this.Property(t => t.area_nocup_comn).HasColumnName("area_nocup_comn");
            this.Property(t => t.area_nocup_dp).HasColumnName("area_nocup_dp");
            this.Property(t => t.area_ocup).HasColumnName("area_ocup");
            this.Property(t => t.area_ocup_comn).HasColumnName("area_ocup_comn");
            this.Property(t => t.area_ocup_dp).HasColumnName("area_ocup_dp");
            this.Property(t => t.area_remain).HasColumnName("area_remain");
            this.Property(t => t.area_rentable).HasColumnName("area_rentable");
            this.Property(t => t.area_rm).HasColumnName("area_rm");
            this.Property(t => t.area_rm_comn).HasColumnName("area_rm_comn");
            this.Property(t => t.area_rm_dp).HasColumnName("area_rm_dp");
            this.Property(t => t.area_serv).HasColumnName("area_serv");
            this.Property(t => t.area_su).HasColumnName("area_su");
            this.Property(t => t.area_usable).HasColumnName("area_usable");
            this.Property(t => t.area_vert_pen).HasColumnName("area_vert_pen");
            this.Property(t => t.auto_est_balance_points).HasColumnName("auto_est_balance_points");
            this.Property(t => t.bldg_photo).HasColumnName("bldg_photo");
            this.Property(t => t.campus).HasColumnName("campus");
            this.Property(t => t.campus_id).HasColumnName("campus_id");
            this.Property(t => t.city_id).HasColumnName("city_id");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.construction_type).HasColumnName("construction_type");
            this.Property(t => t.contact_name).HasColumnName("contact_name");
            this.Property(t => t.contact_phone).HasColumnName("contact_phone");
            this.Property(t => t.cooling_balance_point).HasColumnName("cooling_balance_point");
            this.Property(t => t.cooling_balance_point_manual).HasColumnName("cooling_balance_point_manual");
            this.Property(t => t.cost_operating_total).HasColumnName("cost_operating_total");
            this.Property(t => t.cost_other_total).HasColumnName("cost_other_total");
            this.Property(t => t.cost_sqft).HasColumnName("cost_sqft");
            this.Property(t => t.cost_tax_total).HasColumnName("cost_tax_total");
            this.Property(t => t.cost_utility_total).HasColumnName("cost_utility_total");
            this.Property(t => t.count_em).HasColumnName("count_em");
            this.Property(t => t.count_fl).HasColumnName("count_fl");
            this.Property(t => t.count_max_occup).HasColumnName("count_max_occup");
            this.Property(t => t.count_occup).HasColumnName("count_occup");
            this.Property(t => t.ctry_id).HasColumnName("ctry_id");
            this.Property(t => t.date_bl).HasColumnName("date_bl");
            this.Property(t => t.date_book_val).HasColumnName("date_book_val");
            this.Property(t => t.date_costs_end).HasColumnName("date_costs_end");
            this.Property(t => t.date_costs_last_calcd).HasColumnName("date_costs_last_calcd");
            this.Property(t => t.date_costs_start).HasColumnName("date_costs_start");
            this.Property(t => t.date_market_val).HasColumnName("date_market_val");
            this.Property(t => t.date_rehab).HasColumnName("date_rehab");
            this.Property(t => t.detail_dwg).HasColumnName("detail_dwg");
            this.Property(t => t.dwgname).HasColumnName("dwgname");
            this.Property(t => t.ehandle).HasColumnName("ehandle");
            this.Property(t => t.energy_baseline_year).HasColumnName("energy_baseline_year");
            this.Property(t => t.geo_objectid).HasColumnName("geo_objectid");
            this.Property(t => t.grp_uid).HasColumnName("grp_uid");
            this.Property(t => t.heating_balance_point).HasColumnName("heating_balance_point");
            this.Property(t => t.heating_balance_point_manual).HasColumnName("heating_balance_point_manual");
            this.Property(t => t.image_file).HasColumnName("image_file");
            this.Property(t => t.income_total).HasColumnName("income_total");
            this.Property(t => t.lat).HasColumnName("lat");
            this.Property(t => t.lon).HasColumnName("lon");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.pr_id).HasColumnName("pr_id");
            this.Property(t => t.ratio_ru).HasColumnName("ratio_ru");
            this.Property(t => t.ratio_ur).HasColumnName("ratio_ur");
            this.Property(t => t.regn_id).HasColumnName("regn_id");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.state_id).HasColumnName("state_id");
            this.Property(t => t.std_area_per_em).HasColumnName("std_area_per_em");
            this.Property(t => t.use1).HasColumnName("use1");
            this.Property(t => t.utility_type_cool).HasColumnName("utility_type_cool");
            this.Property(t => t.utility_type_heat).HasColumnName("utility_type_heat");
            this.Property(t => t.value_book).HasColumnName("value_book");
            this.Property(t => t.value_market).HasColumnName("value_market");
            this.Property(t => t.weather_source_id).HasColumnName("weather_source_id");
            this.Property(t => t.weather_station_id).HasColumnName("weather_station_id");
            this.Property(t => t.zip).HasColumnName("zip");
            this.Property(t => t.bl_id).HasColumnName("bl_id");

            // Relationships
            this.HasOptional(t => t.ac)
                .WithMany(t => t.bls)
                .HasForeignKey(d => d.ac_id);
            this.HasOptional(t => t.bill_type)
                .WithMany(t => t.bls)
                .HasForeignKey(d => d.utility_type_cool);
            this.HasOptional(t => t.bill_type1)
                .WithMany(t => t.bls1)
                .HasForeignKey(d => d.utility_type_heat);
            this.HasOptional(t => t.city)
                .WithMany(t => t.Bls)
                .HasForeignKey(d => new { d.state_id, d.city_id });
            this.HasOptional(t => t.ctry)
                .WithMany(t => t.bls)
                .HasForeignKey(d => d.ctry_id);
            this.HasRequired(t => t.energy_time_period)
                .WithMany(t => t.bls)
                .HasForeignKey(d => d.energy_baseline_year);
            this.HasOptional(t => t.property)
                .WithMany(t => t.bls)
                .HasForeignKey(d => d.pr_id);
            this.HasOptional(t => t.regn)
                .WithMany(t => t.Bls)
                .HasForeignKey(d => new { d.ctry_id, d.regn_id });
            this.HasOptional(t => t.site)
                .WithMany(t => t.bls)
                .HasForeignKey(d => d.site_id);
            this.HasOptional(t => t.state)
                .WithMany(t => t.bls)
                .HasForeignKey(d => d.state_id);
            this.HasOptional(t => t.weather_station_source)
                .WithMany(t => t.bls)
                .HasForeignKey(d => d.weather_source_id);
            this.HasOptional(t => t.weather_station)
                .WithMany(t => t.bls)
                .HasForeignKey(d => new { d.weather_source_id, d.weather_station_id });

        }
    }
}
