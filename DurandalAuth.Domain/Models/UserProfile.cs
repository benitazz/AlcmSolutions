#region

using System.Runtime.Serialization;

using Microsoft.AspNet.Identity.EntityFramework;

#endregion

namespace DurandalAuth.Domain.Models
{
    /// <summary>
    ///     User Profile entity
    /// </summary>
    [DataContract(IsReference = true)]
    public class UserProfile : IdentityUser
    {
        
    }
}