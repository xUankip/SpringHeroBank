namespace SpringHeroBank;

public class Transactions
{

    public double Id { get; set; } //id giao dịch
    public DateTime CreatedAt { get; set; } //thời gian tạo giao dịch
    public string Type { get; set; }  //withdraw-deposit-transfer
    public double Amount { get; set; } //số tiền chuyển khoản
    public string SenderAccountNumber { get; set; } //số tk người gửi
    public string ReceiverAccountNumber { get; set; } //số tk người nhận.
    public Boolean Status { get; set; } //trạng thái giao dịch
    
}