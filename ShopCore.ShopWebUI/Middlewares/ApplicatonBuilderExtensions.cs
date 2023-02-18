using Microsoft.Extensions.FileProviders;

namespace ShopCore.ShopWebUI.Middlewares
{
    public static class ApplicatonBuilderExtensions
    {
        public static IApplicationBuilder CustomStaticFiles(this IApplicationBuilder app)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");

            var options = new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(path),
                RequestPath = "/root"
            };

            app.UseStaticFiles(options);

            return app;
        }
    }
}
