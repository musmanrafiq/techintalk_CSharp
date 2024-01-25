using WebApi.Data;

namespace WebApi.Services
{
    public interface IUserService
    {
        public IEnumerable<UserEntity> GetUsers();
        public bool CreateUser(UserEntity user);

        public bool UpdateUser(UserEntity user);

        public bool DeleteUser(int userId);
    }
}
