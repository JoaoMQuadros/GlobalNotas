namespace IniciandoProgramacaoTeste
{
    class program
    {
        static void Main(string[] args)
        {
            RecolheNota recebeNota = new RecolheNota();
            //Informação para o usuário
            Console.WriteLine("|******************|");
            Console.WriteLine("|***Bem vindo ao Validador de notas !!!**|");
            Console.WriteLine("|******************|");
            recebeNota.RecebeNota();
        }
    }

    //---------------------------------------------------------------------------------------------------------------------------//
    public class RecolheNota
    {
        public List<RecebeNota> RecebeNota()
        {
            List<RecebeNota> lstNotasB1 = new List<RecebeNota>();
            RecebeNome teste = new RecebeNome();
            teste.lstNotas = new List<RecebeNota>();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("|***Qual o nome do aluno(a) ?******|");
                teste.nomeAluno = Console.ReadLine();
                for (int j = 0; j < 2; j++)
                {
                    RecebeNota recebe = new RecebeNota();
                    ValidaEntrada teste2 = new ValidaEntrada();
                    // Começa a recolher as informações
                    Console.WriteLine($"|***Qual a nota do {teste.nomeAluno} em Matemática ?***|");
                    recebe.notaMat = teste2.ValidadorCaracter();
                    Console.WriteLine($"|***Qual a nota do {teste.nomeAluno} em Português  ?***|");
                    recebe.notaPor = teste2.ValidadorCaracter();
                    lstNotasB1.Add(recebe);
                }
            }
            return lstNotasB1;
        }
    }
    //---------------------------------------------------------------------------------------------------------------------------//

}