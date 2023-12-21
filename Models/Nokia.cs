namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero) : base(numero)
        {
        }
        public Nokia(string numero, string modelo, string emei, string memoria) : base(numero)
        {
            //IMPLEMENTADO Recebendo modelo
            Modelo = modelo;
            Console.WriteLine($"Modelo: {Modelo}");

            //IMPLEMENTADORecebendo IMEI
            Imei = emei;
            Console.WriteLine($"EMEI: {Imei}");

            //IMPLEMENTADORecebendo Memoria
            Memoria = memoria;
            Console.WriteLine($"Memoria: {Memoria}");
        }

        // IMPLEMENTADO Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Inslatando o aplicativo {nomeApp} no Nokia...");
        }
    }
}