using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalAuth.Domain.Models.Mapping
{
    public class ArticleMap : EntityTypeConfiguration<Article>
    {
        public ArticleMap()
        {
            // Primary Key
            this.HasKey(t => t.ArticleId);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.UrlCodeReference)
                .HasMaxLength(200);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.ImageUrl)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Articles");
            this.Property(t => t.ArticleId).HasColumnName("ArticleId");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.UrlCodeReference).HasColumnName("UrlCodeReference");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.ImageUrl).HasColumnName("ImageUrl");
            this.Property(t => t.Markdown).HasColumnName("Markdown");
            this.Property(t => t.Html).HasColumnName("Html");
            this.Property(t => t.IsPublished).HasColumnName("IsPublished");
            this.Property(t => t.CategoryId).HasColumnName("CategoryId");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");

            // Relationships
            this.HasRequired(t => t.Category)
                .WithMany(t => t.Articles)
                .HasForeignKey(d => d.CategoryId);

        }
    }
}
