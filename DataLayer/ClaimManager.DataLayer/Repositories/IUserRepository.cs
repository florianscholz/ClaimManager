namespace ClaimManager.DataLayer.Repositories
{
    public interface IUserRepository
    {
        public void TestCredentials(string username, string password);
    }
}