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

        public void Save(User user)
        {
             baseService.Create(user);
        }

        public void Delete(string email) { }

        public void Update(User user) { }

        public User GetById(int id) {
            return null;
        }

        public IList<User> GetAll()
        {
            return baseService.GetAll();

        }

        public void update(User user)
        {
            baseService.Update(user.Id, user);
        }
    }
}
