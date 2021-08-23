namespace Havunen.Raygun4Net.Net5
{
  public class RaygunMiddlewareSettings
  {
    public IRaygunAspNetCoreClientProvider ClientProvider { get; set; }

    public RaygunMiddlewareSettings()
    {
      ClientProvider = new DefaultRaygunAspNetCoreClientProvider();
    }
  }
}