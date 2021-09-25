using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Ceilingfish.TimesTableFreestyle;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

await builder.Build().RunAsync();
