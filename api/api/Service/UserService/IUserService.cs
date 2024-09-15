namespace api.Service.UserService
{
    public interface IUserService
    {
        void Save(Model.User user);
        Task GetAsync(string email);
    }
}
