namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        // TODO: Herdar da classe "Smartphone"
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Console.WriteLine($"O iphone que tem o numero: {numero}, modelo: {modelo}, com o IMEI: {imei}, e armazenamento de: {memoria}Gb");

        }
        // TODO: Sobrescrever o método "InstalarAplicativo"

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o {nomeApp} no Iphone");
        }
    }
}