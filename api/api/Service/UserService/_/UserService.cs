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

        public void Delete(Guid Id) {
             baseService.Delete(Id);
        }


        public User GetById(Guid id) {
            return baseService.GetById(id);
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
