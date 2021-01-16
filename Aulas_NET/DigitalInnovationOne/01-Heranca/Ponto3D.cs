namespace DigitalInnovationOne.Heranca
{
    public class Ponto3D : Ponto
    {
        public int z;
        public Ponto3D(int x, int y, int z) : base(x, y)
        {
            this.z=z;
            CalcularDistancia();
        }
        public static void Calcular()
        {
            //Nao mexer
        }

        public override void CalcularDistancia3()
        {
            //Nao mexer
        }
    }
}