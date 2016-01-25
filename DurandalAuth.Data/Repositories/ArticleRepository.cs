#region

using System.Data.Entity;
using System.Linq;

using DurandalAuth.Domain.Models;
using DurandalAuth.Domain.Repositories;

#endregion

namespace DurandalAuth.Data.Repositories
{
    /// <summary>
    /// The article repository.
    /// </summary>
    public class ArticleRepository : Repository<Article>, IArticleRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArticleRepository"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public ArticleRepository(DbContext context)
            : base(context)
        {
        }

        /// <summary>
        /// The all.
        /// </summary>
        /// <returns>
        /// The <see cref="IQueryable"/>.
        /// </returns>
        public override IQueryable<Article> All()
        {
            return this.Context.Set<Article>().Include("Category");
        }
    }
}