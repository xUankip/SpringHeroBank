using SpringHeroBank.Controller;
using SpringHeroBank.Repository;
using System;
using System.Security.Cryptography.X509Certificates;

namespace SpringHeroBank;

class Program()
{
    UserController _userController = new UserController();
    static void Main(string[] args)
    {
        Mainmenu();
    }

    public static void Mainmenu()
    {
        Console.WriteLine("------------Spring Hero Bank------------");
        Console.WriteLine("1. Register.");
        Console.WriteLine("2. Login.");
        Console.WriteLine("3. Exit.");
        Console.WriteLine("——————————————————-");
        Console.Write("Type your choice (1,2,3): ");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                
                break;
            case "2":
                Login();
                break;
            case "3":
                break;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ, vui lòng thử lại.");
                break;
        }
    }
}

