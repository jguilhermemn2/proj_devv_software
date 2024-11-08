using api.Model;

namespace api.Service.UserService
{
    public interface IUserService
    {
        void Save(Model.User user);

        Task GetAsync(string email);
        
        User GetById(Guid id);

        IList<User> GetAll();

        void update(User user);

        void Delete(Guid Id);
    }
}
