using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class cb_accredit_personMap : EntityTypeConfiguration<cb_accredit_person>
    {
        public cb_accredit_personMap()
        {
            // Primary Key
            this.HasKey(t => t.person_id);

            // Properties
            this.Property(t => t.accredit_source_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.accredit_type_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.cert_num)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.comments)
                .HasMaxLength(2000);

            this.Property(t => t.contact_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.doc)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.lic_num)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.prob_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.vn_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.person_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(35);

            // Table & Column Mappings
            this.ToTable("cb_accredit_person", "afm");
            this.Property(t => t.accredit_source_id).HasColumnName("accredit_source_id");
            this.Property(t => t.accredit_type_id).HasColumnName("accredit_type_id");
            this.Property(t => t.cert_num).HasColumnName("cert_num");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.contact_id).HasColumnName("contact_id");
            this.Property(t => t.date_accredited).HasColumnName("date_accredited");
            this.Property(t => t.date_expire).HasColumnName("date_expire");
            this.Property(t => t.doc).HasColumnName("doc");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.insp_num).HasColumnName("insp_num");
            this.Property(t => t.lic_num).HasColumnName("lic_num");
            this.Property(t => t.prob_type).HasColumnName("prob_type");
            this.Property(t => t.vn_id).HasColumnName("vn_id");
            this.Property(t => t.person_id).HasColumnName("person_id");

            // Relationships
            this.HasOptional(t => t.cb_accredit_source)
                .WithMany(t => t.cb_accredit_person)
                .HasForeignKey(d => d.accredit_source_id);
            this.HasOptional(t => t.cb_accredit_type)
                .WithMany(t => t.cb_accredit_person)
                .HasForeignKey(d => d.accredit_type_id);
            this.HasOptional(t => t.contact)
                .WithMany(t => t.CbAccreditPerson)
                .HasForeignKey(d => d.contact_id);
            this.HasOptional(t => t.em)
                .WithMany(t => t.CbAccreditPerson)
                .HasForeignKey(d => d.em_id);
            this.HasOptional(t => t.probtype)
                .WithMany(t => t.cb_accredit_person)
                .HasForeignKey(d => d.prob_type);
            this.HasOptional(t => t.vn)
                .WithMany(t => t.cb_accredit_person)
                .HasForeignKey(d => d.vn_id);

        }
    }
}
