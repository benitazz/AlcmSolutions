using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class companyMap : EntityTypeConfiguration<Company>
    {
        public companyMap()
        {
            // Primary Key
            this.HasKey(t => t.Company1);

            // Properties
            this.Property(t => t.county_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.ctry_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            this.Property(t => t.Fax)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.Option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.Option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.Phone)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.regn_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.state_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.WebUrl)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.Website)
                .HasMaxLength(256);

            this.Property(t => t.Zip)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Address1)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.Address2)
                .IsFixedLength()
                .HasMaxLength(48);

            this.Property(t => t.AltFax)
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.AltPhone)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.city_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.Comments)
                .HasMaxLength(2000);

            this.Property(t => t.Company1)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("company", "afm");
            this.Property(t => t.county_id).HasColumnName("county_id");
            this.Property(t => t.ctry_id).HasColumnName("ctry_id");
            this.Property(t => t.DateLastUpdated).HasColumnName("date_last_updated");
            this.Property(t => t.Email).HasColumnName("email");
            this.Property(t => t.Fax).HasColumnName("fax");
            this.Property(t => t.Option1).HasColumnName("option1");
            this.Property(t => t.Option2).HasColumnName("option2");
            this.Property(t => t.Phone).HasColumnName("phone");
            this.Property(t => t.regn_id).HasColumnName("regn_id");
            this.Property(t => t.state_id).HasColumnName("state_id");
            this.Property(t => t.WebUrl).HasColumnName("web_url");
            this.Property(t => t.Website).HasColumnName("website");
            this.Property(t => t.Zip).HasColumnName("zip");
            this.Property(t => t.Address1).HasColumnName("address1");
            this.Property(t => t.Address2).HasColumnName("address2");
            this.Property(t => t.AltFax).HasColumnName("alt_fax");
            this.Property(t => t.AltPhone).HasColumnName("alt_phone");
            this.Property(t => t.city_id).HasColumnName("city_id");
            this.Property(t => t.Comments).HasColumnName("comments");
            this.Property(t => t.Company1).HasColumnName("company");

            // Relationships
            this.HasOptional(t => t.City)
                .WithMany(t => t.Companies)
                .HasForeignKey(d => new { state_id = d.state_id, city_id = d.city_id });
            this.HasOptional(t => t.County)
                .WithMany(t => t.Companies)
                .HasForeignKey(d => new { state_id = d.state_id, county_id = d.county_id });
            this.HasOptional(t => t.Ctry)
                .WithMany(t => t.companies)
                .HasForeignKey(d => d.ctry_id);
            this.HasOptional(t => t.Regn)
                .WithMany(t => t.Companies)
                .HasForeignKey(d => new { ctry_id = d.ctry_id, regn_id = d.regn_id });
            this.HasOptional(t => t.State)
                .WithMany(t => t.companies)
                .HasForeignKey(d => d.state_id);

        }
    }
}
