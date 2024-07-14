namespace SpringHeroBank.Repository;

public interface IAdmin
{
    public void DisplayAllUsers();
    public void SearchUserByUsername(string userName);
    public void SearchUserByAccountNumber(string accountNumber);
    public void SearchUserByPhoneNumber(string phone);
    public void AddNewUser(string userName, string passWord, string fullName, string phone);
    public void LockUnlockAccount(string accountNumber);
}