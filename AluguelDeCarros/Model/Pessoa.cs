namespace LocateCar.Model;

public class Pessoa
{
    public string Name { get; set; } = null!;
    public string Cpf { get; set; } = null!;
    public string Email { get; set; } = null!;

    public Pessoa()
    {

    }

    public Pessoa(string cpf, string name, string email)
    {
        Name = name;
        Cpf = cpf;
        Email = email;
    }
}