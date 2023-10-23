public class RecebeNome
{

    public string nomeAluno { get; set; }
    public List<RecebeNota> lstNotas { get; set; }

}
public class RecebeNota

{
    public double notaMat { get; set; }
    public double notaPor { get; set; }
}