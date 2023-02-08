namespace ClienLabC
{
    public class Clientes
    {
        public string nome { get; set; }
        public string endereco { get; set; }
        public float valor { get; protected set; }
        public float valorImposto { get; protected set; }
        public float total { get; protected set; }
        public virtual void PagarImpostos(float v)
        {
            this.valor = v;
            this.valorImposto = this.valor*10/100;
            this.total = this.valor + this.valorImposto;
        }

    }
}