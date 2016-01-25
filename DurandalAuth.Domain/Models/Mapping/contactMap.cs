using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class contactMap : EntityTypeConfiguration<Contact>
    {
        public contactMap()
        {
            // Primary Key
            this.HasKey(t => t.ContactId);

            // Properties
            this.Property(t => t.ContactPhoto)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.ContactType)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.county_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.ctry_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.Email)
                .HasMaxLength(64);

            this.Property(t => t.Fax)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.Honorific)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.ImageFile)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.LsId)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.NameFirst)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.NameLast)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.Notes)
                .HasMaxLength(2000);

            this.Property(t => t.Option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.Option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.Pager)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.Phone)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.Pin)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.PrId)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.regn_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.state_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.Status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.TaxAuthType)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.Zip)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Address1)
                .HasMaxLength(64);

            this.Property(t => t.Address2)
                .HasMaxLength(64);

            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.CellularNumber)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.city_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.Company)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.ContactId)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("contact", "afm");
            this.Property(t => t.ContactPhoto).HasColumnName("contact_photo");
            this.Property(t => t.ContactType).HasColumnName("contact_type");
            this.Property(t => t.county_id).HasColumnName("county_id");
            this.Property(t => t.ctry_id).HasColumnName("ctry_id");
            this.Property(t => t.Email).HasColumnName("email");
            this.Property(t => t.Fax).HasColumnName("fax");
            this.Property(t => t.Honorific).HasColumnName("honorific");
            this.Property(t => t.ImageFile).HasColumnName("image_file");
            this.Property(t => t.LsId).HasColumnName("ls_id");
            this.Property(t => t.NameFirst).HasColumnName("name_first");
            this.Property(t => t.NameLast).HasColumnName("name_last");
            this.Property(t => t.Notes).HasColumnName("notes");
            this.Property(t => t.Option1).HasColumnName("option1");
            this.Property(t => t.Option2).HasColumnName("option2");
            this.Property(t => t.Pager).HasColumnName("pager");
            this.Property(t => t.Phone).HasColumnName("phone");
            this.Property(t => t.Pin).HasColumnName("pin");
            this.Property(t => t.PrId).HasColumnName("pr_id");
            this.Property(t => t.regn_id).HasColumnName("regn_id");
            this.Property(t => t.state_id).HasColumnName("state_id");
            this.Property(t => t.Status).HasColumnName("status");
            this.Property(t => t.TaxAuthType).HasColumnName("tax_auth_type");
            this.Property(t => t.Zip).HasColumnName("zip");
            this.Property(t => t.Address1).HasColumnName("address1");
            this.Property(t => t.Address2).HasColumnName("address2");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.CellularNumber).HasColumnName("cellular_number");
            this.Property(t => t.city_id).HasColumnName("city_id");
            this.Property(t => t.Company).HasColumnName("company");
            this.Property(t => t.ContactId).HasColumnName("contact_id");

            // Relationships
            this.HasMany(t => t.Ls)
                .WithMany(t => t.contacts1)
                .Map(m =>
                    {
                        m.ToTable("ls_contacts", "afm");
                        m.MapLeftKey("contact_id");
                        m.MapRightKey("ls_id");
                    });

            this.HasOptional(t => t.Bl)
                .WithMany(t => t.contacts)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.City)
                .WithMany(t => t.Contacts)
                .HasForeignKey(d => new { state_id = d.state_id, city_id = d.city_id });
            this.HasOptional(t => t.Company1)
                .WithMany(t => t.Contacts)
                .HasForeignKey(d => d.Company);
            this.HasOptional(t => t.County)
                .WithMany(t => t.Contacts)
                .HasForeignKey(d => new { state_id = d.state_id, county_id = d.county_id });
            this.HasOptional(t => t.Ctry)
                .WithMany(t => t.contacts)
                .HasForeignKey(d => d.ctry_id);
            this.HasOptional(t => t.l)
                .WithMany(t => t.contacts)
                .HasForeignKey(d => d.LsId);
            this.HasOptional(t => t.Property)
                .WithMany(t => t.contacts)
                .HasForeignKey(d => d.PrId);
            this.HasOptional(t => t.Regn)
                .WithMany(t => t.Contacts)
                .HasForeignKey(d => new { ctry_id = d.ctry_id, regn_id = d.regn_id });
            this.HasOptional(t => t.State)
                .WithMany(t => t.contacts)
                .HasForeignKey(d => d.state_id);

        }
    }
}
