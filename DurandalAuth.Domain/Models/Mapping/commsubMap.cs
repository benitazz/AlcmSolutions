using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class commsubMap : EntityTypeConfiguration<commsub>
    {
        public commsubMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.comm_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.project_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.project_type)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.subscriber)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.subscriber_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("commsubs", "afm");
            this.Property(t => t.comm_type).HasColumnName("comm_type");
            this.Property(t => t.is_active).HasColumnName("is_active");
            this.Property(t => t.project_id).HasColumnName("project_id");
            this.Property(t => t.project_type).HasColumnName("project_type");
            this.Property(t => t.subscriber).HasColumnName("subscriber");
            this.Property(t => t.subscriber_type).HasColumnName("subscriber_type");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasOptional(t => t.commtype)
                .WithMany(t => t.commsubs)
                .HasForeignKey(d => d.comm_type);
            this.HasOptional(t => t.project)
                .WithMany(t => t.commsubs)
                .HasForeignKey(d => d.project_id);
            this.HasOptional(t => t.projecttype)
                .WithMany(t => t.commsubs)
                .HasForeignKey(d => d.project_type);

        }
    }
}
