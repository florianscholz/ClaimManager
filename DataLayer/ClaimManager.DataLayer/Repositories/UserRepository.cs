using System.Linq;
using ClaimManager.DataLayer.DbContext;

namespace ClaimManager.DataLayer.Repositories
{
    public class UserRepository : IUserRepository
    {
        private DatabaseContext _databaseContext;

        public UserRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public void TestCredentials(string username, string password)
        {
            /* This is an insecure approach. Never store passwords as plain text in the Database! */
            var authenticatedUser = _databaseContext.Users
                .AsQueryable().Where(currentUser =>
                    currentUser.UserName == username && currentUser.Password == password);
            if (!authenticatedUser.Any())
            {
                throw new InvalidUserException("The User <censored for DSGVO> is invalid");
            }

            if (authenticatedUser.Any(m => m.Active == false))
            {
                throw new InactiveUserException("The User <censored for DSGVO> is inactive");
            }
        }
    }
}