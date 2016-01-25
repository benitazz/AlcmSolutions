using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class buMap : EntityTypeConfiguration<bu>
    {
        public buMap()
        {
            // Primary Key
            this.HasKey(t => t.bu_id);

            // Properties
            this.Property(t => t.name)
                .HasMaxLength(40);

            this.Property(t => t.bu_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("bu", "afm");
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
            this.Property(t => t.cost).HasColumnName("cost");
            this.Property(t => t.count_em).HasColumnName("count_em");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.bu_id).HasColumnName("bu_id");
        }
    }
}
