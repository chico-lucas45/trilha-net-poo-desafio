namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public void InstalarAplicativo(string nomeApp)
        {
            if (nomeApp == null)
            {
                Console.WriteLine("Essa aplicação não existe :(");
            }

            else
            {
                Console.WriteLine($"Baixando {nomeApp}... Calma que o nókia é lentinho");
                Thread.Sleep(5000);
                Console.WriteLine("Pera, tá quase");
                Thread.Sleep(5000);
                Console.WriteLine($"Pronto! {nomeApp} foi instalado com sucesso.");
            }
        }
    }
}