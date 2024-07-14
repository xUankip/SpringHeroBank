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
}