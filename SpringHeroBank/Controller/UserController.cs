using System.Threading.Channels;
using SpringHeroBank.Repository;

namespace SpringHeroBank.Controller;
using SpringHeroBank.Interface;

public class UserController
{
    private UserRepository _userRepository = new UserRepository(); 
    public void Register()
    {
        User user = new User();
        Console.WriteLine("Input Your User Name");
        user.UserName = Console.ReadLine();
        Console.WriteLine("Input Your Password");
        user.PhoneNumber = Console.ReadLine();
        Console.WriteLine("Input Full Name");
        user.FullName = Console.ReadLine();
        Console.WriteLine("Input Phone Number");
        user.PhoneNumber = Console.ReadLine();
        Console.WriteLine("Account Type : ");
        Console.WriteLine("1-Admin");
        Console.WriteLine("2-User");
        var choice = Console.ReadLine();
        user.Type = choice;
        _userRepository.Save(user);
    }

    public void Deposit(User user)
    {
        Console.WriteLine("Input Deposit Amount");
        if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
        {
            _userRepository.Deposit(amount);
            Console.WriteLine("Deposit Success");
        }
        else
        {
            Console.WriteLine("Invalid Amount");
        }
        Console.ReadLine();
    }

    public void Withdraw(User user)
    {
        Console.WriteLine("Input Withdraw Amount");
        if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0 && amount < user.Balance)
        {
            Console.WriteLine("Withdraw Success");
        }
        else
        {
            Console.WriteLine("Invalid Amount");
        }

        Console.ReadLine();
    }

    public void Transfer()
    {
        
    }

    public void ShowInfo()
    {
        User user = new User();
        Console.WriteLine($"Full Name: {user.FullName}");
        Console.WriteLine($"Phone Number: {user.PhoneNumber}");
        Console.WriteLine($"Balance: {user.Balance}");
        Console.WriteLine($"Account Number: {user.AccountNumber}");
        Console.WriteLine($"Status: {(user.Islock ? "Locked" : "Active")}");
        _userRepository.ShowInfo(user);
    }

    public void UpdateInfo()
    {
        
    }

    public void UpdatePassword()
    {
        
    }

    public void TransactionHistory()
    {
        
    }
}