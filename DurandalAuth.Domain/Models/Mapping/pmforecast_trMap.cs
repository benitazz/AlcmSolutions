using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class pmforecast_trMap : EntityTypeConfiguration<pmforecast_tr>
    {
        public pmforecast_trMap()
        {
            // Primary Key
            this.HasKey(t => new { t.eq_id, t.pmp_id, t.tr_id });

            // Properties
            this.Property(t => t.eq_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.pmp_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.tr_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("pmforecast_tr", "afm");
            this.Property(t => t.week_01).HasColumnName("week_01");
            this.Property(t => t.week_02).HasColumnName("week_02");
            this.Property(t => t.week_03).HasColumnName("week_03");
            this.Property(t => t.week_04).HasColumnName("week_04");
            this.Property(t => t.week_05).HasColumnName("week_05");
            this.Property(t => t.week_06).HasColumnName("week_06");
            this.Property(t => t.week_07).HasColumnName("week_07");
            this.Property(t => t.week_08).HasColumnName("week_08");
            this.Property(t => t.week_09).HasColumnName("week_09");
            this.Property(t => t.week_10).HasColumnName("week_10");
            this.Property(t => t.week_11).HasColumnName("week_11");
            this.Property(t => t.week_12).HasColumnName("week_12");
            this.Property(t => t.week_13).HasColumnName("week_13");
            this.Property(t => t.week_14).HasColumnName("week_14");
            this.Property(t => t.week_15).HasColumnName("week_15");
            this.Property(t => t.week_16).HasColumnName("week_16");
            this.Property(t => t.week_17).HasColumnName("week_17");
            this.Property(t => t.week_18).HasColumnName("week_18");
            this.Property(t => t.week_19).HasColumnName("week_19");
            this.Property(t => t.week_20).HasColumnName("week_20");
            this.Property(t => t.week_21).HasColumnName("week_21");
            this.Property(t => t.week_22).HasColumnName("week_22");
            this.Property(t => t.week_23).HasColumnName("week_23");
            this.Property(t => t.week_24).HasColumnName("week_24");
            this.Property(t => t.week_25).HasColumnName("week_25");
            this.Property(t => t.week_26).HasColumnName("week_26");
            this.Property(t => t.week_27).HasColumnName("week_27");
            this.Property(t => t.week_28).HasColumnName("week_28");
            this.Property(t => t.week_29).HasColumnName("week_29");
            this.Property(t => t.week_30).HasColumnName("week_30");
            this.Property(t => t.week_31).HasColumnName("week_31");
            this.Property(t => t.week_32).HasColumnName("week_32");
            this.Property(t => t.week_33).HasColumnName("week_33");
            this.Property(t => t.week_34).HasColumnName("week_34");
            this.Property(t => t.week_35).HasColumnName("week_35");
            this.Property(t => t.week_36).HasColumnName("week_36");
            this.Property(t => t.week_37).HasColumnName("week_37");
            this.Property(t => t.week_38).HasColumnName("week_38");
            this.Property(t => t.week_39).HasColumnName("week_39");
            this.Property(t => t.week_40).HasColumnName("week_40");
            this.Property(t => t.week_41).HasColumnName("week_41");
            this.Property(t => t.week_42).HasColumnName("week_42");
            this.Property(t => t.week_43).HasColumnName("week_43");
            this.Property(t => t.week_44).HasColumnName("week_44");
            this.Property(t => t.week_45).HasColumnName("week_45");
            this.Property(t => t.week_46).HasColumnName("week_46");
            this.Property(t => t.week_47).HasColumnName("week_47");
            this.Property(t => t.week_48).HasColumnName("week_48");
            this.Property(t => t.week_49).HasColumnName("week_49");
            this.Property(t => t.week_50).HasColumnName("week_50");
            this.Property(t => t.week_51).HasColumnName("week_51");
            this.Property(t => t.week_52).HasColumnName("week_52");
            this.Property(t => t.eq_id).HasColumnName("eq_id");
            this.Property(t => t.pmp_id).HasColumnName("pmp_id");
            this.Property(t => t.tr_id).HasColumnName("tr_id");
        }
    }
}
