namespace Diamante.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int asteriscos, espacos;

            while (true)
            {
                Console.Clear();
                Console.Write("Digite um número impar: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 2 == 1)
                {
                    asteriscos = 1;
                    espacos = (numero - 1) / 2;
                    for (int linha = 1; espacos > 0; linha++)
                    {

                        for (int count = 1; count <= espacos; count++)
                        {
                            Console.Write(" ");
                        }


                        for (int count = 1; count <= asteriscos; count++)
                        {
                            Console.Write("*");
                        }

                        espacos--;
                        asteriscos += 2;
                        Console.WriteLine();
                    }

                    for (int linha = 1; asteriscos > 0; linha++)
                    {


                        for (int count = 1; count <= espacos; count++)
                        {
                            Console.Write(" ");
                        }


                        for (int count = 1; count <= asteriscos; count++)
                        {
                            Console.Write("*");
                        }

                        espacos++;
                        asteriscos -= 2;
                        Console.WriteLine();
                    }
                }

                else
                {
                    Console.WriteLine("Não é Impar! ");
                }
                Console.ReadLine();
                continue;
            }
        }
    }
}