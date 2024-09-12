namespace JogoAdivinhação3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, escolha = 0, cont = 0; 
            bool exceptionOccureed = false; 

            Random segredo = new Random();
            n = Convert.ToInt32(segredo.Next(1,10)); // gerou um valor aleatório do jogo
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("*** JOGO DA ADIVINHAÇÃO");
                    Console.WriteLine("Adivinhe o número que eu pensei!");
                    Console.WriteLine("Dica: O número está entre 1 e 10");
                    Console.WriteLine("Digite um valor:");
                    while (escolha != n)
                    {
                        escolha = Convert.ToInt32(Console.ReadLine());
                        if (escolha > n)
                            Console.WriteLine("Errado! O número é menor");
                        else if (escolha < n)
                            Console.WriteLine("Errado! O número é maior");
                        else if (escolha == n && cont == 0)
                            Console.WriteLine("iNCRÍVEL! Você acertou");
                        else
                            Console.WriteLine("Acertou!!!" + n + "era o número");
                        cont++;
                    }
                    Console.WriteLine("Número de tentativas" + cont); 
                    Console.ReadKey();
                    exceptionOccureed = false; 
                }
                catch(FormatException)
                {
                    Console.WriteLine("Sinto muito, você perdeu");
                    Console.WriteLine("Digite apenas números!!");
                    Console.WriteLine("Pressione qualquer tecla");
                    Console.ReadKey();
                    exceptionOccureed = true;
                }
            }while (exceptionOccureed);
           
        }
    }
}
