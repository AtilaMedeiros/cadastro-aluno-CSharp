using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno[] listaAlunos = new Aluno[5]; //cria o array com 5 posicoes
            var indiceAluno = 0;

            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {

                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno: ");
                        var aluno = new Aluno(); //intancia a classe aluno e atribui o valor para a variavel aluno

                        aluno.Nome = Console.ReadLine(); 

                        Console.WriteLine("Informe a nota do aluno: ");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))  //Se o TryParse conseguir converter a note para decimal, ele preenche a variavel note, caso contrário define false e vai para o else
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("O valor da nota precisa ser decimal");
                        }

                        listaAlunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;

                    case "2":
                        foreach (var membro in listaAlunos)
                        {
                            if (!string.IsNullOrEmpty(membro.Nome)) // se a string nome não for vazio ou nulo, pode imprimir 
                            {
                                Console.WriteLine($"ALUNO: {membro.Nome} - NOTA: {membro.Nota}");
                            }
                        }

                        break;

                    case "3":
                        //TODO: Calcular média geral

                        break;

                    default:
                        throw new ArgumentOutOfRangeException();


                }

                opcaoUsuario = ObterOpcaoUsuario();

            }

        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("x - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
