using Blazored.Toast;
using IPOPHLCopyright.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;
using static IPOPHLCopyright.Client.Pages.Index;

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NBaF5cXmZCekx0QXxbf1x0ZFRGalxYTndeUj0eQnxTdEFjXX5ZcnZVT2FdVEx1WA==\r\n");

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSyncfusionBlazor();
builder.Services.AddBlazorBootstrap();
builder.Services.AddBlazoredToast();

await builder.Build().RunAsync();


