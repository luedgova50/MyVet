namespace MyVet.Web.Helpers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;
    using MyVet.Web.Data.Entities;
    using MyVet.Web.Models;

    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(User user, string roleName);

        Task<bool> IsUserInRoleAsync(User user, string roleName);

        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task LogoutAsync();


    }
}
