using System.ComponentModel.DataAnnotations;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero) : base(numero)
        {
        }

        public Iphone(string numero, string modelo, string emei, string memoria) : base(numero)
        {
            //IMPLEMENTADO Recebendo modelo
            Modelo = modelo;
            Console.WriteLine($"Modelo: {Modelo}");

            //IMPLEMENTADO Recebendo IMEI
            Imei = emei;
            Console.WriteLine($"EMEI: {Imei}");

            //IMPLEMENTADO Recebendo Memoria
            Memoria = memoria;
            Console.WriteLine($"Memoria: {Memoria}");

        }

        //IMPLEMENTADO Sobrescrever o método "InstalarAplicativo"

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Inslatando o aplicativo {nomeApp} no Iphone...");
        }
    }
}