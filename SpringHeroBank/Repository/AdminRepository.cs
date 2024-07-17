namespace SpringHeroBank.Repository;
using MySqlConnector;

public class AdminRepository
{
    private const string MySqlConnectionString = "server=127.0.0.1;uid=root;" + "pwd=;database=spring_hero_bank";
    public void DisplayAllUsers()
    {
        var conn = new MySqlConnection(MySqlConnectionString);
        conn.Open();
        
    }

    public void SearchUserByUsername(string userName)
    {
        
    }

    public void SearchUserByAccountNumber(string accountNumber)
    {
        
    }

    public void SearchUserByPhoneNumber(string phone)
    {
        
    }

    public void AddNewUser(string userName, string passWord, string fullName, string phone)
    {
        
    }

    public void LockUnlockAccount(string accountNumber)
    {
        
    }
}