namespace Programatica.Saft.Models
{
    public interface IPaymentMethod
    {
        string PaymentAmount { get; set; }
        string PaymentDate { get; set; }
        string PaymentMechanism { get; set; }
    }
}