using CreditBureau.API.Models;

namespace CreditBureau.API.Services;

public class CreditBureauService
{
    public CreditReport PullCredit(string customerName)
    {
        var random = new Random();

        int score = random.Next(550, 850);

        return new CreditReport
        {
            CustomerName = customerName,
            CreditScore = score,
            Status = score >= 700 ? "Approved" : "Manual Review"
        };
    }
}