using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class opMap : EntityTypeConfiguration<op>
    {
        public opMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ls_id, t.op_id });

            // Properties
            this.Property(t => t.comments)
                .HasMaxLength(2000);

            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.doc)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.exercised_by)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.image_doc1)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.image_doc2)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.op_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.who_can_exercise)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.ls_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.op_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("op", "afm");
            this.Property(t => t.area).HasColumnName("area");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.cost_est).HasColumnName("cost_est");
            this.Property(t => t.date_exercised).HasColumnName("date_exercised");
            this.Property(t => t.date_exercising_applicable).HasColumnName("date_exercising_applicable");
            this.Property(t => t.date_option).HasColumnName("date_option");
            this.Property(t => t.date_option_introduced).HasColumnName("date_option_introduced");
            this.Property(t => t.date_review).HasColumnName("date_review");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.dates_match_lease).HasColumnName("dates_match_lease");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.doc).HasColumnName("doc");
            this.Property(t => t.exercised_by).HasColumnName("exercised_by");
            this.Property(t => t.image_doc1).HasColumnName("image_doc1");
            this.Property(t => t.image_doc2).HasColumnName("image_doc2");
            this.Property(t => t.op_type).HasColumnName("op_type");
            this.Property(t => t.who_can_exercise).HasColumnName("who_can_exercise");
            this.Property(t => t.ls_id).HasColumnName("ls_id");
            this.Property(t => t.op_id).HasColumnName("op_id");

            // Relationships
            this.HasOptional(t => t.em)
                .WithMany(t => t.ops)
                .HasForeignKey(d => d.exercised_by);
            this.HasRequired(t => t.l)
                .WithMany(t => t.ops)
                .HasForeignKey(d => d.ls_id);

        }
    }
}
