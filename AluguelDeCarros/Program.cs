
using LocateCar.Model;
using LocateCar.Service;
using LocateCar.View;

namespace LocateCar;
class Program
{
    public static void Main(string[] args)
    {
        Pessoa pessoa = PessoaView.MenuNovaPessoa();
        Car car = new Car("ASD005", "Ferrari");
        DateTime start = new DateTime(2023, 01, 25, 10, 00, 00);
        DateTime finish = new DateTime(2023, 01, 25, 15, 30, 00);
        TimeSpan duracao = finish - start;
        Console.WriteLine($"Duração : {duracao.Hours}");
        CarRental aluguel = new CarRental(1L, start, finish, car, pessoa);

        CarRentalService service = new CarRentalService(150, 15);
        service.ProcessInvoice(aluguel);
        Console.WriteLine(aluguel);

    }
}

