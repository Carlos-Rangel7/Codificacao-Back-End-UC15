namespace Back_End_ER06.Classes
{
    public class Utils
    {
        public static void BarraCarregamento(string texto)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Blue;

            Console.WriteLine($"{texto}");
            for (var i = 0; i < 10; i++)
            {
                Console.Write($"=");
                Thread.Sleep(250);
            }
            Console.ResetColor();
            Console.Clear();

        }

        public static void VerificarPastaArquivo(string caminho)
        {
            string pasta = caminho.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(caminho))
            {
                using (File.Create(caminho)) { }
            }

        }
    }
}