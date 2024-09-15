namespace api.Service.UserService
{
    public interface IUserService
    {
        Task SaveAsync(Model.User user);
        Task GetAsync(string email);
    }
}
