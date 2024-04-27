using HRWASMConsumer.Models;
using HRWASMConsumer.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace HRWASMConsumer
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped<IServices<Employee>, EmployeeService>();

            builder.Services.AddScoped(sp => 
                new HttpClient {
                    BaseAddress = 
                        new Uri(builder.Configuration.GetValue<string>("IP"))
                });

            await builder.Build().RunAsync();
        }
    }
}
