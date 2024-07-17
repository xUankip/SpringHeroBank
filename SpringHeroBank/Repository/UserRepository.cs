using System.Threading.Channels;

namespace SpringHeroBank.Repository;

using MySqlConnector;
public class UserRepository
{
    private const string MySqlConnectionString = "server=127.0.0.1;uid=root;" + "pwd=;database=spring_hero_bank";
    public void Save(User user)
    {
        var conn = new MySqlConnection(MySqlConnectionString);
        conn.Open();
        string query = "INSERT INTO users (Username, Password, FullName, PhoneNumber, AccountNumber, Balance, IsLocked) VALUES (@Username, @Password, @FullName, @PhoneNumber, @AccountNumber, @Balance, @IsLocked)";
        var command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@Username", user.UserName);
            command.Parameters.AddWithValue("@Password", user.PassWord);
            command.Parameters.AddWithValue("@FullName", user.FullName);
            command.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
            command.Parameters.AddWithValue("@AccountNumber", Guid.NewGuid().ToString());
            command.Parameters.AddWithValue("@Balance", 0);
            command.Parameters.AddWithValue("@IsLocked", false);
            command.ExecuteNonQuery();
        conn.Close();
        Console.WriteLine("Sign Up Successfully");
    }

    public User Login(string userName, string passWord)
    {
        var conn = new MySqlConnection(MySqlConnectionString);
        conn.Open();
        string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
        var command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@Username", userName);
            command.Parameters.AddWithValue("@Password", passWord);
            var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (reader.GetBoolean("IsLocked"))
                    {
                        Console.WriteLine("Tài khoản của bạn đã bị khóa.");
                        return null;
                    }
                    User user = new User
                    {
                        Id = reader.GetInt32("UserId"),
                        UserName = reader.GetString("Username"),
                        PassWord = reader.GetString("Password"),
                        FullName = reader.GetString("FullName"),
                        PhoneNumber = reader.GetString("PhoneNumber"),
                        AccountNumber = reader.GetString("AccountNumber"),
                        Balance = reader.GetDecimal("Balance"),
                        Islock = reader.GetBoolean("IsLocked")
                    };
                    Console.WriteLine("Login Success");
                    return user;
                }
            Console.WriteLine("Wrong UserName Or PassWord");
            return null;
    }

    public void ShowInfo(User user)
    {
        var conn = new MySqlConnection(MySqlConnectionString);
        conn.Open();
        string query = "select * from User where UserId = @UserId";
    }

    public void UpdateInfo(User user, string newFullName, string newPhoneNumber)
    {
        var conn = new MySqlConnection(MySqlConnectionString);
        conn.Open();
        string query = "UPDATE Users SET FullName = @FullName, PhoneNumber = @PhoneNumber WHERE Id = @Id";
        var command = new MySqlCommand(query, conn);
        command.Parameters.AddWithValue("@FullName", newFullName);
        command.Parameters.AddWithValue("@PhoneNumber", newPhoneNumber);
        command.Parameters.AddWithValue("@UserId", user.Id);
        command.ExecuteNonQuery();
        Console.WriteLine("Update Success");
    }

    public void UpdatePassWord(User user, string newPassword)
    {
        var conn = new MySqlConnection(MySqlConnectionString);
            conn.Open();
            string query = "UPDATE Users SET Password = @Password WHERE Id = @Id";
            var command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@Password", newPassword);
                command.Parameters.AddWithValue("@UserId", user.Id);
                command.ExecuteNonQuery();
            
            Console.WriteLine("Change Password Success");
    }

    public void Deposit(decimal amount)
    {
        User user = new User();
        var conn = new MySqlConnection(MySqlConnectionString);
        conn.Open();
        string query = "UPDATE Users SET Balance = Balance + @Amount WHERE Id = @Id";
        var command = new MySqlCommand(query, conn);
        command.Parameters.AddWithValue("@Amount", amount);
        command.Parameters.AddWithValue("@Id", user.Id);
        command.ExecuteNonQuery();
        query = "INSERT INTO Transactions (Type, Amount, Date, UserId, Status) VALUES (@Type, @Amount, @Date, @UserId, @Status)";
        command = new MySqlCommand(query, conn);
        command.Parameters.AddWithValue("@Type", "Deposit");
        command.Parameters.AddWithValue("@Amount", amount);
        command.Parameters.AddWithValue("@Date", DateTime.Now);
        command.Parameters.AddWithValue("@UserId", user.Id);
        command.Parameters.AddWithValue("@Status", 1);
        command.ExecuteNonQuery();
        Console.WriteLine("Deposit" + amount+ "to" + user.Id + "Success");
    }

    public void Withdraw(User user, decimal amount)
    {
        var conn = new MySqlConnection(MySqlConnectionString);
            conn.Open();
            if (user.Balance >= amount) {
                string query = "UPDATE Users SET Balance = Balance - @Amount WHERE Id = @Id";
                var command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Amount", amount);
                    command.Parameters.AddWithValue("@UserId", user.Id);
                    command.ExecuteNonQuery();
                query = "INSERT INTO Transactions (Type, Amount, Date, Id) VALUES (@Type, @Amount, @Date, @Id)";
                command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Type", "Withdraw");
                    command.Parameters.AddWithValue("@Amount", amount);
                    command.Parameters.AddWithValue("@Date", DateTime.Now);
                    command.Parameters.AddWithValue("@UserId", user.Id);
                    command.ExecuteNonQuery();
                
                Console.WriteLine("Withdraw Success");
            } else {
                Console.WriteLine("Balance Not Enough");
            }
    }

    public void Transfer(User sender, User receiver, decimal amount)
    {
        
    }
}