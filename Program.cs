using hashing.src;
using System;

namespace hashing {

    class Program {

        static void Main(string[] args) {
            TabelaHash musicas = new TabelaHash();

            var chaveAero = "Aerosmith";
            var valorAero = /* frase */
                "I Don’t Want to Miss a Thing " +
                "[I Don't Want to Miss a Thing - 1998]";
            musicas.Inserir(chaveAero, valorAero);

            var chaveStones = "The Rolling Stones";
            var valorStones = /* frase */
                "Rocks off " +
                "[Exile On Main St. - 1972]";
            musicas.Inserir(chaveStones, valorStones);

            var chaveAustin = "austin chen";
            var valorAustin = /* frase */
                "away " +
                "[goodbye - 2018]";
            musicas.Inserir(chaveAustin, valorAustin);

            var chaveQueen = "Queen";
            var valorQueen = /* frase */
                "Don't Stop Me Now " +
                "[Jazz - 1978]";
            musicas.Inserir(chaveQueen, valorQueen);

            Console.WriteLine("Aerosmith          => " + musicas["Aerosmith"]);
            Console.WriteLine("The Rolling Stones => " + musicas["The Rolling Stones"]);
            Console.WriteLine("austin chen        => " + musicas["austin chen"]);
            Console.WriteLine("Queen              => " + musicas["Queen"]);
        } // Main

    } // class Program
} // namespace hashing
