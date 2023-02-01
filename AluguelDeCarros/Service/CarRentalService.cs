using System.Data;
using LocateCar.Model;
using LocateCar.Util;

namespace LocateCar.Service
{
    public class CarRentalService
    {
        public double PricePerDay { get; set; }
        public double PricePerHour { get; set; }

        private BrasilTaxService _taxService;

        public CarRentalService(double pricePerDay, double pricePerHour)
        {
            PricePerDay = pricePerDay;
            PricePerHour = pricePerHour;
            _taxService = new BrasilTaxService();
        }

        public void ProcessInvoice(CarRental carRental)
        {
            if (carRental.Finish == null)
                return;

            TimeSpan time = (TimeSpan)(carRental.Finish - carRental.Start);
            double basicPayment = 0, tax = 0;
            int timeMinutes = time.Minutes;
            int timeHours = time.Hours;
            int timeDays = time.Days;

            if(time.Minutes > 0)
            {
                timeMinutes = 0;
                timeHours++;
            }

            if (timeHours > 12.0)
            {
                timeHours = 0;
                timeDays++;
            }
                basicPayment = PricePerDay * timeDays + PricePerHour * timeHours;



            tax = _taxService.Tax(basicPayment);
            carRental.Invoice = new Invoice(basicPayment, tax);

        }
    }
}
