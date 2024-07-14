namespace SpringHeroBank;

public class Transactions
{

    public double Id { get; set; } //id giao dịch
    public DateTime CreatedAt { get; set; } //thời gian tạo giao dịch
    public string Type { get; set; }  //withdraw-deposit-transfer
    public double Amount { get; set; } //số tiền chuyển khoản
    public string SenderAccountNumber { get; set; } //số tk người gửi
    public string ReceiverAccountNumber { get; set; } //số tk người nhận.
    public string Message { get; set; } //nội dung giao dịch
    public Boolean Status { get; set; } //trạng thái giao dịch
    
    public Transactions(double id, DateTime createdAt, string type, double amount, string senderAccountNumber, string receiverAccountNumber, string message, bool status)
    {
        Id = id;
        CreatedAt = createdAt;
        Type = type;
        Amount = amount;
        SenderAccountNumber = senderAccountNumber;
        ReceiverAccountNumber = receiverAccountNumber;
        Message = message;
        Status = status;
    }
}