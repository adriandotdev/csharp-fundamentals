public interface IPayment
{
    decimal ProcessingFee { get; set; }
    void ProcessPayment(decimal amount);
}

public class GCash : IPayment
{
    public decimal ProcessingFee { get; set; } = 0.02m; // 2% processing fee

    public void ProcessPayment(decimal amount)
    {
        decimal totalAmount = amount + (amount * ProcessingFee);
        Console.WriteLine($"Processing GCash payment of {totalAmount:C} (including processing fee).");
    }
}

public class Maya : IPayment
{
    public decimal ProcessingFee { get; set; } = 0.015m; // 1.5% processing fee

    public void ProcessPayment(decimal amount)
    {
        decimal totalAmount = amount + (amount * ProcessingFee);
        Console.WriteLine($"Processing Maya payment of {totalAmount:C} (including processing fee).");
    }
}


public class PaymentManager
{
    private IPayment _paymentMethod;

    public PaymentManager(IPayment paymentMethod)
    {
        this._paymentMethod = paymentMethod;
    }

    public void MakePayment(decimal amount)
    {
        this._paymentMethod.ProcessPayment(amount);
    }

    public void SetPaymentMethod(IPayment paymentMethod)
    {
        if (paymentMethod == null)
        {
            throw new ArgumentNullException(nameof(paymentMethod), "Payment method cannot be null.");
        }
        this._paymentMethod = paymentMethod;
    }
}


public class AbstractionAndInterfaceExample
{
    public static void DisplayAbstractionAndInterface()
    {
        var paymentManager = new PaymentManager(new GCash());
        paymentManager.MakePayment(1000); // Process GCash payment

        paymentManager.SetPaymentMethod(new Maya());
        paymentManager.MakePayment(2000); // Process Maya payment
    }
}

