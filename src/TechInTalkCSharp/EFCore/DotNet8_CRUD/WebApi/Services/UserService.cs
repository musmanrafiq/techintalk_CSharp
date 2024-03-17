using Microsoft.EntityFrameworkCore;
using WebApi.Data;

namespace WebApi.Services
{
    public class UserService : IUserService
    {
        private readonly SchoolDbContext _schoolDbContext;
        public UserService(SchoolDbContext schoolDbContext)
        {
            _schoolDbContext = schoolDbContext;
        }

        public IEnumerable<UserEntity> GetUsers()
        {
            var results = _schoolDbContext.Users.Include("UserAdressEntity")
                .Include("Devices")
                .ToList();
            return results;
        }

        public bool CreateUser(UserEntity user)
        {

            _schoolDbContext.Add(user);

            int resutCount = _schoolDbContext.SaveChanges();
            return resutCount > 0;
        }

        public bool UpdateUser(UserEntity user)
        {
            var count = _schoolDbContext.Users.Where(x => x.Id == user.Id).ExecuteUpdate(x => x.SetProperty(u => u.Name, user.Name));
            return count > 0;
        }

        public bool DeleteUser(int userId)
        {
            // executing delete for that user
            var count = _schoolDbContext.Users.Where(x => x.Id == userId).ExecuteDelete();
            return count > 0;
        }
    }

}
