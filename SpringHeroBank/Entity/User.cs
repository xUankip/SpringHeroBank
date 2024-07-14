using System.Transactions;

namespace SpringHeroBank;

public class User 
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string PassWord { get; set; }
    public string FullName { get; set; }
    public string AccountNumber { get; set; }
    public string PhoneNumber { get; set; }
    public decimal Balance { get; set; }
    public Boolean Islock { get; set; } //1-active 0-lock
    public List<Transaction> Transactions { get; set; }
    
}