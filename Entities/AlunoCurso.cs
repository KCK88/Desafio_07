namespace Desafio_07.Entities;

public class AlunoCurso
{
    public AlunoCurso(int idAluno, int idCurso, string status, int nota)
    {
        IdAluno = idAluno;
        IdCurso = idCurso;
        Status = status;
        Nota = nota;
    }

    public int IdAluno { get; set; }
    public int IdCurso { get; set; }
    public string Status { get; set; }
    public int Nota { get; set; }
}