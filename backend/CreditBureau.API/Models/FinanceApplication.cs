namespace CreditBureau.API.Models;

public class FinanceApplication
{
    public int Id { get; set; }
    public string ApplicantName { get; set; } = "";
    public decimal RequestedAmount { get; set; }
    public string Status { get; set; } = "";
}