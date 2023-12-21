namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        //IMPLEMENTADO propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero)
        {
            Numero = numero;
        }
        //IMPLEMENTADO Passar os parâmetros do construtor para as propriedades:
        //modelo
        protected string Modelo;
        //IMEI
        protected string Imei;
        //Memoria
        protected string Memoria;

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}