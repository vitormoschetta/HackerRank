namespace _JokenPo.Entities
{
    public class Papel : Tipo
    {
        public Papel()
        {
            VenceDe = new List<EJokenPo>
            {
                EJokenPo.Pedra
            };
        }        
    }
}