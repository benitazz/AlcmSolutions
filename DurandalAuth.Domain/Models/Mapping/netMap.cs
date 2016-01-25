using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class netMap : EntityTypeConfiguration<net>
    {
        public netMap()
        {
            // Primary Key
            this.HasKey(t => t.net_id);

            // Properties
            this.Property(t => t.administrator)
                .IsFixedLength()
                .HasMaxLength(35);

            this.Property(t => t.ca_type)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.comments)
                .HasMaxLength(1000);

            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.lan_type)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.net_address)
                .IsFixedLength()
                .HasMaxLength(24);

            this.Property(t => t.net_os_type)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.transport_protocol)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.wan_type)
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.net_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("net", "afm");
            this.Property(t => t.administrator).HasColumnName("administrator");
            this.Property(t => t.ca_type).HasColumnName("ca_type");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.is_virtual).HasColumnName("is_virtual");
            this.Property(t => t.lan_type).HasColumnName("lan_type");
            this.Property(t => t.net_address).HasColumnName("net_address");
            this.Property(t => t.net_os_type).HasColumnName("net_os_type");
            this.Property(t => t.num_nodes).HasColumnName("num_nodes");
            this.Property(t => t.transport_protocol).HasColumnName("transport_protocol");
            this.Property(t => t.wan_type).HasColumnName("wan_type");
            this.Property(t => t.net_id).HasColumnName("net_id");

            // Relationships
            this.HasOptional(t => t.catype)
                .WithMany(t => t.nets)
                .HasForeignKey(d => d.ca_type);

        }
    }
}
