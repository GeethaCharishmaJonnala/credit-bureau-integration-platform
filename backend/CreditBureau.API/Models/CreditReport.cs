namespace CreditBureau.API.Models;

public class CreditReport
{
    public int Id { get; set; }
    public string CustomerName { get; set; } = "";
    public int CreditScore { get; set; }
    public string Status { get; set; } = "";
}