using System.Collections;

namespace Forca
{
    class Desafio
    {
        static void Main(string[] args)
        {
            String[] palavrasDesafio = { "newbie", "ravioli", "alohomora", "canela", "hortela", "doguinha", "espaguete", "frança" };
            Random randomic = new Random();

            string palavraAleatoria = palavrasDesafio[randomic.Next(palavrasDesafio.Length)];
            char[] letrasPalavraAleatoria = palavraAleatoria.ToCharArray();
            List<char> letrasCorretas = new List<char>();



            while (true)
            {
                char letraEscolhida;
                Console.Write("Escolha uma letra: ");
                letraEscolhida = Convert.ToChar(Console.ReadLine());

                if (letrasCorretas.Contains (letraEscolhida))
                {
                    letraEscolhida = '_';
                }

                for (int j = 0; j < letrasPalavraAleatoria.Length; j++)
                {
                    if (letraEscolhida == letrasPalavraAleatoria[j] || letrasCorretas.Contains(letrasPalavraAleatoria[j]))
                    {
                        if (letraEscolhida == letrasPalavraAleatoria[j])
                        {
                            letrasCorretas.Add(letrasPalavraAleatoria[j]);
                        }

                        Console.Write(letrasPalavraAleatoria[j]);
                    }
                    else
                    {
                        Console.Write('_');
                    }

                }
                Console.WriteLine();
                if (letrasCorretas.Count == letrasPalavraAleatoria.Length)
                {
                    break;
                }
            }


            Console.WriteLine("Parabéns você acertou a palavra!");


        }
    }
}
