#region

using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;

using DurandalAuth.Domain.Models;
using DurandalAuth.Domain.UnitOfWork;
using DurandalAuth.Utils.Common;
using DurandalAuth.Web.Extensions;

#endregion

namespace DurandalAuth.Web.Controllers
{
    /// <summary>
    ///     Main controller retrieving information from the data store
    /// </summary>
    // [BreezeController]
    [RoutePrefix("api/Profile")]
    public class ProfileController : ApiController
    {
        /// <summary>
        /// The _unit of work.
        /// </summary>
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileController"/> class.
        /// </summary>
        /// <param name="uow">
        /// The uow.
        /// </param>
        public ProfileController(IUnitOfWork uow)
        {
            this._unitOfWork = uow;
        }

        // POST api/Profile/CreateUserProfile
        /// <summary>
        /// The create user profile.
        /// </summary>
        /// <param name="profileModel">
        /// The profile model.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [AllowAnonymous]
        [Route("CreateUserProfile")]
        public async Task<IHttpActionResult> CreateUserProfile(Profile profileModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            try
            {
                profileModel.Address.SetAuditDetails();
                profileModel.Contact.SetAuditDetails();
                profileModel.Individual.SetAuditDetails();
                profileModel.Company.SetAuditDetails();
                profileModel.SetAuditDetails();

                if (profileModel.Individual != null && profileModel.Individual.BirthDate == DateTime.MinValue)
                {
                    profileModel.Individual.BirthDate = DateTime.Now;
                }

                var entityTypes = this._unitOfWork.EntityLookupRepository.All();

                var entityType = profileModel.Individual != null
                                     ? entityTypes.First(e => e.Name.Equals(Constant.Individual))
                                     : entityTypes.First(e => !e.Name.Equals(Constant.Individual));

                profileModel.EntityTypeLookup = entityType;

                var result = await this.CreateUserProfileAsync(profileModel);
                return this.Ok(result);
            }
            catch (Exception ex)
            {
                return this.Content(HttpStatusCode.BadRequest, ex);
            }
        }

        /// <summary>
        /// The create user profile async.
        /// </summary>
        /// <param name="profile">
        /// The profile.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<Profile> CreateUserProfileAsync(Profile profile)
        {
            this._unitOfWork.ProfileRepository.Add(profile);
            this._unitOfWork.Commit();
            return profile;
        }
    }
}