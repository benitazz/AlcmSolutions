using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class dvMap : EntityTypeConfiguration<dv>
    {
        public dvMap()
        {
            // Primary Key
            this.HasKey(t => t.dv_id);

            // Properties
            this.Property(t => t.bu_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.head)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.hpattern_acad)
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

            this.Property(t => t.dv_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("dv", "afm");
            this.Property(t => t.area_avg_em).HasColumnName("area_avg_em");
            this.Property(t => t.area_chargable).HasColumnName("area_chargable");
            this.Property(t => t.area_comn).HasColumnName("area_comn");
            this.Property(t => t.area_comn_gp).HasColumnName("area_comn_gp");
            this.Property(t => t.area_comn_nocup).HasColumnName("area_comn_nocup");
            this.Property(t => t.area_comn_ocup).HasColumnName("area_comn_ocup");
            this.Property(t => t.area_comn_rm).HasColumnName("area_comn_rm");
            this.Property(t => t.area_comn_serv).HasColumnName("area_comn_serv");
            this.Property(t => t.area_gp).HasColumnName("area_gp");
            this.Property(t => t.area_nocup).HasColumnName("area_nocup");
            this.Property(t => t.area_ocup).HasColumnName("area_ocup");
            this.Property(t => t.area_rm).HasColumnName("area_rm");
            this.Property(t => t.area_second_circ).HasColumnName("area_second_circ");
            this.Property(t => t.bu_id).HasColumnName("bu_id");
            this.Property(t => t.cost).HasColumnName("cost");
            this.Property(t => t.count_em).HasColumnName("count_em");
            this.Property(t => t.head).HasColumnName("head");
            this.Property(t => t.hpattern_acad).HasColumnName("hpattern_acad");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.dv_id).HasColumnName("dv_id");

            // Relationships
            this.HasOptional(t => t.bu)
                .WithMany(t => t.dvs)
                .HasForeignKey(d => d.bu_id);

        }
    }
}
