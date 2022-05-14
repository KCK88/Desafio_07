namespace Desafio_07.Entities;

public class Aluno
{
    public Aluno(int id, string nome, int idade)
    {
        Id = id;
        Nome = nome;
        Idade = idade;
    }

    public int Id { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }
}