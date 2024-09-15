using api.Model;

namespace api.Service.UserService
{
    public class UserService : IUserService
    {

        private readonly BaseService<User> baseService;

        public UserService()
        {
            baseService = new BaseService<User>(nameof(User));
        }

        public Task GetAsync(string email)
        {
           return Task.CompletedTask;
        }

        public async Task SaveAsync(User user)
        {
            await baseService.CreateAsync(user);
        }
    }
}
