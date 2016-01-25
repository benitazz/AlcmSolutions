using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class resource_stdMap : EntityTypeConfiguration<resource_std>
    {
        public resource_stdMap()
        {
            // Primary Key
            this.HasKey(t => t.resource_std1);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(500);

            this.Property(t => t.resource_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.resource_name_01)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.resource_name_02)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.resource_name_03)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.resource_name_ch)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.resource_name_de)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.resource_name_es)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.resource_name_fr)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.resource_name_it)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.resource_name_jp)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.resource_name_ko)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.resource_name_nl)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.resource_name_no)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.resource_name_zh)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.resource_nature)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.tr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.vn_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.resource_std1)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("resource_std", "afm");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.resource_name).HasColumnName("resource_name");
            this.Property(t => t.resource_name_01).HasColumnName("resource_name_01");
            this.Property(t => t.resource_name_02).HasColumnName("resource_name_02");
            this.Property(t => t.resource_name_03).HasColumnName("resource_name_03");
            this.Property(t => t.resource_name_ch).HasColumnName("resource_name_ch");
            this.Property(t => t.resource_name_de).HasColumnName("resource_name_de");
            this.Property(t => t.resource_name_es).HasColumnName("resource_name_es");
            this.Property(t => t.resource_name_fr).HasColumnName("resource_name_fr");
            this.Property(t => t.resource_name_it).HasColumnName("resource_name_it");
            this.Property(t => t.resource_name_jp).HasColumnName("resource_name_jp");
            this.Property(t => t.resource_name_ko).HasColumnName("resource_name_ko");
            this.Property(t => t.resource_name_nl).HasColumnName("resource_name_nl");
            this.Property(t => t.resource_name_no).HasColumnName("resource_name_no");
            this.Property(t => t.resource_name_zh).HasColumnName("resource_name_zh");
            this.Property(t => t.resource_nature).HasColumnName("resource_nature");
            this.Property(t => t.tr_id).HasColumnName("tr_id");
            this.Property(t => t.vn_id).HasColumnName("vn_id");
            this.Property(t => t.resource_std1).HasColumnName("resource_std");

            // Relationships
            this.HasOptional(t => t.tr)
                .WithMany(t => t.resource_std)
                .HasForeignKey(d => d.tr_id);
            this.HasOptional(t => t.vn)
                .WithMany(t => t.resource_std)
                .HasForeignKey(d => d.vn_id);

        }
    }
}
