namespace PlataformaCurso.Models;

public class Professor : Verificação
{
    public int NumeroCadastro { get; private set; }
    public string Nome { get; set; }
    public string GrauDeFormacao { get; set; } = "";

    public Professor(string nome)
    {
        this.Nome = nome;
    }


}