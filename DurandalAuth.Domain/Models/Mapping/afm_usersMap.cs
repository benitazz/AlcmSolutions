using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class afm_usersMap : EntityTypeConfiguration<afm_users>
    {
        public afm_usersMap()
        {
            // Primary Key
            this.HasKey(t => t.user_name);

            // Properties
            this.Property(t => t.bim_license)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.bl_id_list)
                .HasMaxLength(255);

            this.Property(t => t.clr_scheme)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.display_units)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.email)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.group_1)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.group_10)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.group_2)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.group_3)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.group_4)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.group_5)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.group_6)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.group_7)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.group_8)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.group_9)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.home_page)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.locale)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.mob_device_id)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.preferences)
                .HasMaxLength(1000);

            this.Property(t => t.role_name)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.site_id_list)
                .HasMaxLength(255);

            this.Property(t => t.sql_pwd)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.sql_uid)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.user_pwd)
                .IsFixedLength()
                .HasMaxLength(128);

            this.Property(t => t.vpa_option1)
                .HasMaxLength(255);

            this.Property(t => t.vpa_option2)
                .HasMaxLength(255);

            this.Property(t => t.vpa_option3)
                .HasMaxLength(255);

            this.Property(t => t.vpa_option4)
                .HasMaxLength(255);

            this.Property(t => t.user_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("afm_users", "afm");
            this.Property(t => t.bim_license).HasColumnName("bim_license");
            this.Property(t => t.bl_id_list).HasColumnName("bl_id_list");
            this.Property(t => t.clr_scheme).HasColumnName("clr_scheme");
            this.Property(t => t.date_pwd_changed).HasColumnName("date_pwd_changed");
            this.Property(t => t.display_units).HasColumnName("display_units");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.group_1).HasColumnName("group_1");
            this.Property(t => t.group_10).HasColumnName("group_10");
            this.Property(t => t.group_2).HasColumnName("group_2");
            this.Property(t => t.group_3).HasColumnName("group_3");
            this.Property(t => t.group_4).HasColumnName("group_4");
            this.Property(t => t.group_5).HasColumnName("group_5");
            this.Property(t => t.group_6).HasColumnName("group_6");
            this.Property(t => t.group_7).HasColumnName("group_7");
            this.Property(t => t.group_8).HasColumnName("group_8");
            this.Property(t => t.group_9).HasColumnName("group_9");
            this.Property(t => t.home_page).HasColumnName("home_page");
            this.Property(t => t.is_named_user).HasColumnName("is_named_user");
            this.Property(t => t.locale).HasColumnName("locale");
            this.Property(t => t.mob_device_enabled).HasColumnName("mob_device_enabled");
            this.Property(t => t.mob_device_id).HasColumnName("mob_device_id");
            this.Property(t => t.num_retries).HasColumnName("num_retries");
            this.Property(t => t.preferences).HasColumnName("preferences");
            this.Property(t => t.role_name).HasColumnName("role_name");
            this.Property(t => t.site_id_list).HasColumnName("site_id_list");
            this.Property(t => t.sql_pwd).HasColumnName("sql_pwd");
            this.Property(t => t.sql_uid).HasColumnName("sql_uid");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.user_level).HasColumnName("user_level");
            this.Property(t => t.user_pwd).HasColumnName("user_pwd");
            this.Property(t => t.vpa_option1).HasColumnName("vpa_option1");
            this.Property(t => t.vpa_option2).HasColumnName("vpa_option2");
            this.Property(t => t.vpa_option3).HasColumnName("vpa_option3");
            this.Property(t => t.vpa_option4).HasColumnName("vpa_option4");
            this.Property(t => t.user_name).HasColumnName("user_name");

            // Relationships
            this.HasOptional(t => t.afm_groups)
                .WithMany(t => t.afm_users)
                .HasForeignKey(d => d.group_1);
            this.HasOptional(t => t.afm_groups1)
                .WithMany(t => t.afm_users1)
                .HasForeignKey(d => d.group_10);
            this.HasOptional(t => t.afm_groups2)
                .WithMany(t => t.afm_users2)
                .HasForeignKey(d => d.group_2);
            this.HasOptional(t => t.afm_groups3)
                .WithMany(t => t.afm_users3)
                .HasForeignKey(d => d.group_3);
            this.HasOptional(t => t.afm_groups4)
                .WithMany(t => t.afm_users4)
                .HasForeignKey(d => d.group_4);
            this.HasOptional(t => t.afm_groups5)
                .WithMany(t => t.afm_users5)
                .HasForeignKey(d => d.group_5);
            this.HasOptional(t => t.afm_groups6)
                .WithMany(t => t.afm_users6)
                .HasForeignKey(d => d.group_6);
            this.HasOptional(t => t.afm_groups7)
                .WithMany(t => t.afm_users7)
                .HasForeignKey(d => d.group_7);
            this.HasOptional(t => t.afm_groups8)
                .WithMany(t => t.afm_users8)
                .HasForeignKey(d => d.group_8);
            this.HasOptional(t => t.afm_groups9)
                .WithMany(t => t.afm_users9)
                .HasForeignKey(d => d.group_9);
            this.HasOptional(t => t.afm_roles)
                .WithMany(t => t.afm_users)
                .HasForeignKey(d => d.role_name);

        }
    }
}
