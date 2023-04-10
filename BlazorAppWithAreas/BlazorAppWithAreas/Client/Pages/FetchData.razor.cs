using System.Net.Http.Json;
using BlazorAppWithAreas.Shared;

namespace BlazorAppWithAreas.Client.Pages;

public partial class FetchData
{
    private WeatherForecast[]? forecasts;
    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
    }
}