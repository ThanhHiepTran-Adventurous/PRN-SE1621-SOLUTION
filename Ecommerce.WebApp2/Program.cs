using Ecommerce.WebApp2;

Host.CreateDefaultBuilder(args)
.ConfigureWebHostDefaults(webBuilder =>
{
    webBuilder.UseStartup<Startup>();
}).Build().Run();
Console.WriteLine("This executes after the web server has stopped!");