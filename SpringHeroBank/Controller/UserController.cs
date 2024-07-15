using System.Threading.Channels;
using SpringHeroBank.Repository;

namespace SpringHeroBank.Controller;

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