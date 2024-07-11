namespace P3ExamenNNTC_Calculadora
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Calculadora());
        }
    }
}