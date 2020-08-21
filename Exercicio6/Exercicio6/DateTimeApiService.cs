using Refit;
using System.Threading.Tasks;

namespace Exercicio6
{
    public interface DateTimeApiService
    {
        [Get("/api/json/{tz}/now?callback=mycallback")] //Getting the string to put in the address
        Task<DateTimeResponse> GetTzAsync(string tz); 
    }
}



