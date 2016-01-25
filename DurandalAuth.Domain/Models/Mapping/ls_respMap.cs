using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ls_respMap : EntityTypeConfiguration<ls_resp>
    {
        public ls_respMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ls_id, t.resp_id });

            // Properties
            this.Property(t => t.clause_type_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.contact_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.description)
                .HasMaxLength(2000);

            this.Property(t => t.doc)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.reference_loc)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.resp_party)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.resp_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.ls_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.resp_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("ls_resp", "afm");
            this.Property(t => t.clause_type_id).HasColumnName("clause_type_id");
            this.Property(t => t.contact_id).HasColumnName("contact_id");
            this.Property(t => t.date_end).HasColumnName("date_end");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.dates_match_lease).HasColumnName("dates_match_lease");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.doc).HasColumnName("doc");
            this.Property(t => t.reference_loc).HasColumnName("reference_loc");
            this.Property(t => t.resp_party).HasColumnName("resp_party");
            this.Property(t => t.resp_type).HasColumnName("resp_type");
            this.Property(t => t.ls_id).HasColumnName("ls_id");
            this.Property(t => t.resp_id).HasColumnName("resp_id");

            // Relationships
            this.HasOptional(t => t.contact)
                .WithMany(t => t.LsResp)
                .HasForeignKey(d => d.contact_id);
            this.HasRequired(t => t.l)
                .WithMany(t => t.ls_resp)
                .HasForeignKey(d => d.ls_id);
            this.HasOptional(t => t.ls_clause_type)
                .WithMany(t => t.ls_resp)
                .HasForeignKey(d => d.clause_type_id);

        }
    }
}
