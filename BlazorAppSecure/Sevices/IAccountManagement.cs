using BlazorAppSecure.Model;
using System.Data;

namespace BlazorAppSecure.Sevices
{
    public interface IAccountManagement
    {
        public Task<FormResult> RegisterAsync(string email, string password);

        public Task<FormResult> LoginAsync(string email, string password);

        public Task LogoutAsync();

        public Task<bool> CheckAuthenticatedAsync();

        public Task<List<Role>> GetRoles();

        public Task<FormResult> AddRole(string[] roles);
    }
}
