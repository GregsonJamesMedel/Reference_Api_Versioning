using VMS.Api.Options;

namespace VMS.Api.Registrars;

public class SwaggerRegistrar : IRegistrar
{
    public void RegisterServices(WebApplicationBuilder builder)
    {
        builder.Services.AddSwaggerGen();
        builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();
    }
}