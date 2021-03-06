using Microsoft.AspNetCore.Http;

namespace Havunen.Raygun4Net.Net5
{
  public interface IRaygunAspNetCoreClientProvider
  {
    RaygunClient GetClient(RaygunSettings settings);
    RaygunClient GetClient(RaygunSettings settings, HttpContext context);
    RaygunSettings GetRaygunSettings(RaygunSettings baseSettings);
  }

  public class DefaultRaygunAspNetCoreClientProvider : IRaygunAspNetCoreClientProvider
  {
    public virtual RaygunClient GetClient(RaygunSettings settings)
    {
      return GetClient(settings, null);
    }

    public virtual RaygunClient GetClient(RaygunSettings settings, HttpContext context)
    {
      return new RaygunClient(settings, context);
    }

    public virtual RaygunSettings GetRaygunSettings(RaygunSettings baseSettings)
    {
      return baseSettings;
    }
  }
}