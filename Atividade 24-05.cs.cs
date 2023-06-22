using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Média Aritmética ===");

        int[] valores = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1}º valor: ");
            valores[i] = int.Parse(Console.ReadLine());
        }

        int soma = 0;
        for (int i = 0; i < 10; i++)
        {
            soma += valores[i];
        }

        double media = (double)soma / 10;

        Console.WriteLine($"Média Aritmética: {media}");

        int quantidadeMaioresQueMedia = 0;
        for (int i = 0; i < 10; i++)
        {
            if (valores[i] > media)
            {
                quantidadeMaioresQueMedia++;
            }
        }

        Console.WriteLine($"Quantidade de valores maiores que a média: {quantidadeMaioresQueMedia}");

        Console.WriteLine();
        Console.WriteLine("=== Jogo do Acertou: Perdeu! ===");

        Console.Write("Digite a quantidade de participantes: ");
        int quantidadeParticipantes = int.Parse(Console.ReadLine());

        string[] participantes = new string[quantidadeParticipantes];

        for (int i = 0; i < quantidadeParticipantes; i++)
        {
            Console.Write($"Digite o nome do {i + 1}º participante: ");
            participantes[i] = Console.ReadLine();
        }

        Random random = new Random();
        int numeroOculto = random.Next(1, 101);
        int jogadorAtual = 0;

        while (true)
        {
            Console.WriteLine($"Jogador: {participantes[jogadorAtual]}");

            Console.Write("Digite um número: ");
            int numeroJogado = int.Parse(Console.ReadLine());

            if (numeroJogado == numeroOculto)
            {
                Console.WriteLine($"Parabéns, {participantes[jogadorAtual]}! Você acertou e ganhou o jogo.");
                break;
            }
            else
            {
                Console.WriteLine($"{participantes[jogadorAtual]} errou! Tente novamente.");
                jogadorAtual = (jogadorAtual + 1) % quantidadeParticipantes;
            }
        }
    }
}
