public class Verificação{
   public List<string> Conhecimentos { get; set; } = new List<string>();
   public List<string> AreasDeAtuacao { get; set; } = new List<string>();

    public bool ValidaSeSabeConhecimento(string conhecimento)
    {
        return Conhecimentos.Contains(conhecimento)
            || AreasDeAtuacao.Contains(conhecimento);
    }
}
