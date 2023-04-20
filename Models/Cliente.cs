namespace LHPet;


public class Cliente
{
    public int Id {get; set;}

    public string? Nome {get; set;}

    public string? Cpf {get; set;}

    public string? Email {get; set;}

    public string? Paciente {get; set;}

    public string Tipo {get; set;}

    public Cliente(int id, string nome, string cpf,string email,string paciente, string tipo)
    {
        this.Id = id;
        this.Nome = nome;
        this.Cpf = cpf;
        this.Email = email;
        this.Paciente = paciente;
        this.Tipo = tipo;
    }

}