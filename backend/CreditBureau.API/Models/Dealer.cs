namespace CreditBureau.API.Models;

public class Dealer
{
    public int Id { get; set; }
    public string DealerName { get; set; } = "";
    public string DealerCode { get; set; } = "";
    public bool IsVerified { get; set; }
}