using System;

namespace MediaNotas
{
    class Program
    {

        // Inicia o programa

        public static void Main(string[] args)
        {
            Console.WriteLine(CalculaMediaNotas(5, 5, 5));
        }

        /// <summary>
        /// Método responsável por calcular a média das três notas.
        /// </summary>
        /// <param name="primeiraNota"></param>
        /// <param name="segundaNota"></param>
        /// <param name="terceiraNota"></param>
        /// <returns>
        /// Retorna a média das três notas passadas como parâmetros.
        /// </returns>

        public static double CalculaMediaNotas(int primeiraNota, int segundaNota, int terceiraNota)
        {
            return (primeiraNota + segundaNota + terceiraNota) / 3;
        }
    }
}
