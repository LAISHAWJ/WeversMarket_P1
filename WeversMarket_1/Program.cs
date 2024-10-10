using Microsoft.Data.SqlClient;

namespace WeversMarket_1
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new StartForm());
        }
    }
}