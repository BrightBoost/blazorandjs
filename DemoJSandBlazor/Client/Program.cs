using DemoJSandBlazor.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace DemoJSandBlazor
{
    // maak een derde kolom in je gastenboek
    // als je er op klikt dan triggert dat (indirect via een wrapper) een JavaScriptje dat de knop in een hartje (of een x) verandert
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<InteropExample>();

            await builder.Build().RunAsync();
        }
    }
}