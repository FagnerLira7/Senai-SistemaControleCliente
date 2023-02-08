namespace ClienLabC
{
    public class Clientes
    {
        public string nome { get; set; }
        public string endereco { get; set; }

        public float valor { get; protected set; }

        public float valorImposto { get; protected set; }

        public float total { get; protected set; }
        public void PagarImpostos(float v)
        {
            Console.WriteLine("IMPOSTO PAGO");
        }

    }
}