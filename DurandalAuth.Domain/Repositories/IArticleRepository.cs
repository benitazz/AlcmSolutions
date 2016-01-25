#region

using System.Linq;

using DurandalAuth.Domain.Models;

#endregion

namespace DurandalAuth.Domain.Repositories
{
    /// <summary>
    /// The ArticleRepository interface.
    /// </summary>
    public interface IArticleRepository : IRepository<Article>
    {
        /// <summary>
        /// The all.
        /// </summary>
        /// <returns>
        /// The <see cref="IQueryable"/>.
        /// </returns>
        IQueryable<Article> All();
    }
}