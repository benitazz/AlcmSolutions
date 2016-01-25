using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class grp_transMap : EntityTypeConfiguration<grp_trans>
    {
        public grp_transMap()
        {
            // Primary Key
            this.HasKey(t => t.grp_trans_id);

            // Properties
            this.Property(t => t.installation_identifier)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.installation_name)
                .IsFixedLength()
                .HasMaxLength(100);

            this.Property(t => t.latitude)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.lease_authority_id)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.lease_id)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.lease_maintenance_ind)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.lease_option_to_term_early)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.legal_interest_ind)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.longitude)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.outgrant_indicator)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.real_property_name)
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.recipient)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.reporting_grp_agency_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.restrictions)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.sale_candidate)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.state)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.status_indicator)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.street_address)
                .IsFixedLength()
                .HasMaxLength(100);

            this.Property(t => t.sub_installation_identifier)
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.trans_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.unique_identifier)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.user_name_app_rej)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.user_name_requestor)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.using_grp_agency_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.zip_code)
                .IsFixedLength()
                .HasMaxLength(9);

            this.Property(t => t.city)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.comments)
                .HasMaxLength(2000);

            this.Property(t => t.congressional_district)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.country)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.county)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.description_of_change)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.dispos_anticipated)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.dispos_anticipated_method)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.disposition_method_id)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.excess_is_anticipated)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("grp_trans", "afm");
            this.Property(t => t.grp_type_id).HasColumnName("grp_type_id");
            this.Property(t => t.grp_use_id).HasColumnName("grp_use_id");
            this.Property(t => t.historical_status).HasColumnName("historical_status");
            this.Property(t => t.installation_identifier).HasColumnName("installation_identifier");
            this.Property(t => t.installation_name).HasColumnName("installation_name");
            this.Property(t => t.latitude).HasColumnName("latitude");
            this.Property(t => t.lease_authority_id).HasColumnName("lease_authority_id");
            this.Property(t => t.lease_id).HasColumnName("lease_id");
            this.Property(t => t.lease_maintenance_ind).HasColumnName("lease_maintenance_ind");
            this.Property(t => t.lease_option_to_term_early).HasColumnName("lease_option_to_term_early");
            this.Property(t => t.legal_interest_ind).HasColumnName("legal_interest_ind");
            this.Property(t => t.longitude).HasColumnName("longitude");
            this.Property(t => t.mission_dependency).HasColumnName("mission_dependency");
            this.Property(t => t.net_proceeds).HasColumnName("net_proceeds");
            this.Property(t => t.outgrant_indicator).HasColumnName("outgrant_indicator");
            this.Property(t => t.real_property_name).HasColumnName("real_property_name");
            this.Property(t => t.recipient).HasColumnName("recipient");
            this.Property(t => t.reporting_grp_agency_id).HasColumnName("reporting_grp_agency_id");
            this.Property(t => t.restrictions).HasColumnName("restrictions");
            this.Property(t => t.sale_candidate).HasColumnName("sale_candidate");
            this.Property(t => t.size_gross_area).HasColumnName("size_gross_area");
            this.Property(t => t.size_rural_acres).HasColumnName("size_rural_acres");
            this.Property(t => t.size_structural_unit).HasColumnName("size_structural_unit");
            this.Property(t => t.size_unit_of_measure).HasColumnName("size_unit_of_measure");
            this.Property(t => t.size_urban_acres).HasColumnName("size_urban_acres");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.status_indicator).HasColumnName("status_indicator");
            this.Property(t => t.street_address).HasColumnName("street_address");
            this.Property(t => t.sub_installation_identifier).HasColumnName("sub_installation_identifier");
            this.Property(t => t.sustainability).HasColumnName("sustainability");
            this.Property(t => t.time_of_app_rej).HasColumnName("time_of_app_rej");
            this.Property(t => t.time_of_transaction).HasColumnName("time_of_transaction");
            this.Property(t => t.trans_type).HasColumnName("trans_type");
            this.Property(t => t.unique_identifier).HasColumnName("unique_identifier");
            this.Property(t => t.user_name_app_rej).HasColumnName("user_name_app_rej");
            this.Property(t => t.user_name_requestor).HasColumnName("user_name_requestor");
            this.Property(t => t.using_grp_agency_id).HasColumnName("using_grp_agency_id");
            this.Property(t => t.utilization).HasColumnName("utilization");
            this.Property(t => t.value).HasColumnName("value");
            this.Property(t => t.zip_code).HasColumnName("zip_code");
            this.Property(t => t.annual_operating_costs).HasColumnName("annual_operating_costs");
            this.Property(t => t.btu_consumption).HasColumnName("btu_consumption");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.condition_index).HasColumnName("condition_index");
            this.Property(t => t.congressional_district).HasColumnName("congressional_district");
            this.Property(t => t.count_emp_contractor).HasColumnName("count_emp_contractor");
            this.Property(t => t.count_emp_fed).HasColumnName("count_emp_fed");
            this.Property(t => t.count_emp_fed_telework).HasColumnName("count_emp_fed_telework");
            this.Property(t => t.country).HasColumnName("country");
            this.Property(t => t.county).HasColumnName("county");
            this.Property(t => t.date_lease_expiration).HasColumnName("date_lease_expiration");
            this.Property(t => t.date_of_app_rej).HasColumnName("date_of_app_rej");
            this.Property(t => t.date_of_transaction).HasColumnName("date_of_transaction");
            this.Property(t => t.description_of_change).HasColumnName("description_of_change");
            this.Property(t => t.dispos_anticipated).HasColumnName("dispos_anticipated");
            this.Property(t => t.dispos_anticipated_method).HasColumnName("dispos_anticipated_method");
            this.Property(t => t.disposition_date).HasColumnName("disposition_date");
            this.Property(t => t.disposition_method_id).HasColumnName("disposition_method_id");
            this.Property(t => t.disposition_value).HasColumnName("disposition_value");
            this.Property(t => t.excess_is_anticipated).HasColumnName("excess_is_anticipated");
            this.Property(t => t.grp_trans_id).HasColumnName("grp_trans_id");
            this.Property(t => t.sale_anticipated_year).HasColumnName("sale_anticipated_year");
            this.Property(t => t.dispos_anticipated_year).HasColumnName("dispos_anticipated_year");
            this.Property(t => t.excess_anticipated_year).HasColumnName("excess_anticipated_year");

            // Relationships
            this.HasOptional(t => t.afm_users)
                .WithMany(t => t.grp_trans)
                .HasForeignKey(d => d.user_name_app_rej);
            this.HasRequired(t => t.afm_users1)
                .WithMany(t => t.grp_trans1)
                .HasForeignKey(d => d.user_name_requestor);
            this.HasOptional(t => t.grp_agency)
                .WithMany(t => t.grp_trans)
                .HasForeignKey(d => d.reporting_grp_agency_id);
            this.HasOptional(t => t.grp_agency1)
                .WithMany(t => t.grp_trans1)
                .HasForeignKey(d => d.using_grp_agency_id);
            this.HasOptional(t => t.grp_type)
                .WithMany(t => t.grp_trans)
                .HasForeignKey(d => d.grp_type_id);
            this.HasOptional(t => t.grp_use)
                .WithMany(t => t.grp_trans)
                .HasForeignKey(d => new { d.grp_type_id, d.grp_use_id });

        }
    }
}
