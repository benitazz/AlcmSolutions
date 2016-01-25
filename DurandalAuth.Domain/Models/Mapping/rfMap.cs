using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class rfMap : EntityTypeConfiguration<Rf>
    {
        public rfMap()
        {
            // Primary Key
            this.HasKey(t => t.auto_number);

            // Properties
            this.Property(t => t.BaseType)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.clgfnsh)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.clghgt)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.clgmatl)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.dwgname)
                .HasMaxLength(128);

            this.Property(t => t.ehandle)
                .HasMaxLength(64);

            this.Property(t => t.ewfnsh)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.ewmatl)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.fl_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.flfnsh)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.flmatl)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.layer_name)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.name)
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.nwfnsh)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.nwmatl)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.remarks)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.rf_id)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.rm_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.swfnsh)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.swmatl)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.wwfnsh)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.wwmatl)
                .IsFixedLength()
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("rf", "afm");
            this.Property(t => t.BaseType).HasColumnName("base");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.clgfnsh).HasColumnName("clgfnsh");
            this.Property(t => t.clghgt).HasColumnName("clghgt");
            this.Property(t => t.clgmatl).HasColumnName("clgmatl");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.dwgname).HasColumnName("dwgname");
            this.Property(t => t.ehandle).HasColumnName("ehandle");
            this.Property(t => t.ewfnsh).HasColumnName("ewfnsh");
            this.Property(t => t.ewmatl).HasColumnName("ewmatl");
            this.Property(t => t.fl_id).HasColumnName("fl_id");
            this.Property(t => t.flfnsh).HasColumnName("flfnsh");
            this.Property(t => t.flmatl).HasColumnName("flmatl");
            this.Property(t => t.layer_name).HasColumnName("layer_name");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.nwfnsh).HasColumnName("nwfnsh");
            this.Property(t => t.nwmatl).HasColumnName("nwmatl");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.remarks).HasColumnName("remarks");
            this.Property(t => t.rf_id).HasColumnName("rf_id");
            this.Property(t => t.rm_id).HasColumnName("rm_id");
            this.Property(t => t.swfnsh).HasColumnName("swfnsh");
            this.Property(t => t.swmatl).HasColumnName("swmatl");
            this.Property(t => t.wwfnsh).HasColumnName("wwfnsh");
            this.Property(t => t.wwmatl).HasColumnName("wwmatl");
            this.Property(t => t.auto_number).HasColumnName("auto_number");

            // Relationships
            this.HasOptional(t => t.bl)
                .WithMany(t => t.rfs)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.fl)
                .WithMany(t => t.Rfs)
                .HasForeignKey(d => new { d.bl_id, d.fl_id });
            this.HasOptional(t => t.rffnsh)
                .WithMany(t => t.rfs)
                .HasForeignKey(d => d.clgfnsh);
            this.HasOptional(t => t.rfmatl)
                .WithMany(t => t.rfs)
                .HasForeignKey(d => d.clgmatl);
            this.HasOptional(t => t.rffnsh1)
                .WithMany(t => t.rfs1)
                .HasForeignKey(d => d.ewfnsh);
            this.HasOptional(t => t.rfmatl1)
                .WithMany(t => t.rfs1)
                .HasForeignKey(d => d.ewmatl);
            this.HasOptional(t => t.rffnsh2)
                .WithMany(t => t.rfs2)
                .HasForeignKey(d => d.flfnsh);
            this.HasOptional(t => t.rfmatl2)
                .WithMany(t => t.rfs2)
                .HasForeignKey(d => d.flmatl);
            this.HasOptional(t => t.rffnsh3)
                .WithMany(t => t.rfs3)
                .HasForeignKey(d => d.nwfnsh);
            this.HasOptional(t => t.rfmatl3)
                .WithMany(t => t.rfs3)
                .HasForeignKey(d => d.nwmatl);
            this.HasOptional(t => t.rm)
                .WithMany(t => t.rfs)
                .HasForeignKey(d => new { d.bl_id, d.fl_id, d.rm_id });
            this.HasOptional(t => t.rffnsh4)
                .WithMany(t => t.rfs4)
                .HasForeignKey(d => d.swfnsh);
            this.HasOptional(t => t.rfmatl4)
                .WithMany(t => t.rfs4)
                .HasForeignKey(d => d.swmatl);
            this.HasOptional(t => t.rffnsh5)
                .WithMany(t => t.rfs5)
                .HasForeignKey(d => d.wwfnsh);
            this.HasOptional(t => t.rfmatl5)
                .WithMany(t => t.rfs5)
                .HasForeignKey(d => d.wwmatl);

        }
    }
}
