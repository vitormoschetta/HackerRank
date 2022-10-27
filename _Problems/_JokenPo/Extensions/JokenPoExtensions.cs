using _JokenPo.Entities;

namespace _JokenPo.Extensions
{
    public static class JokenPoExtensions
    {
        public static Tipo GetTipo(this EJokenPo jokenPo)
        {
            switch (jokenPo)
            {
                case EJokenPo.Pedra:
                    return new Pedra();
                case EJokenPo.Papel:
                    return new Papel();
                case EJokenPo.Tesoura:
                    return new Tesoura();
                default:
                    throw new Exception("Tipo não encontrado");
            }
        }
    }
}