using Blazored.Toast;
using IPOPHLCopyright.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Popups;
using static IPOPHLCopyright.Client.Pages.Index;

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBPh8sVXJxS0d+X1RPd11dXmJWd1p/THNYflR1fV9DaUwxOX1dQl9nSXtTdUViWHpbdn1SR2g=;Mgo+DSMBMAY9C3t2UFhhQlJBfV5AQmBIYVp/TGpJfl96cVxMZVVBJAtUQF1hTX5WdkZjWH5bdXNVRWRf;MzI1NDY1NEAzMjM1MmUzMDJlMzBNMEpJem42WHBXVStSTzVWWDVNRXdQaGtTR2xzVGExSTdvMDZ5TWJkZTEwPQ==\r\n");

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSyncfusionBlazor();
builder.Services.AddBlazorBootstrap();
builder.Services.AddBlazoredToast();

builder.Services.AddScoped<SfDialogService>();




await builder.Build().RunAsync();




