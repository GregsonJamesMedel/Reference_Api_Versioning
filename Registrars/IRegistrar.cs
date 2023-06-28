namespace VMS.Api.Registrars;

public interface IRegistrar
{
    void RegisterServices(WebApplicationBuilder builder);
}