namespace DesafioPOO.Models
{
    // OK TODO: Herdar da classe "Smartphone"
    // FEITO!!
    public class Nokia : Smartphone
    {
        //Construtor
        public Nokia (string numero, string modelo, string IMEI2, int memoria) : 
                        base(numero, modelo, IMEI2, memoria)
        {

        }


        // OK TODO: Sobrescrever o método "InstalarAplicativo"
        // FEITO!!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando app {nomeApp} no Nokia...");

        }


    }
}