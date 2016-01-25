using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class vnMap : EntityTypeConfiguration<vn>
    {
        public vnMap()
        {
            // Primary Key
            this.HasKey(t => t.vn_id);

            // Properties
            this.Property(t => t.address1)
                .HasMaxLength(50);

            this.Property(t => t.address2)
                .HasMaxLength(50);

            this.Property(t => t.alt_contact)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.alt_fax)
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.alt_phone)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.alt_title)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.certifications)
                .HasMaxLength(2000);

            this.Property(t => t.city)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.code_1099)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.company)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.contact)
                .HasMaxLength(50);

            this.Property(t => t.country)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(200);

            this.Property(t => t.email)
                .HasMaxLength(50);

            this.Property(t => t.fax)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.fed_tax_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.insurance_cert1)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.insurance_cert2)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.mwbe_code)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.phone)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.postal_code)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.pref_rating)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.prob_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.services)
                .HasMaxLength(2000);

            this.Property(t => t.state)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.title)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.vendor_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.web_url)
                .IsFixedLength()
                .HasMaxLength(256);

            this.Property(t => t.vn_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("vn", "afm");
            this.Property(t => t.address1).HasColumnName("address1");
            this.Property(t => t.address2).HasColumnName("address2");
            this.Property(t => t.alt_contact).HasColumnName("alt_contact");
            this.Property(t => t.alt_fax).HasColumnName("alt_fax");
            this.Property(t => t.alt_phone).HasColumnName("alt_phone");
            this.Property(t => t.alt_title).HasColumnName("alt_title");
            this.Property(t => t.amt_bonded).HasColumnName("amt_bonded");
            this.Property(t => t.certifications).HasColumnName("certifications");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.code_1099).HasColumnName("code_1099");
            this.Property(t => t.company).HasColumnName("company");
            this.Property(t => t.contact).HasColumnName("contact");
            this.Property(t => t.country).HasColumnName("country");
            this.Property(t => t.date_exp).HasColumnName("date_exp");
            this.Property(t => t.date_last_updated).HasColumnName("date_last_updated");
            this.Property(t => t.delivery_perf).HasColumnName("delivery_perf");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.fax).HasColumnName("fax");
            this.Property(t => t.fed_tax_id).HasColumnName("fed_tax_id");
            this.Property(t => t.insurance_cert1).HasColumnName("insurance_cert1");
            this.Property(t => t.insurance_cert2).HasColumnName("insurance_cert2");
            this.Property(t => t.is_active).HasColumnName("is_active");
            this.Property(t => t.mwbe_code).HasColumnName("mwbe_code");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.postal_code).HasColumnName("postal_code");
            this.Property(t => t.pref_rating).HasColumnName("pref_rating");
            this.Property(t => t.prob_type).HasColumnName("prob_type");
            this.Property(t => t.services).HasColumnName("services");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.vendor_type).HasColumnName("vendor_type");
            this.Property(t => t.web_url).HasColumnName("web_url");
            this.Property(t => t.wr_from_reserve).HasColumnName("wr_from_reserve");
            this.Property(t => t.vn_id).HasColumnName("vn_id");

            // Relationships
            this.HasOptional(t => t.city1)
                .WithMany(t => t.Vns)
                .HasForeignKey(d => new { d.state, d.city });
            this.HasOptional(t => t.ctry)
                .WithMany(t => t.vns)
                .HasForeignKey(d => d.country);
            this.HasOptional(t => t.probtype)
                .WithMany(t => t.vns)
                .HasForeignKey(d => d.prob_type);
            this.HasOptional(t => t.state1)
                .WithMany(t => t.vns)
                .HasForeignKey(d => d.state);

        }
    }
}
