namespace Ecommerce.WebApp;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    { }
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (!env.IsDevelopment())
        {
            app.UseHsts();
        }
        //UseRouting mục tiêu là định tuyến tới url
        app.UseRouting(); // start endpoint routing
        app.UseHttpsRedirection();
        //UseDefaultFiles() dòng này cấu hình enable statics file(mặc định là index file)
        app.UseDefaultFiles();
        app.UseStaticFiles();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapGet("/hello", () => "Hello World!");
        });
    }
}
