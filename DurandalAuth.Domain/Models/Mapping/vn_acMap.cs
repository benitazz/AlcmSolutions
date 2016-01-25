using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class vn_acMap : EntityTypeConfiguration<vn_ac>
    {
        public vn_acMap()
        {
            // Primary Key
            this.HasKey(t => new { t.vn_id, t.vn_ac_id });

            // Properties
            this.Property(t => t.bill_address1)
                .HasMaxLength(64);

            this.Property(t => t.bill_address2)
                .HasMaxLength(64);

            this.Property(t => t.bill_city_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.bill_ctry_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.bill_postal_code)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.bill_state_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.bill_type_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.bl_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.eq_id)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.remit_address1)
                .HasMaxLength(64);

            this.Property(t => t.remit_address2)
                .HasMaxLength(64);

            this.Property(t => t.remit_city_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.remit_ctry_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.remit_postal_code)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.remit_state_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.serv_address1)
                .HasMaxLength(64);

            this.Property(t => t.serv_address2)
                .HasMaxLength(64);

            this.Property(t => t.serv_city_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.serv_ctry_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.serv_postal_code)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.serv_state_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.site_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.vn_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.vn_ac_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("vn_ac", "afm");
            this.Property(t => t.bill_address1).HasColumnName("bill_address1");
            this.Property(t => t.bill_address2).HasColumnName("bill_address2");
            this.Property(t => t.bill_city_id).HasColumnName("bill_city_id");
            this.Property(t => t.bill_ctry_id).HasColumnName("bill_ctry_id");
            this.Property(t => t.bill_postal_code).HasColumnName("bill_postal_code");
            this.Property(t => t.bill_state_id).HasColumnName("bill_state_id");
            this.Property(t => t.bill_type_id).HasColumnName("bill_type_id");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.eq_id).HasColumnName("eq_id");
            this.Property(t => t.remit_address1).HasColumnName("remit_address1");
            this.Property(t => t.remit_address2).HasColumnName("remit_address2");
            this.Property(t => t.remit_city_id).HasColumnName("remit_city_id");
            this.Property(t => t.remit_ctry_id).HasColumnName("remit_ctry_id");
            this.Property(t => t.remit_postal_code).HasColumnName("remit_postal_code");
            this.Property(t => t.remit_state_id).HasColumnName("remit_state_id");
            this.Property(t => t.serv_address1).HasColumnName("serv_address1");
            this.Property(t => t.serv_address2).HasColumnName("serv_address2");
            this.Property(t => t.serv_city_id).HasColumnName("serv_city_id");
            this.Property(t => t.serv_ctry_id).HasColumnName("serv_ctry_id");
            this.Property(t => t.serv_postal_code).HasColumnName("serv_postal_code");
            this.Property(t => t.serv_state_id).HasColumnName("serv_state_id");
            this.Property(t => t.site_id).HasColumnName("site_id");
            this.Property(t => t.vn_id).HasColumnName("vn_id");
            this.Property(t => t.vn_ac_id).HasColumnName("vn_ac_id");

            // Relationships
            this.HasRequired(t => t.bill_type)
                .WithMany(t => t.vn_ac)
                .HasForeignKey(d => d.bill_type_id);
            this.HasRequired(t => t.bl)
                .WithMany(t => t.vn_ac)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.city)
                .WithMany(t => t.VnAc)
                .HasForeignKey(d => new { d.bill_state_id, d.bill_city_id });
            this.HasOptional(t => t.city1)
                .WithMany(t => t.VnAc1)
                .HasForeignKey(d => new { d.remit_state_id, d.remit_city_id });
            this.HasOptional(t => t.city2)
                .WithMany(t => t.VnAc2)
                .HasForeignKey(d => new { d.serv_state_id, d.serv_city_id });
            this.HasOptional(t => t.ctry)
                .WithMany(t => t.vn_ac)
                .HasForeignKey(d => d.bill_ctry_id);
            this.HasOptional(t => t.ctry1)
                .WithMany(t => t.vn_ac1)
                .HasForeignKey(d => d.remit_ctry_id);
            this.HasOptional(t => t.ctry2)
                .WithMany(t => t.vn_ac2)
                .HasForeignKey(d => d.serv_ctry_id);
            this.HasOptional(t => t.eq)
                .WithMany(t => t.vn_ac)
                .HasForeignKey(d => d.eq_id);
            this.HasOptional(t => t.site)
                .WithMany(t => t.vn_ac)
                .HasForeignKey(d => d.site_id);
            this.HasOptional(t => t.state)
                .WithMany(t => t.vn_ac)
                .HasForeignKey(d => d.bill_state_id);
            this.HasOptional(t => t.state1)
                .WithMany(t => t.vn_ac1)
                .HasForeignKey(d => d.remit_state_id);
            this.HasOptional(t => t.state2)
                .WithMany(t => t.vn_ac2)
                .HasForeignKey(d => d.serv_state_id);
            this.HasRequired(t => t.vn)
                .WithMany(t => t.vn_ac)
                .HasForeignKey(d => d.vn_id);

        }
    }
}
