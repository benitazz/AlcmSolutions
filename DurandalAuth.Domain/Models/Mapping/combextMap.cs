using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class combextMap : EntityTypeConfiguration<combext>
    {
        public combextMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.description)
                .HasMaxLength(500);

            this.Property(t => t.em_id)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.extension)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.fp_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.jk_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.phone)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.source_table)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.tc_use)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.telext_id)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("combext", "afm");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.em_id).HasColumnName("em_id");
            this.Property(t => t.extension).HasColumnName("extension");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.fp_id).HasColumnName("fp_id");
            this.Property(t => t.jk_id).HasColumnName("jk_id");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.source_table).HasColumnName("source_table");
            this.Property(t => t.tc_use).HasColumnName("tc_use");
            this.Property(t => t.telext_id).HasColumnName("telext_id");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasOptional(t => t.bl)
                .WithMany(t => t.combexts)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.em)
                .WithMany(t => t.Combexts)
                .HasForeignKey(d => d.em_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.Combexts)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.fp)
                .WithMany(t => t.combexts)
                .HasForeignKey(d => d.fp_id);
            this.HasOptional(t => t.jk)
                .WithMany(t => t.combexts)
                .HasForeignKey(d => d.jk_id);
            this.HasOptional(t => t.rm)
                .WithMany(t => t.combexts)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });
            this.HasOptional(t => t.telext)
                .WithMany(t => t.combexts)
                .HasForeignKey(d => d.telext_id);

        }
    }
}
