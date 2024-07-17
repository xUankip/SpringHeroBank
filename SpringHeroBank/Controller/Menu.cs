namespace SpringHeroBank.Controller;
public class Menu
{
    public static void UserMenu(User user)
    { 
     UserController _userController = new UserController();
        while (true)
        {
            Console.WriteLine("-----------Spring Hero Bank-------------");
            Console.WriteLine($"Welcome Back {user.FullName}");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Transfer");
            Console.WriteLine("5. Show Information");
            Console.WriteLine("6. Change Information");
            Console.WriteLine("7. Change Password");
            Console.WriteLine("8. Transaction History");
            Console.WriteLine("9. Exit");
            Console.WriteLine("Enter the number form 1 to 8");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    _userController.Register();
                    break;
                case "2":
                    _userController.Deposit(user);
                    break;
                case "3":
                    _userController.Withdraw(user);
                    break;
                case "4":
                    _userController.Transfer();
                    break;
                case "5":
                    _userController.ShowInfo();
                    break;
                case "6":
                    _userController.UpdateInfo();
                    break;
                case "7":
                    _userController.UpdatePassword();
                    break;
                case "8":
                    _userController.TransactionHistory();
                    break;
                case "9":
                    return;
                default:
                    Console.WriteLine("Invalid choice, Try Again");
                    break;
            }
        }
    }

    public static void AminMenu(Admin admin)
    {
        AdminController _adminController = new AdminController();
        while (true)
        {
            Console.WriteLine("-----------Spring Hero Bank-------------");
            Console.WriteLine($"Welcome Back {admin.FullName}");
            Console.WriteLine("1. Show All Account");
            Console.WriteLine("2. Show All Transaction");
            Console.WriteLine("3. Search User By Full Name");
            Console.WriteLine("4. Search User By Account Number");
            Console.WriteLine("5. Search User By Phone Number");
            Console.WriteLine("6. Add New User");
            Console.WriteLine("7. Lock and Unlock Account");
            Console.WriteLine("8. Show Transaction History By Account Number");
            Console.WriteLine("9. Change Account Information");
            Console.WriteLine("10. Change Account Password");
            Console.WriteLine("11. Exit");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Enter the number form 1 to 11");
            var choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    _adminController.FindAll();
                    break;
                case "2":
                    _adminController.ShowAllTransaction();
                    break;
                case "3":
                    _adminController.FindByFullName();
                    break;
                case "4":
                    _adminController.FindByAccountNumber();
                    break;
                case "5":
                    _adminController.FindByPhoneNumber();
                    break;
                case "6":
                    _adminController.LockAndUnlock();
                    break;
                case "7":
                    _adminController.LockAndUnlock();
                    break;
                case "8":
                    _adminController.ShowAllTransactionByAccountNumber();
                    break;
                case "9":
                    _adminController.UpdateInfo();
                    break;
                case "10":
                    _adminController.UpdatePassword();
                    break;
                case "11":
                    return;
                default:
                    Console.WriteLine("Invalid choice, Try Again");
                    break;
            }
        }
        
    }
}