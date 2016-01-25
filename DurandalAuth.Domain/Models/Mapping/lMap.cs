using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class lMap : EntityTypeConfiguration<l>
    {
        public lMap()
        {
            // Primary Key
            this.HasKey(t => t.ls_id);

            // Properties
            this.Property(t => t.ac_id)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.bl_id)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.comments)
                .HasMaxLength(2000);

            this.Property(t => t.description)
                .HasMaxLength(512);

            this.Property(t => t.doc)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.floors)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.hpattern)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.hpattern_acad)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.image_doc1)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.image_doc2)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.image_doc3)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.landlord_tenant)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.ld_contact)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.ld_name)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.lease_sublease)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.lease_type)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.ls_parent_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option1)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.option2)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.pr_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.space_use)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.template_name)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.tn_contact)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.tn_name)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.ls_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("ls", "afm");
            this.Property(t => t.ac_id).HasColumnName("ac_id");
            this.Property(t => t.amount_base_rent).HasColumnName("amount_base_rent");
            this.Property(t => t.amount_operating).HasColumnName("amount_operating");
            this.Property(t => t.amount_other).HasColumnName("amount_other");
            this.Property(t => t.amount_pct_rent).HasColumnName("amount_pct_rent");
            this.Property(t => t.amount_security).HasColumnName("amount_security");
            this.Property(t => t.amount_taxes).HasColumnName("amount_taxes");
            this.Property(t => t.amount_tot_rent_exp).HasColumnName("amount_tot_rent_exp");
            this.Property(t => t.amount_tot_rent_inc).HasColumnName("amount_tot_rent_inc");
            this.Property(t => t.area_common).HasColumnName("area_common");
            this.Property(t => t.area_negotiated).HasColumnName("area_negotiated");
            this.Property(t => t.area_rentable).HasColumnName("area_rentable");
            this.Property(t => t.area_usable).HasColumnName("area_usable");
            this.Property(t => t.automatic_renewal).HasColumnName("automatic_renewal");
            this.Property(t => t.bl_id).HasColumnName("bl_id");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.cost_index).HasColumnName("cost_index");
            this.Property(t => t.date_cost_anal_end).HasColumnName("date_cost_anal_end");
            this.Property(t => t.date_cost_anal_start).HasColumnName("date_cost_anal_start");
            this.Property(t => t.date_costs_last_calcd).HasColumnName("date_costs_last_calcd");
            this.Property(t => t.date_end).HasColumnName("date_end");
            this.Property(t => t.date_move).HasColumnName("date_move");
            this.Property(t => t.date_start).HasColumnName("date_start");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.doc).HasColumnName("doc");
            this.Property(t => t.floors).HasColumnName("floors");
            this.Property(t => t.hpattern).HasColumnName("hpattern");
            this.Property(t => t.hpattern_acad).HasColumnName("hpattern_acad");
            this.Property(t => t.image_doc1).HasColumnName("image_doc1");
            this.Property(t => t.image_doc2).HasColumnName("image_doc2");
            this.Property(t => t.image_doc3).HasColumnName("image_doc3");
            this.Property(t => t.landlord_tenant).HasColumnName("landlord_tenant");
            this.Property(t => t.ld_contact).HasColumnName("ld_contact");
            this.Property(t => t.ld_name).HasColumnName("ld_name");
            this.Property(t => t.lease_sublease).HasColumnName("lease_sublease");
            this.Property(t => t.lease_type).HasColumnName("lease_type");
            this.Property(t => t.ls_parent_id).HasColumnName("ls_parent_id");
            this.Property(t => t.option1).HasColumnName("option1");
            this.Property(t => t.option2).HasColumnName("option2");
            this.Property(t => t.owned).HasColumnName("owned");
            this.Property(t => t.pr_id).HasColumnName("pr_id");
            this.Property(t => t.qty_occupancy).HasColumnName("qty_occupancy");
            this.Property(t => t.qty_suite_occupancy).HasColumnName("qty_suite_occupancy");
            this.Property(t => t.signed).HasColumnName("signed");
            this.Property(t => t.space_use).HasColumnName("space_use");
            this.Property(t => t.template_name).HasColumnName("template_name");
            this.Property(t => t.tn_contact).HasColumnName("tn_contact");
            this.Property(t => t.tn_name).HasColumnName("tn_name");
            this.Property(t => t.use_as_template).HasColumnName("use_as_template");
            this.Property(t => t.vat_exclude).HasColumnName("vat_exclude");
            this.Property(t => t.ls_id).HasColumnName("ls_id");

            // Relationships
            this.HasOptional(t => t.ac)
                .WithMany(t => t.ls)
                .HasForeignKey(d => d.ac_id);
            this.HasOptional(t => t.bl)
                .WithMany(t => t.ls)
                .HasForeignKey(d => d.bl_id);
            this.HasOptional(t => t.property)
                .WithMany(t => t.ls)
                .HasForeignKey(d => d.pr_id);

        }
    }
}
