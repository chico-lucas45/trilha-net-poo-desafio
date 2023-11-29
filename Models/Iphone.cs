namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public void InstalarAplicativo(string nomeApp)
        {
            if (nomeApp == null)
            {
                Console.WriteLine("Essa aplicação não existe");
            }

            else
            {
                Console.WriteLine($"Baixando {nomeApp}... Por favor aguarde.");
                Thread.Sleep(1000);
                Console.WriteLine($"Pronto! {nomeApp} foi instalado com sucesso.");
            }
        }
    }
}