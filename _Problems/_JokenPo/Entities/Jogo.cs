using _JokenPo.Extensions;

namespace _JokenPo.Entities
{
    public class Jogo
    {
        public static string Jogar(Jogador jogador1, Jogador jogador2)
        {
            if (jogador1.JokenPo == jogador2.JokenPo)
                return "Empate";

            var tipo = jogador1.JokenPo.GetTipo();

            if (tipo.VenceDe.Contains(jogador2.JokenPo))
                return jogador1.Name;

            return jogador2.Name;
        }
    }
}