namespace _JokenPo.Entities
{
    public class Pedra : Tipo
    {
        public Pedra()
        {
            VenceDe = new List<EJokenPo>
            {
                EJokenPo.Tesoura
            };
        }        
    }
}