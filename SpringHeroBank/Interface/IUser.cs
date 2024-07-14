namespace SpringHeroBank.Repository;

public interface IUser
{
    public void Register(User user);
    public User Login(string userName, string passWord);
    public void ShowInfo(User user);
    public void UpdateInfo(User user, string fullName, string phone);
    public void UpdatePassWord(User user, string passWord);
    public void Deposit(User user, decimal amount);
    public void Withdraw(User user, decimal amount);
    public void Transfer(User sender, User receiver, double amount);
}