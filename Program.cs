using System;

class Program()
{
    static void Main()
    {
        /*
        int Idade = 17;

        if (Idade >= 18)
        {

            Console.WriteLine("Você é maior de idade");

        }
        else
        {

            Console.WriteLine("Você é menor de idade");

        }
        */

        Console.WriteLine("Começar Partida? (s/n): ");
        string SouN = Console.ReadLine();

        switch (SouN)
        {
            case "s":

                //Idade
                Console.WriteLine("Qual sua Idade?");
                int idade = int.Parse(Console.ReadLine());

                if(idade >= 12)
                {

                    //Nome
                    Console.WriteLine("Qual seu nome?");
                    string nome = Console.ReadLine();

                    //Classe
                    Console.WriteLine("Qual Classe:");
                    Console.WriteLine("  1. Guerreiro");
                    Console.WriteLine("  2. Mago");
                    Console.WriteLine("  3. Arqueiro");
                    int classe = int.Parse(Console.ReadLine());

                    Console.WriteLine("Nome: " + nome);
                    Console.WriteLine("Idade: " + idade);

                    if(idade == 12)
                    {
                        Console.WriteLine("Categoria: Jogador Criança");
                    }
                    else if (idade < 18)
                    {
                        Console.WriteLine("Categoria: Jogador Adolecente");

                    }
                    else if (idade >= 18) {

                        Console.WriteLine("Categoria: Jogador Adulto");
                    }

                    switch (classe)
                    {
                        case 1:
                            Console.WriteLine("Classe: Guerreiro");
                            break;

                        case 2:
                            Console.WriteLine("Classe: Mago");
                            break;

                        case 3:
                            Console.WriteLine("Classe: Arqueiro");
                            break;

                        default:
                            Console.WriteLine("Invalido!");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Partida Negada devido falta de idade!");
                }

                break;

            case "n":

                Console.WriteLine("Volte Sempre!");
                break;

            default:

                Console.WriteLine("Invalido!");
                break;

        }
        

    }
}