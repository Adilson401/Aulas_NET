
namespace DigitalInnovationOne.Heranca
{
    public class Ponto
    {
        public int x, y;

        private int distancia;
        public Ponto(int x, int y)
        {
            this.x=x;
            this.y=y;

        }
        protected void CalcularDistancia()
        {
            //Não mexer
        }

        private void CalcularDistancia2()
        {
            //Nao mexer
        }
        public virtual void CalcularDistancia3()
        {
            //Nao mexer
        }
    }
    
}