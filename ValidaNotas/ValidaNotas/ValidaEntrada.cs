public class ValidaEntrada
{

    public int ValidadorCaracter()
    {
        int notaAlunoValida;
        string notaAluno;
        bool validEntry = false;
        {
            do
            {
                notaAluno = Console.ReadLine();
                int.TryParse(notaAluno, out notaAlunoValida);
                if (notaAluno != null)
                {
                    if (Convert.ToDecimal(notaAluno) >= 0 && Convert.ToDecimal(notaAluno) <= 10)
                    {
                        validEntry = true;

                    }
                    else
                    {
                        Console.WriteLine("Você não digitou a nota correga, faça novamente.");
                    }
                }
            } while (validEntry == false);
            return notaAlunoValida;
        }
    }
}