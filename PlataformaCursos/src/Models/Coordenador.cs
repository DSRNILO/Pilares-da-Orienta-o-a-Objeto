namespace PlataformaCurso.Models;

public class Coordenador : Verificação
{
    public int NumeroCadastro { get; private set; }
    public string Nome { get; set; }
    public string GrauDeFormacao { get; set; } = "";
    

    public Coordenador(string nome)
    {
        this.Nome = nome;
    }

}