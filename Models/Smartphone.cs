namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {        
        // OK TODO: Implementar as propriedades faltantes de acordo com o diagrama
            //IMPLEMENTADO!!
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }


        //Construtor
        // OK TODO: Passar os parâmetros do construtor para as propriedades
            //FEITO!!
        public Smartphone(string numero, string modelo, string IMEI2, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = IMEI2;
            Memoria = memoria;
            
        }

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