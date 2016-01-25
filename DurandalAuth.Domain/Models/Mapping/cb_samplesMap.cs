using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class cb_samplesMap : EntityTypeConfiguration<cb_samples>
    {
        public cb_samplesMap()
        {
            // Primary Key
            this.HasKey(t => t.sample_id);

            // Properties
            this.Property(t => t.analysis_requested)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.analyst_name)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.comments)
                .HasMaxLength(2000);

            this.Property(t => t.dwgname)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.ehandle)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.lab_id)
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.lab_log_num)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.requested_by)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.sample_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.sample_desc)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.sample_doc)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.sample_loc)
                .IsFixedLength()
                .HasMaxLength(64);

            this.Property(t => t.sample_loc_code)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.sample_prefix_num)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.sample_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("cb_samples", "afm");
            this.Property(t => t.activity_log_id).HasColumnName("activity_log_id");
            this.Property(t => t.analysis_requested).HasColumnName("analysis_requested");
            this.Property(t => t.analyst_name).HasColumnName("analyst_name");
            this.Property(t => t.comments).HasColumnName("comments");
            this.Property(t => t.date_analysis).HasColumnName("date_analysis");
            this.Property(t => t.date_collected).HasColumnName("date_collected");
            this.Property(t => t.date_received).HasColumnName("date_received");
            this.Property(t => t.dwgname).HasColumnName("dwgname");
            this.Property(t => t.ehandle).HasColumnName("ehandle");
            this.Property(t => t.lab_id).HasColumnName("lab_id");
            this.Property(t => t.lab_log_num).HasColumnName("lab_log_num");
            this.Property(t => t.requested_by).HasColumnName("requested_by");
            this.Property(t => t.sample_archive).HasColumnName("sample_archive");
            this.Property(t => t.sample_code).HasColumnName("sample_code");
            this.Property(t => t.sample_desc).HasColumnName("sample_desc");
            this.Property(t => t.sample_doc).HasColumnName("sample_doc");
            this.Property(t => t.sample_loc).HasColumnName("sample_loc");
            this.Property(t => t.sample_loc_code).HasColumnName("sample_loc_code");
            this.Property(t => t.sample_prefix_num).HasColumnName("sample_prefix_num");
            this.Property(t => t.sample_type).HasColumnName("sample_type");
            this.Property(t => t.sample_id).HasColumnName("sample_id");

            // Relationships
            this.HasRequired(t => t.activity_log)
                .WithMany(t => t.cb_samples)
                .HasForeignKey(d => d.activity_log_id);
            this.HasOptional(t => t.vn)
                .WithMany(t => t.cb_samples)
                .HasForeignKey(d => d.lab_id);

        }
    }
}
