using Refit;
using System;
using System.Threading.Tasks;

namespace Exercicio6
{
    class MainClass
    {
        //This is a Command Line Application that consumes an API using Refit.
        static async Task Main(string[] args)
        {
            try
            {
                var tzClient = RestService.For<DateTimeApiService>("http://worldclockapi.com");

                var Address = await tzClient.GetTzAsync("utc"); 

                DateTime datautc = Convert.ToDateTime($"{Address.CurrentDateTime}"); //converting the string to DateTime format
                DateTime datalocal = datautc.ToLocalTime(); //converting UTC DateTime to Local Time

                Console.WriteLine("Data/Hora UTC - " + datautc);
                Console.WriteLine("Data/Hora local - " + datalocal);

            }
            catch (Exception e)
            {
                Console.WriteLine("Erro na consulta de tz: " + e.Message);
            }
        }

    }
}
