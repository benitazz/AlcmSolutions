using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class poMap : EntityTypeConfiguration<po>
    {
        public poMap()
        {
            // Primary Key
            this.HasKey(t => t.po_id);

            // Properties
            this.Property(t => t.em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.terms)
                .HasMaxLength(50);

            this.Property(t => t.vn_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.po_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("po", "afm");
            this.Property(t => t.date_paid).HasColumnName("date_paid");
            this.Property(t => t.date_received).HasColumnName("date_received");
            this.Property(t => t.date_request).HasColumnName("date_request");
            this.Property(t => t.date_sent).HasColumnName("date_sent");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.federal_tax).HasColumnName("federal_tax");
            this.Property(t => t.shipping).HasColumnName("shipping");
            this.Property(t => t.state_tax).HasColumnName("state_tax");
            this.Property(t => t.terms).HasColumnName("terms");
            this.Property(t => t.vn_id).HasColumnName("vn_id");
            this.Property(t => t.po_id).HasColumnName("po_id");

            // Relationships
            this.HasOptional(t => t.em)
                .WithMany(t => t.poes)
                .HasForeignKey(d => d.em_id);
            this.HasRequired(t => t.vn)
                .WithMany(t => t.poes)
                .HasForeignKey(d => d.vn_id);

        }
    }
}
