using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class messageMap : EntityTypeConfiguration<message>
    {
        public messageMap()
        {
            // Primary Key
            this.HasKey(t => new { t.activity_id, t.referenced_by, t.message_id });

            // Properties
            this.Property(t => t.message_text)
                .IsRequired()
                .HasMaxLength(380);

            this.Property(t => t.message_text_01)
                .HasMaxLength(570);

            this.Property(t => t.message_text_02)
                .HasMaxLength(570);

            this.Property(t => t.message_text_03)
                .HasMaxLength(570);

            this.Property(t => t.message_text_ch)
                .HasMaxLength(570);

            this.Property(t => t.message_text_de)
                .HasMaxLength(570);

            this.Property(t => t.message_text_es)
                .HasMaxLength(570);

            this.Property(t => t.message_text_fr)
                .HasMaxLength(570);

            this.Property(t => t.message_text_it)
                .HasMaxLength(570);

            this.Property(t => t.message_text_jp)
                .HasMaxLength(570);

            this.Property(t => t.message_text_ko)
                .HasMaxLength(570);

            this.Property(t => t.message_text_nl)
                .HasMaxLength(570);

            this.Property(t => t.message_text_no)
                .HasMaxLength(570);

            this.Property(t => t.message_text_zh)
                .HasMaxLength(570);

            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(512);

            this.Property(t => t.transfer_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.activity_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.referenced_by)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.message_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("messages", "afm");
            this.Property(t => t.message_text).HasColumnName("message_text");
            this.Property(t => t.message_text_01).HasColumnName("message_text_01");
            this.Property(t => t.message_text_02).HasColumnName("message_text_02");
            this.Property(t => t.message_text_03).HasColumnName("message_text_03");
            this.Property(t => t.message_text_ch).HasColumnName("message_text_ch");
            this.Property(t => t.message_text_de).HasColumnName("message_text_de");
            this.Property(t => t.message_text_es).HasColumnName("message_text_es");
            this.Property(t => t.message_text_fr).HasColumnName("message_text_fr");
            this.Property(t => t.message_text_it).HasColumnName("message_text_it");
            this.Property(t => t.message_text_jp).HasColumnName("message_text_jp");
            this.Property(t => t.message_text_ko).HasColumnName("message_text_ko");
            this.Property(t => t.message_text_nl).HasColumnName("message_text_nl");
            this.Property(t => t.message_text_no).HasColumnName("message_text_no");
            this.Property(t => t.message_text_zh).HasColumnName("message_text_zh");
            this.Property(t => t.customized).HasColumnName("customized");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.is_rich_msg_format).HasColumnName("is_rich_msg_format");
            this.Property(t => t.transfer_status).HasColumnName("transfer_status");
            this.Property(t => t.activity_id).HasColumnName("activity_id");
            this.Property(t => t.referenced_by).HasColumnName("referenced_by");
            this.Property(t => t.message_id).HasColumnName("message_id");

            // Relationships
            this.HasRequired(t => t.afm_activities)
                .WithMany(t => t.messages)
                .HasForeignKey(d => d.activity_id);

        }
    }
}
