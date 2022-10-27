using _JokenPo2.Enums;

namespace _JokenPo2.Entities
{
    public class Jogo
    {
        public static string Jogar2(Jogador jogador1, Jogador jogador2)
        {
            if (jogador1.JokenPo == jogador2.JokenPo)
                return "Empate";

            if (VenceDe(jogador1.JokenPo) == jogador2.JokenPo)
                return jogador1.Name;

            return jogador2.Name;
        }

        private static EJokenPo VenceDe(EJokenPo jokenPo)
        {
            return jokenPo switch
            {
                EJokenPo.Papel => EJokenPo.Pedra,
                EJokenPo.Pedra => EJokenPo.Tesoura,
                EJokenPo.Tesoura => EJokenPo.Papel,
                _ => throw new NotImplementedException()
            };
        }
    }
}