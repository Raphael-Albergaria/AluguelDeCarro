using System;
namespace LocateCar.Model;

public class Invoice
{
    public double BasicPaymenty { get; set; }
    public double Tax { get; set; }

    public double TotalPayment
    {
        get { return BasicPaymenty + Tax; }
    }

    public Invoice(double basicPaymenty, double tax)
    {
        BasicPaymenty = basicPaymenty;
        Tax = tax;
    }
    public override string ToString()
    {
        return $"Pag. Base : R${BasicPaymenty:F2} | Taxa: R${Tax:F2}\n"+
            $"Total Pago: R${TotalPayment:F2}";

    }
}

