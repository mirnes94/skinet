using System.Threading.Tasks;
using System.Security.Claims;
using System.Linq;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{
    public static class UserManagerExtensions
    {
        public static async Task<AppUser> FindByUserByClaimsWithAddressAsync(this UserManager<AppUser> 
        input, ClaimsPrincipal user)
        {
            var email= user?.Claims?
            .FirstOrDefault(x=>x.Type==ClaimTypes.Email)?
            .Value;

            return await input.Users.Include(x=>x.Address).SingleOrDefaultAsync(x=> x.Email==email);
        }

        public static async Task<AppUser> FindByEmailFromClaimsPrinciple(this UserManager<AppUser> input,
         ClaimsPrincipal user)
         {
             var email= user?.Claims?
            .FirstOrDefault(x=>x.Type==ClaimTypes.Email)?
            .Value;

            return await input.Users.SingleOrDefaultAsync(x=>x.Email==email);
         }
    }
}