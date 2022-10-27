namespace _JokenPo.Entities
{
    public class Tesoura : Tipo
    {
        public Tesoura()
        {
            VenceDe = new List<EJokenPo>
            {
                EJokenPo.Papel
            };
        }
    }
}