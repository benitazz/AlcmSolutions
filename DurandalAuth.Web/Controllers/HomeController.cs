#region

using System;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

using DurandalAuth.Web.SEO;

#endregion

namespace DurandalAuth.Web.Controllers
{
    /// <summary>
    /// This Controller contains the Index action where all request will be redirected on this site
    /// </summary>
    public class HomeController : AsyncController
    {
        /// <summary>
        /// The snapshot.
        /// </summary>
        private readonly ISnapshot Snapshot;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="snapshot">
        /// The snapshot.
        /// </param>
        public HomeController(ISnapshot snapshot)
        {
            this.Snapshot = snapshot;
        }

        /// <summary>
        /// All routes in this site always return to the Index action and the control is passed to 
        /// the Durandal application
        /// If the route parameters include a _escaped_fragment_ parameter, then a snapshot of the resource is returned
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<ActionResult> Index()
        {
            // If the request is not from a bot or the system is not ready or taking snapshots => control to Durandal app
            if (!this.Snapshot.IsBot(this.Request))
            {
                return this.View();
            }

            // Check if the service is configured
            if (!this.Snapshot.Configured())
            {
                return this.View();
            }

            // Take snapshot for bot
            try
            {
                var result =
                    await
                    this.Snapshot.Get(
                        this.Request.Url.AbsoluteUri.Replace("?_escaped_fragment_=", string.Empty), 
                        this.Request.UserAgent);
                return this.Content(result);
            }
            catch (HttpException ex)
            {
                return new HttpNotFoundResult(ex.Message);
            }
            catch (Exception ex)
            {
                return this.View();
            }
        }
    }
}