namespace SistemaDeHospedagem.Models;

public class Hospede {
    public Hospede() { }

    public Hospede(string nome) {
        Nome = nome;
    }

    public Hospede(string nome, string sobrenome) {
        Nome = nome;
        Sobrenome = sobrenome;
    }

    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
}
