using System;

namespace JogarDados
{
    class Program
    {
        public static string jogador1;
        public static string jogador2;

        public static byte pontosJogador1;
        public static byte pontosJogador2;

        public static byte rodadaAtual;
        public static byte rodadaAtual2;




        static void Main(string[] args)
        {
            ConfigurarJogo();
            IniciarJogo();
        }

        public static void ConfigurarJogo()
        {   
            CriarJogadores();
            ConfigurarRodadas();
            AtualizarJogo();
            

        }
        public static void CriarJogadores()
        {
            Console.WriteLine("Digite o nome do jogador 1: ");
            jogador1 = Console.ReadLine();
            Console.WriteLine("Digite o nome do jogador 2: ");
            jogador2 = Console.ReadLine();
        }
        public static void AtualizarJogo()
        {
            Console.Clear();
            Console.WriteLine($"Jogador 1: {jogador1} | Pontos: {pontosJogador1}");
            Console.WriteLine($"Jogador 2: {jogador2} | Pontos: {pontosJogador2}");

            if(rodadaAtual == 0){
                Console.WriteLine("Jogo não iniciado!");
            }
        }
        public static void ConfigurarRodadas()
        {
            Console.WriteLine("Digite a quantidade de rodadas: ");
            rodadaAtual2 = byte.Parse(Console.ReadLine());
        }

        public static void IniciarJogo()
        {
            AtualizarJogo();
            if(rodadaAtual == rodadaAtual2){
                finalizarJogo();
                return;
            }
                rodadaAtual++;
                Random random = new Random();
                for(byte i = 1; i <= rodadaAtual; i++){
                    Console.WriteLine($"Rodada {i}");
                    Console.WriteLine("Aperte enter para jogar o dado");
                    Console.ReadLine();
                    byte resultadoJogador1 = (byte)random.Next(1, 7);
                    byte resultadoJogador2 = (byte)random.Next(1, 7);
                    Console.WriteLine($"Jogador 1 tirou: {resultadoJogador1}");
                    Console.WriteLine($"Jogador 2 tirou: {resultadoJogador2}");
                    if(resultadoJogador1 > resultadoJogador2){
                        pontosJogador1++;
                        Console.WriteLine($"Jogador 1 venceu a rodada {i}");
                }else if(resultadoJogador2 > resultadoJogador1){
                    pontosJogador2++;
                    Console.WriteLine($"Jogador 2 venceu a rodada {i}");
                }else{
                    Console.WriteLine("Empate!");
                }
                IniciarJogo();
            
        }
    }
    public static void finalizarJogo(){
        Console.Clear();
        Console.WriteLine("Jogo finalizado!");
        Console.WriteLine($"Jogador 1: {jogador1} | Pontos: {pontosJogador1}");
        Console.WriteLine($"Jogador 2: {jogador2} | Pontos: {pontosJogador2}");
        if(pontosJogador1 > pontosJogador2){
            Console.WriteLine($"Jogador 1 venceu o jogo!");
        }else if(pontosJogador2 > pontosJogador1){
            Console.WriteLine($"Jogador 2 venceu o jogo!");
        }else{
            Console.WriteLine("Empate!");
        }
    }
}
}
