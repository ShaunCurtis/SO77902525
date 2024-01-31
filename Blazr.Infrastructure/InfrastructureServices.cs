using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;

namespace Blazr.Infrastructure;

public static class InfrastructureServices
{
    public static void AddInfrastructureServices(this IServiceCollection services)
    {

    }

    public static void AddAppEndPoints(this WebApplication app)
    {

        app.MapPost("/API/Weather/GetWeatherForecasts", async (ListRequest listRequest, IWeatherForecastProvider provider) =>
        {
            var result = await provider.GetWeatherForecastsAsync();
            // Pass the parameters and render the component
            var html = await renderer.RenderComponent<MixNutrientSheet>(new() { { nameof(MixNutrientSheet.MixUid), uid } });

            // Return the result as HTML
            return Results.Content(html, "text/html");
        });
    }

}
